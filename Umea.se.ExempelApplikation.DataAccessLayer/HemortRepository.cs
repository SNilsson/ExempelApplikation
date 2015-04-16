using System.Collections.Generic;
using System.Linq;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.DataAccessLayer
{
    public class HemortRepository : IHemortRepository
    {
        public List<Country> GetCountries()
        {
            List<Country> countries;

            using (var context = new Entities())
            {
                countries = context.Country.ToList();
            }
            return countries;
        }

        public List<Home> GetHomes()
        {
            List<Home> homes;

            using (var context = new Entities())
            {
                homes = context.Home.ToList();
            }
            return homes;
        }

        public List<Home> GetHomesByCountry(int countryId)
        {
            List<Home> homes;

            using (var context = new Entities())
            {
                homes = context.Home.Where(h => h.CountryId == countryId).ToList();
            }
            return homes;
        }
    }
}
