using AutoMapper;
using MicroservicesTicket.Dto;
using MicroservicesTicket.Models;

namespace MicroservicesTicket
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketDto, Ticket>();
            CreateMap<PassengerDto, Passenger>();
            CreateMap<RouteDto, Route>();
            CreateMap<RefundDto, Refund>();
        }
    }
}