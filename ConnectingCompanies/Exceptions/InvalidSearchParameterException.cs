using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingCompanies.Exceptions
{
    class InvalidSearchParameterException : Exception
    {
        public InvalidSearchParameterException() : base() { }
        public InvalidSearchParameterException(string message) : base(message) { }
        public InvalidSearchParameterException(string message, Exception inner) : base(message, inner) { }
    }
}
