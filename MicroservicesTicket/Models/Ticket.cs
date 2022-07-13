using System;
using System.Collections.Generic;

namespace MicroservicesTicket.Models
{
    public class Ticket
    {
        public string OperationType { get; set; }
        
        public DateTime OperationTime { get; set; }
        
        public string OperationPlace { get; set; }
        public virtual Passenger Passenger { get; set; }
        
        public virtual ICollection<Route> Routes { get; set; }
    }
}