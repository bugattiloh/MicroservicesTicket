using AutoMapper;
using SegmentMicroservice.Dto;
using SegmentMicroservice.Models;

namespace SegmentMicroservice
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