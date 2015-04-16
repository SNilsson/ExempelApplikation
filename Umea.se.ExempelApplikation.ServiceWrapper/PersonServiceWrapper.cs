using System.Collections.Generic;
using System.ServiceModel;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ServiceWrapper.Contracts;
using Umea.se.ExempelApplikation.ServiceWrapper.Helpers;
using Umea.se.ExempelApplikation.ServiceWrapper.PersonServiceTier;

namespace Umea.se.ExempelApplikation.ServiceWrapper
{
    public class PersonServiceWrapper : IPersonServiceWrapper
    {
        private readonly PersonServiceClient _personServiceClient;

        public PersonServiceWrapper()
        {
            _personServiceClient = new PersonServiceClient();
        }

        public List<Person> GetPersonerByMany(string firstName, string discriminator, List<Course> courses)
        {
            return _personServiceClient.GetPersonerByMany(firstName, discriminator, courses);
        }

        public PersonInformation GetPersonInformationById(int personId)
        {
            try { 
            return _personServiceClient.GetPersonInformationById(personId);
            }
            catch (FaultException<Umea.se.ExempelApplikation.Utilities.Exceptions.Error> fex)
            {
                throw ErrorHelper.UnwrapFaultException(fex);
            }
        }
    }
}
