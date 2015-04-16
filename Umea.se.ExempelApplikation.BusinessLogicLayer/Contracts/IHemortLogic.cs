using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts
{
    public interface IHemortLogic
    {
        List<Country> GetCountries();
        List<Home> GetHomes();
        List<Home> GetHomesByCountry(int countryId);
    }
}
