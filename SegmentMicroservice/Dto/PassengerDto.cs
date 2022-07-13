using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SegmentMicroservice.Dto
{
    public class PassengerDto
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Patronymic { get; set; }

        [Required]
        public string DocType { get; set; }

        [Required]
        public string DocNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        [RegularExpression("[MF]{1}", ErrorMessage = "gender validation error")]
        public string Gender { get; set; }

        [Required]
        [RegularExpression("(youth|adult|senior){1}", ErrorMessage = "PassengerType validation error")]
        public string PassengerType { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string TicketNumber { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "TicketType validation error")]
        public int TicketType { get; set; }
    }
}