using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Directory.Models
{
    [DataContract]
    public class Rootobject
    {
        [DataMember(EmitDefaultValue = false)]
        public int id { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [MaxLength(50)]
        [Required]
        public string firstName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        [MaxLength(50)]
        [Required]
        public string lastName { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int? age { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public Address address { get; set; }
        public Phonenumber[] phoneNumbers { get; set; }
    }

    [DataContract]
    public class Address
    {
        [DataMember(EmitDefaultValue = false)]
        public string streetAddress { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string city { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string state { get; set;}
        [DataMember(EmitDefaultValue = false)]
        public string postalCode { get; set; }
    }

    [DataContract]
    public class Phonenumber
    {
        [DataMember(EmitDefaultValue = false)]
        public string type { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string number { get; set; }
    }

}