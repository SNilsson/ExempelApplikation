using System.Collections.Generic;
using System.ServiceModel;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.Utilities.Exceptions;

namespace Umea.se.ExempelApplikation.ServiceTier.Contracts
{
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        List<Course> GetCourses();

    }
}
