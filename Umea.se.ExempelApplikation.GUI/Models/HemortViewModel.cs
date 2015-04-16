using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.GUI.Models
{
    public class HemortViewModel
    {
        public int CountryVal { get; set; }
        public List<Home> HemortList { get; set; }
        public List<Country> CountryList { get; set; }
    }
}