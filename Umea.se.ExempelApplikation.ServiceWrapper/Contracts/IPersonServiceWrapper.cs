using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.ServiceWrapper.Contracts
{
    public interface IPersonServiceWrapper
    {
        List<Person> GetPersonerByMany(string firstName, string discriminator, List<Course> courses);
        PersonInformation GetPersonInformationById(int personId);
 }
}
