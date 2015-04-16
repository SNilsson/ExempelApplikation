using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.ServiceWrapper.Contracts
{
    public interface IHemortServiceWrapper
    {
        List<Country> GetCountries();
        List<Home> GetHomes();
        List<Home> GetHomesByCountryId(int countryId);

    }
}
