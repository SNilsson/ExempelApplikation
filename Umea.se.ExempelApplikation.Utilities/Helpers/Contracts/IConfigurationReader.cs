namespace Umea.se.ExempelApplikation.Utilities.Helpers.Contracts
{
    public interface IConfigurationReader
    {
        string GetConfigSetting(string settingName);
    }
}
