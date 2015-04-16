using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Umea.se.ExempelApplikation.BusinessLogicLayer;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ServiceTier.Contracts;
using Umea.se.ExempelApplikation.ServiceTier.Helpers;

namespace Umea.se.ExempelApplikation.ServiceTier
{
    public class HemortService : IHemortService
    {
        private readonly IHemortLogic _hemortLogic;

        public HemortService()
        {
            _hemortLogic = new HemortLogic(new HemortRepository());
        }

        public List<Country> GetCountries()
        {
            try
            {
                return _hemortLogic.GetCountries();
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }

        public List<Home> GetHomes()
        {
            try
            {
                return _hemortLogic.GetHomes();
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }

        public List<Home> GetHomesByCountryId(int countryId)
        {
            try
            {
                return _hemortLogic.GetHomesByCountry(countryId);
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }
    }
}
