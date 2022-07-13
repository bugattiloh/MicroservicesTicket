using System;
using System.ComponentModel.DataAnnotations;
using MicroservicesTicket.ValidationAttributes.ValidationSchemaAttribute;
using MicroservicesTicket.ValidationAttributes.ValidationValuesAttributes;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesTicket.Dto
{
    [ModelBinder(typeof(CustomBinder))]
    public class PassengerDto
    {
        [Required(AllowEmptyStrings = false)]
        [OnlyLetters]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [OnlyLetters]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false)]
        [OnlyLetters]
        public string Patronymic { get; set; }

        [Required]
        [OnlyNumbers]
        public string DocType { get; set; }

        [Required]
        [OnlyNumbers]
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
        [OnlyNumbers]
        [StringLength(13, MinimumLength = 13)]
        public string TicketNumber { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "TicketType validation error")]
        public int TicketType { get; set; }
    }
}