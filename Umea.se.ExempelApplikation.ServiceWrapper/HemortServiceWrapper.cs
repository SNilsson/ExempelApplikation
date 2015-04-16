using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ServiceWrapper.Contracts;
using Umea.se.ExempelApplikation.ServiceWrapper.HemortServiceTier;

namespace Umea.se.ExempelApplikation.ServiceWrapper
{
    public class HemortServiceWrapper : IHemortServiceWrapper
    {
        private readonly HemortServiceClient _hemortServiceClient;

        public HemortServiceWrapper()
        {
            _hemortServiceClient = new HemortServiceClient();
        }

        public List<Country> GetCountries()
        {
            return _hemortServiceClient.GetCountries();
        }

        public List<Home> GetHomes()
        {
            return _hemortServiceClient.GetHomes();
        }

        public List<Home> GetHomesByCountryId(int countryId)
        {
            return _hemortServiceClient.GetHomesByCountryId(countryId);
        }
    }
}
