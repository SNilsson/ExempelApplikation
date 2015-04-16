using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umea.se.ExempelApplikation.Utilities
{
    public class Constants
    {
        public class CacheKeys
        {
            public const string Person = "Person_{0}"; //Cachar Person {0} ska ersättas med personId
        }

        public class WebConfigKeys
        {
            public const string PersonCacheExpiration = "PersonCacheExpirationMinutes";
        }

        public class MessageTypes
        {
            public const string Notification = "notification";
            public const string Alert = "alert";
        }

        public class AlertTypes
        {
            public const string Success = "success";
            public const string Info = "info";
            public const string Warning = "warning";
            public const string Danger = "danger";
        }

        public class NotificationTypes
        {
            public const string Success = "success";
            public const string Info = "info";
            public const string Warning = "warning";
            public const string Error = "error";
        }
    }
}
