using System.Runtime.Serialization;

namespace Umea.se.ExempelApplikation.DataObjectLibrary
{
    [DataContract(IsReference = true)]
    public class PersonInformation : Person
    {
        [DataMember]
        public string Extuppgift{ get; set; }
    }
}
