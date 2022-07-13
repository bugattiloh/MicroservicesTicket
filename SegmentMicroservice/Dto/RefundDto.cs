using System;
using System.ComponentModel.DataAnnotations;

namespace SegmentMicroservice.Dto
{
    public class RefundDto
    {
        [Required]
        [RegularExpression("(sale|refund){1}", ErrorMessage = "OperationType error")]
        public string OperationType { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OperationTime { get; set; }

        [Required]
        public string OperationPlace { get; set; }

        [Required]
        [StringLength(13,MinimumLength = 13)]
        public string TicketNumber { get; set; }
    }
}