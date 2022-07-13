using System;
using System.ComponentModel.DataAnnotations;
using MicroservicesTicket.ValidationAttributes.ValidationSchemaAttribute;
using MicroservicesTicket.ValidationAttributes.ValidationValuesAttributes;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesTicket.Dto
{
    [ModelBinder(typeof(CustomBinder))]
    public class RouteDto
    {
        [Required(AllowEmptyStrings = false)]
        [OnlyLetters]
        public string AirlineCode { get; set; }

        [Required]
        public int FlightNum { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string DepartPlace { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartDatetime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ArrivePlace { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ArriveDatetime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string PnrId { get; set; }
    }
}