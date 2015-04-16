using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umea.se.ExempelApplikation.Utilities.Exceptions
{
    public class LogicValidationException : Exception
    {
        public LogicValidationException(string message)
            : base(message)
        {
        }

    }
}
