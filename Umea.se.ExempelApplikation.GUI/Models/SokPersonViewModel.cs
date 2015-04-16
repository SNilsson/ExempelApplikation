using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.Utilities;
using Umea.se.ExempelApplikation.Utilities.Resources;

namespace Umea.se.ExempelApplikation.GUI.Models
{
    public class SokPersonViewModel
    {
        public string ReturnUrl { get; set; }


        [Display(ResourceType = typeof(Strings), Name = "Fornamn")]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(Strings), Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(ResourceType = typeof(Strings), Name = "Diskriminator")]
        public Enums.Discriminator? Discriminator { get; set; }


        public List<Person> PersonList { get; set; }

        public bool HideResults { get; set; }
    }

}