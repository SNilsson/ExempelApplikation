using System;
using System.Security;
using System.ServiceModel;

using Umea.se.ExempelApplikation.Utilities.Exceptions;

namespace Umea.se.ExempelApplikation.ServiceWrapper.Helpers
{
    public static class ErrorHelper
    {
        public static Exception UnwrapFaultException(FaultException<Error> fex)
        {
            var error = fex.Detail;
            var ex = new Exception(error.Message);

            switch (error.Code)
            {
                case ErrorCodes.LogicValidationException:
                    ex = new LogicValidationException(error.Message);
                    break;
                case ErrorCodes.SecurityException:
                    ex = new SecurityException(error.Message);
                    break;
                default:
                    ex.Data.Add("Type", "Exception");
                    break;
            }

            // Används på felsidan (Error.cshtml) för att visa LogId för användaren (lättare att felsöka...)            
            if (!string.IsNullOrWhiteSpace(error.LogId))
                ex.Data.Add("LogId", error.LogId);

            return ex;
        }
    }
}
