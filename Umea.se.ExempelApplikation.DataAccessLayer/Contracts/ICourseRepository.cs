using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.DataAccessLayer.Contracts
{
    public interface ICourseRepository
    {
        List<Course> GetCourses();
    }
}
