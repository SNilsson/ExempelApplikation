//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umea.se.ExempelApplikation.DataObjectLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class Country
    {
        public Country()
        {
            this.Home = new HashSet<Home>();
        }
    
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string CountryText { get; set; }
    
        [DataMember]
        public virtual ICollection<Home> Home { get; set; }
    }
}
