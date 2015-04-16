using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umea.se.ExempelApplikation.Utilities.Resources;

namespace Umea.se.ExempelApplikation.DataObjectLibrary.MetaDataObjects
{
    public class PersonMetaData
    {
        [Required]
        [Display(ResourceType = typeof(Strings), Name = "Fornamn")]
        public string FirstName;

        [Required]
        [Display(ResourceType = typeof(Strings), Name = "Efternamn")]
        public string LastName;

        [Required]
        [Display(ResourceType = typeof(Strings), Name = "AnstalldDatum")]
        public string HireDate;

        [Display(ResourceType = typeof(Strings), Name = "Course")]
        public List<Course>Course ;
    }
}
