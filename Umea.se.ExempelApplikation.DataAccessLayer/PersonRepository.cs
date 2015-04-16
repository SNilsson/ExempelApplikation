using System.Collections.Generic;
using System.Linq;
using Umea.se.ExempelApplikation.DataAccessLayer.Contracts;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.DataAccessLayer
{
    public class PersonRepository : IPersonRepository
    {
        public Person GetPersonById(int personId)
        {
            Person person;
            using (var context = new Entities())
            {
                person = context.Person.Include("Enrollment").Include("Enrollment.Course").Include("Course").Include("Home")
                    .SingleOrDefault(a => a.ID.Equals(personId));

            }
            return person;
        }

        public List<Person> GetPersonsByMany(string firstName, string discriminator, List<Course> courses)
        {
            List<Person> persons;

            using (var context = new Entities())
            {
                IQueryable<Person> query = context.Person.Include("Enrollment").Include("Enrollment.Course");

                if (!string.IsNullOrEmpty(firstName))
                    query = query.Where(f => f.FirstName.Contains(firstName));
                if (!string.IsNullOrEmpty(discriminator))
                    query = query.Where(f => f.Discriminator.Equals(discriminator));
                if (courses != null && courses.Count > 0)
                    query = query.Where(f => f.Course.Intersect(courses).Any());

                persons = query.ToList();
            }
            return persons;
        }

 
    }
}
