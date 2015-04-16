using System;
using System.Collections.Generic;
using System.Web.Caching;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ExtDataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.Utilities;
using Umea.se.ExempelApplikation.Utilities.Helpers.Contracts;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer
{
    public class PersonLogic : IPersonLogic
    {
        private readonly ICacheHelper _cacheHelper;
        private readonly IPersonRepository _personRepository;
        private readonly IConfigurationReader _configReader;
        private readonly IExtpersonRepository _extpersonRepository;

        public PersonLogic(IPersonRepository personRepository, IExtpersonRepository extpersonRepository, ICacheHelper cacheHelper, IConfigurationReader configurationReader)
        {
            _personRepository = personRepository;
            _cacheHelper = cacheHelper;
            _configReader = configurationReader;
            _extpersonRepository = extpersonRepository;
        }

        public PersonInformation GetPersonInformationnById(int personId)
        {
            var cachedPerson = (PersonInformation)_cacheHelper.GetObject(string.Format(Constants.CacheKeys.Person, personId));
            if (cachedPerson != null)
                return cachedPerson;

            var person = _personRepository.GetPersonById(personId);
            var personinformation = _extpersonRepository.GetKompletterandePersonInfo(person);

            var expiration = Int32.Parse(_configReader.GetConfigSetting(Constants.WebConfigKeys.PersonCacheExpiration));
            _cacheHelper.SetObject(string.Format(Constants.CacheKeys.Person, personId), personinformation, null,
                DateTime.Now.Add(new TimeSpan(0, expiration, 0)), Cache.NoSlidingExpiration);

            return personinformation;
        }

        public List<Person> GetPersonerByMany(string firstName = null, string discriminator = null, List<Course> courses = null)
        {
            var personList = _personRepository.GetPersonsByMany(firstName, discriminator, courses);
            return personList;
        }
    }
}
