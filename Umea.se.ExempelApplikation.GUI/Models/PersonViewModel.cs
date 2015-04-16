using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umea.se.ExempelApplikation.DataObjectLibrary;
using Umea.se.ExempelApplikation.Utilities;
using Umea.se.ExempelApplikation.Utilities.Resources;

namespace Umea.se.ExempelApplikation.GUI.Models
{
    public class PersonViewModel : PersonInformation
    {
        public bool EditMode { get; set; }
        public PersonInformation PersonInformation { get; set; }
        public string ReturnUrl { get; set; }

        [Required]
        [Display(ResourceType = typeof(Strings), Name = "Diskriminator")]
        public Enums.Discriminator DiscriminatorVal { get; set; }

        public bool IsNyAnvandare { get; set; }

        public int[] CourseVal { get; set; }
        public string CourseDefaultVal { get; set; }

        [Display(ResourceType = typeof(Strings), Name = "Home")]
        public List<Home> Homes { get; set; }
        [Display(ResourceType = typeof(Strings), Name = "Course")]
        public List<Course> Courses { get; set; } 


    }
}