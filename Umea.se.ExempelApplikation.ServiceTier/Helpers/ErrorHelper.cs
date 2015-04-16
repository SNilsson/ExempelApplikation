using System;
using System.Globalization;
using System.ServiceModel;
using Umea.se.ExempelApplikation.Utilities.Exceptions;

namespace Umea.se.ExempelApplikation.ServiceTier.Helpers
{
    public static class ErrorHelper
    {
        public static FaultException<Error> LogAndWrapInFaultException(Exception ex)
        {
            var error = new Error(ex);

            if (!(ex is LogicValidationException))
            {
                var logId = Guid.NewGuid().ToString();
                //Här ska man logga med loggningsfunktion som man har
                error.LogId = logId;
            }

            return new FaultException<Error>(error, new FaultReason(error.Message), new FaultCode(((int)error.Code).ToString(CultureInfo.InvariantCulture)));
        }
    }
}