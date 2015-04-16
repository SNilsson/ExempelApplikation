using System;
using System.Collections.Generic;
using Umea.se.ExempelApplikation.BusinessLogicLayer;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ExtDataAccessLayer;
using Umea.se.ExempelApplikation.ServiceTier.Contracts;
using Umea.se.ExempelApplikation.ServiceTier.Helpers;
using Umea.se.ExempelApplikation.Utilities.Helpers;

namespace Umea.se.ExempelApplikation.ServiceTier
{
    public class PersonService : IPersonService
    {
        private readonly IPersonLogic _personLogic;

        public PersonService()
        {
            _personLogic =  new PersonLogic(new PersonRepository(), new ExtpersonRepository(), new CacheHelper(), new ConfigurationReader());

        }

        public List<Person> GetPersonerByMany(string firstName = null, string discriminator = null, List<Course> courses = null)
        {
            try
            {
                return _personLogic.GetPersonerByMany(firstName, discriminator, courses);
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }

        public PersonInformation GetPersonInformationById(int personId)
        {
            try
            {
                return _personLogic.GetPersonInformationnById(personId);
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }
    }
}
