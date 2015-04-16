using System.Web.Mvc;

namespace Umea.se.ExempelApplikation.GUI.Helpers.Contracts
{
    public interface IMessageHelper
    {
        void ShowAlert(TempDataDictionary tempData, string type, string title, string message = "");
        void ShowNotification(TempDataDictionary tempData, string type, string message, string title = "");
    }
}
