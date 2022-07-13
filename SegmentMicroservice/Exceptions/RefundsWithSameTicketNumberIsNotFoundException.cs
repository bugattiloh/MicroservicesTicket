﻿using System;

namespace MicroservicesTicket.Exceptions
{
    public class RefundsWithSameTicketNumberIsNotFoundException : Exception
    {
        public RefundsWithSameTicketNumberIsNotFoundException(string message) : base(message)
        {
            //409
        }
    }
}