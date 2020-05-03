using System;

namespace YmagiWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException  
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
