using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SegmentMicroservice.Dto;
using SegmentMicroservice.Tickets.Commands.RefundTicket;
using SegmentMicroservice.Tickets.Commands.SaleTicket;

namespace SegmentMicroservice.Controllers
{
    public class SegmentController : Controller
    {
        private readonly IMediator _mediator;

        public SegmentController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Sale([FromBody] TicketDto ticketDto)
        {
            await _mediator.Send(new SaleTicketCommand(ticketDto));
            // await _segmentService.Sale(ticketDto);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Refund([FromBody] RefundDto refundDto)
        {
            await _mediator.Send(new RefundTicketCommand(refundDto));
            return Ok();
        }
    }
}