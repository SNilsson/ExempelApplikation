using System.Collections.Generic;
using System.ServiceModel;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.Utilities.Exceptions;

namespace Umea.se.ExempelApplikation.ServiceTier.Contracts
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        [FaultContract(typeof (Error))]
        List<Person> GetPersonerByMany(string firstName = null, string discriminator = null, List<Course> courses = null);

        [OperationContract]
        [FaultContract(typeof(Error))]
        PersonInformation GetPersonInformationById(int personId);
    }
}
