using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SetProject.Models.Exceptions
{
    class SetFieldException : Exception
    {
        public SetFieldException() : base() { }
        public SetFieldException(string message) : base(message) { }
    }
}
