using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts
{
    public interface ICourseLogic
    {
        List<Course> GetCourses();

    }
}
