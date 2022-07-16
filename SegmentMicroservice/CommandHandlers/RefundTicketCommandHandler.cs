using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MicroservicesTicket.Exceptions;
using SegmentMicroservice.Models;
using SegmentMicroservice.Repository;
using SegmentMicroservice.Tickets.Commands.RefundTicket;

namespace SegmentMicroservice.CommandHandlers
{
    public class RefundTicketCommandHandler : IRequestHandler<RefundTicketCommand>
    {
        private readonly ISegmentRepository _repository;
        private readonly IMapper _mapper;

        public RefundTicketCommandHandler(IMapper mapper, ISegmentRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(RefundTicketCommand request, CancellationToken cancellationToken)
        {
            var refund = _mapper.Map<Refund>(request.RefundDto);
            var refundSegmentsFromDb =
                await _repository.FindRefundSegmentsWithSameTicketNumberAsync(refund.TicketNumber);
            if (refundSegmentsFromDb.Count == 0)
            {
                throw new RefundsWithSameTicketNumberIsNotFoundException("Duplicate error");
            }

            foreach (var segment in refundSegmentsFromDb)
            {
                segment.OperationType = "refund";
            }

            await _repository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}