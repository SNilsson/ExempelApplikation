
using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.DataAccessLayer.Contracts
{
    public interface IPersonRepository
    {
        Person GetPersonById(int personId);
        List<Person> GetPersonsByMany(string firstName, string discriminator, List<Course> courses);

    }
}
