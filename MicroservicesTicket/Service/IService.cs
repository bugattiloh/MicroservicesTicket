using System.Threading.Tasks;
using MicroservicesTicket.Dto;

namespace MicroservicesTicket.Service
{
    public interface IService
    {
        Task Sale(TicketDto ticketDto);
        Task Refund(RefundDto refundDto);
    }
}