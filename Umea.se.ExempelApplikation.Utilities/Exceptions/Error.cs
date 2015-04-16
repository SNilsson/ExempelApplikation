using System;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Security;


namespace Umea.se.ExempelApplikation.Utilities.Exceptions
{
    /// <summary>
    /// Generiskt FaultContract för fel som ska kastas från Service Facades
    /// </summary>
    [DataContract]
    public class Error
    {
        public Error()
        {
            Message = "Service encountered an error";
            Code = ErrorCodes.Exception;
        }

        public Error(string message)
        {
            Message = message;
            Code = ErrorCodes.Exception;
        }

        public Error(Exception e)
        {
            Message = e.Message;

            if (e is LogicValidationException)
            {
                Code = ErrorCodes.LogicValidationException;
            }
            else if (e is SecurityException)
            {
                Code = ErrorCodes.SecurityException;
            }
            else if (e is SqlException)
            {
                Code = ErrorCodes.SqlException;
            }
            else
            {
                Code = ErrorCodes.Exception;
            }
        }

        [DataMember]
        public ErrorCodes Code { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string LogId { get; set; }
    }
}
