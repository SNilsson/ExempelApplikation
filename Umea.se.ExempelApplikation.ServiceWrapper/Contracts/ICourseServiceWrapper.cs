using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.ServiceWrapper.Contracts
{
    public interface ICourseServiceWrapper
    {
        List<Course> GetCourses();
    }
}
