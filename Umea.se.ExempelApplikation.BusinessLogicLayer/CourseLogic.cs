using System;
using System.Collections.Generic;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer
{
    public class CourseLogic : ICourseLogic
    {
        private readonly ICourseRepository _courseRepository;

        public CourseLogic(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public List<Course> GetCourses()
        {
            var courseList = _courseRepository.GetCourses();
            return courseList;
        }
    }
}
