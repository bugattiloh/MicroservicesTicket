using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MicroservicesTicket.Dto;
using MicroservicesTicket.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesTicket.Service
{
    public class Service : IService
    {
        private readonly IMapper _mapper;

        public Service(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task Sale(TicketDto ticketDto)
        {
            var tickets = _mapper.Map<Ticket>(ticketDto);
            //TODO
        }

        public async Task Refund(RefundDto refundDto)
        {
            var refund = _mapper.Map<Refund>(refundDto);
            //TODO
        }
    }
}