using System.Collections.Generic;
using System.Linq;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.ExtDataAccessLayer.Contracts;

namespace Umea.se.ExempelApplikation.ExtDataAccessLayer
{
    public class ExtpersonRepository : IExtpersonRepository
    {
        public PersonInformation GetKompletterandePersonInfo(Person person)
        {
            var personInformation = new PersonInformation();
            //Hämtar fler personuppgifter från någon extern källa och skapar PersonInformation som innehåller uppgifter dels
            //från Person och dels från den externa källan. Här har vi bara hårdkodat en kompletterande uppgift.
            return SkapaPersonInformation(person);
        }

        private PersonInformation SkapaPersonInformation(Person person)
        {
            return new PersonInformation
            {
                ID = person.ID,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Discriminator = person.Discriminator,
                Course = person.Enrollment != null && person.Enrollment.Count != 0 ? person.Enrollment.Select(e => e.Course).ToList() : person.Course.ToList(),
                Enrollment = person.Enrollment,
                HireDate = person.HireDate,
                HomeId = person.ID,
                Extuppgift = "Extuppgift"
            };
        }
    }
}
