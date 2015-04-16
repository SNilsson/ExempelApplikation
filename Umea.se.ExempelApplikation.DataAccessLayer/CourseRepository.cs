
using System.Collections.Generic;
using System.Linq;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;

//Detta är en ändring
namespace Umea.se.ExempelApplikation.DataAccessLayer
{
    public class CourseRepository : ICourseRepository
    {
        public List<Course> GetCourses()
        {
            List<Course> courses;

            using (var context = new Entities())
            {
                courses = context.Course.ToList();
            }
            return courses;
        }

    }
}
