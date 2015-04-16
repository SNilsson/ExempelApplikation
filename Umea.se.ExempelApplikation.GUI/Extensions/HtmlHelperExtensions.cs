using System.Linq;
using System.Web.Mvc;

namespace Umea.se.ExempelApplikation.GUI.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static string AppendNonExistingAttributeToUrl(this HtmlHelper helper, string url, string attrName, string attrValue)
        {
            if (!url.Contains(attrName))
                return url + (url.Contains("?") ? "&" : "?") + attrName + "=" + attrValue;

            return url;
        }

        public static string GetReturnUrlAction(this HtmlHelper helper, string returnUrl)
        {
            // Catch exception for location.href to prevent error when onbeforeunload is active for a page
            return string.IsNullOrWhiteSpace(returnUrl) ? "window.history.back()" : "try{ location.href='" + returnUrl + "'; } catch (exc) {} return false;";
        }

    }
}