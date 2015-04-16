using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace Umea.se.ExempelApplikation.GUI.Helpers
{
   public static class GlobalizationHelper
    {                       
        public static IHtmlString MetaAcceptLanguage<T>(this HtmlHelper<T> htmlHelper)
        {
            var acceptLanguage = HttpUtility.HtmlAttributeEncode(CultureInfo.CurrentUICulture.ToString());
            return new HtmlString(string.Format("<meta name=\"accept-language\" content=\"{0}\" />", acceptLanguage));
        }
        
        /// <summary>
        /// URL for the specific Globalize culture
        /// </summary>
        public static string GlobalizeCulture
        {
            get
            {
                const string filePattern = "~/Scripts/globalize/cultures/globalize.culture.{0}.js";
                return string.Format(filePattern, CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            }
        }

        /// <summary>
        /// URL for the specific DatePicker culture
        /// </summary>
        public static string GlobalizeDatePicker
        {
            get
            {
                const string filePattern = "~/Scripts/bootstrap-datepicker/locales/bootstrap-datepicker-{0}.js";
                return string.Format(filePattern, CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
            }
        }
    }
}
