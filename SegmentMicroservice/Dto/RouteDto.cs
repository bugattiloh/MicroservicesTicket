using System;
using System.ComponentModel.DataAnnotations;

namespace SegmentMicroservice.Dto
{
    public class RouteDto
    {
        [Required(AllowEmptyStrings = false)]
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