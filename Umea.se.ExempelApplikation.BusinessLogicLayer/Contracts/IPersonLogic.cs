using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.BusinessLogicLayer.Contracts
{
    public interface IPersonLogic
    {
        PersonInformation GetPersonInformationnById(int personId);
        List<Person> GetPersonerByMany(string firstName = null, string discriminator = null, List<Course> courses = null);
    }
}
