using System.Web.Mvc;
using Umea.se.ExempelApplikation.GUI.Helpers.Contracts;
using Umea.se.ExempelApplikation.Utilities;

namespace Umea.se.ExempelApplikation.GUI.Helpers
{
    public class MessageHelper : IMessageHelper
    {
        public void ShowAlert(TempDataDictionary tempData, string type, string title, string message = "")
        {
            tempData[Constants.MessageTypes.Alert] = message != ""
                ? string.Format("{0}#{1}#{2}", type, title, message)
                : string.Format("{0}#{1}", type, title);
        }

        public void ShowNotification(TempDataDictionary tempData, string type, string message, string title = "")
        {
            tempData[Constants.MessageTypes.Notification] = title != ""
                ? string.Format("{0}#{1}#{2}", type, message, title)
                : string.Format("{0}#{1}", type, message);
        }
    }
}