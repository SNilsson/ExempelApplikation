using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Umea.se.ExempelApplikation.GUI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;

            if (!(ex is HttpException)) // Ignorera "File not found"
            {
                if (!ex.Data.Contains("LogId")) // Felet har uppstått i webbapplikationen (Frontend) och behöver därför loggas
                {
                    var logId = Guid.NewGuid().ToString();
                    //Logga felet här med det loggverktyg som används, t ex Log.Error(logId, ex);

                    ex.Data.Add("LogId", logId);
                    ex.Data.Add("LogSource", "Frontend");
                }
                else // Felet har uppstått i service eller datalager (Backend) och har redan loggats
                {
                    ex.Data.Add("LogSource", "Backend");
                }
            }
        }
    }
}