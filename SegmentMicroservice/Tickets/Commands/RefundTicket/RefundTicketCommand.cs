using MediatR;
using SegmentMicroservice.Dto;

namespace SegmentMicroservice.Tickets.Commands.RefundTicket
{
    public class RefundTicketCommand: IRequest
    {
        public RefundDto RefundDto { get; set; }

        public RefundTicketCommand(RefundDto refundDto)
        {
            RefundDto = refundDto;
        }
    }
}