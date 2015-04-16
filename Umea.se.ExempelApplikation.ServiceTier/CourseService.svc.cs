using System;
using System.Collections.Generic;
using Umea.se.ExempelApplikation.BusinessLogicLayer;
using Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts;
using Umea.se.ExempelApplikation.DataAccessLayer;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ServiceTier.Contracts;
using Umea.se.ExempelApplikation.ServiceTier.Helpers;

namespace Umea.se.ExempelApplikation.ServiceTier
{
    public class CourseService : ICourseService
    {
        private readonly ICourseLogic _courseLogic;

        public CourseService()
        {
            _courseLogic = new CourseLogic(new CourseRepository());

        }

        public List<Course> GetCourses()
        {
            try
            {
                return _courseLogic.GetCourses();
            }
            catch (Exception ex)
            {
                throw ErrorHelper.LogAndWrapInFaultException(ex);
            }
        }

    }
}
