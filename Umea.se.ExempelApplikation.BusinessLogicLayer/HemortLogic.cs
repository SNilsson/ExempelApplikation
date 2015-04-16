using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer
{
    public class HemortLogic : IHemortLogic
    {
        private readonly IHemortRepository _homeRepository;

        public HemortLogic(IHemortRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public List<Country> GetCountries()
        {
            var countryList = _homeRepository.GetCountries();
            return countryList;
        }

        public List<Home> GetHomes()
        {
            var homeList = _homeRepository.GetHomes();
            return homeList;
        }

        public List<Home> GetHomesByCountry(int countryId)
        {
            var homeList = _homeRepository.GetHomesByCountry(countryId);
            return homeList;
        }
    }
}
