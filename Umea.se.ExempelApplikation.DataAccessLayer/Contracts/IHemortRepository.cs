using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.DataAccessLayer.Contracts
{
    public interface IHemortRepository
    {
        List<Country> GetCountries();
        List<Home> GetHomes();
        List<Home> GetHomesByCountry(int countryId);
    }
}
