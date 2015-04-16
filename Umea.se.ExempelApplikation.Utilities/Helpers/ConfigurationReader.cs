using System.Web.Configuration;
using Umea.se.ExempelApplikation.Utilities.Helpers.Contracts;

namespace Umea.se.ExempelApplikation.Utilities.Helpers
{
    public class ConfigurationReader : IConfigurationReader
    {
        public string GetConfigSetting(string settingName)
        {
            return WebConfigurationManager.AppSettings[settingName];
        }
    }
}
