using MediatR;
using SegmentMicroservice.Dto;

namespace SegmentMicroservice.Tickets.Commands.SaleTicket
{
    public class SaleTicketCommand : IRequest
    {
        public TicketDto TicketDto { get; set; }

        public SaleTicketCommand(TicketDto ticketDto)
        {
            TicketDto = ticketDto;
        }
    }
}