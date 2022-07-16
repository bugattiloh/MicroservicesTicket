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
        public SegmentClient Client { get; set; }

        public Service(IMapper mapper)
        {
            Client = new SegmentClient("http://localhost:8079");
            _mapper = mapper;
        }

        public async Task Sale(TicketDto ticketDto)
        {
            // var tickets = _mapper.Map<Ticket>(ticketDto);
            await Client.SaleAsync(ticketDto);
            //TODO
        }

        public async Task Refund(RefundDto refundDto)
        {
            var refund = _mapper.Map<Refund>(refundDto);
            await Client.RefundAsync(refundDto);
            //TODO
        }
    }
}