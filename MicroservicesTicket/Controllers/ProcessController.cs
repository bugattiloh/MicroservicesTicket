using System.Threading.Tasks;
using MicroservicesTicket.Dto;
using MicroservicesTicket.Service;
using MicroservicesTicket.ValidationAttributes.ValidationSchemaAttribute;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesTicket.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]/[action]")]
    [ValidateModel]
    [RequestSizeLimit(2 * 1024)]
    public class ProcessController : Controller
    {
        private readonly IService _service;

        public ProcessController(IService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<IActionResult> Sale([FromBody] TicketDto ticketDto)
        {
            await _service.Sale(ticketDto);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Refund([FromBody] RefundDto refundDto)
        {
            await _service.Refund(refundDto);
            return Ok();
        }
    }
}