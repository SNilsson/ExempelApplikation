using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.Utilities.Exceptions;

namespace Umea.se.ExempelApplikation.ServiceTier.Contracts
{
    [ServiceContract]
    public interface IHemortService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        List<Country> GetCountries();

        [OperationContract]
        [FaultContract(typeof(Error))]
        List<Home> GetHomes();

        [OperationContract]
        [FaultContract(typeof(Error))]
        List<Home> GetHomesByCountryId(int countryId);
    }
}
