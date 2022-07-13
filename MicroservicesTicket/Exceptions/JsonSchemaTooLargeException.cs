using System;

namespace MicroservicesTicket.Exceptions
{
    public class JsonSchemaTooLargeException : Exception
    {
        public JsonSchemaTooLargeException(string message) : base(message)
        {
            //413
        }
    }
}