using System;
using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ServiceWrapper.Contracts;
using Umea.se.ExempelApplikation.ServiceWrapper.CourseServiceTier;

namespace Umea.se.ExempelApplikation.ServiceWrapper
{
    public class CourseServiceWrapper : ICourseServiceWrapper
    {
        private readonly CourseServiceClient _courseServiceClient;

        public CourseServiceWrapper()
        {
            _courseServiceClient = new CourseServiceClient();
        }

        public List<Course> GetCourses()
        {
            return _courseServiceClient.GetCourses();
        }

    }
}
