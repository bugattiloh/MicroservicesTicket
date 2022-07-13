using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MicroservicesTicket.ValidationAttributes.ValidationSchemaAttribute;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesTicket.Dto
{
    [ModelBinder(typeof(CustomBinder))]
    public class TicketDto
    {
        [Required]
        [RegularExpression("(sale|refund){1}", ErrorMessage = "OperationType error")]
        public string OperationType { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OperationTime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string OperationPlace { get; set; }

        [Required(AllowEmptyStrings = false)]
        public PassengerDto Passenger { get; set; }

        [Required]
        public ICollection<RouteDto> Routes { get; set; }
    }
}