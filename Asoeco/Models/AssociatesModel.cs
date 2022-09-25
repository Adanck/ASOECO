using System.Runtime.Serialization;

namespace Asoeco.Models
{
    [DataContract]
    [Serializable]
    public class AssociatesModel
    {
        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? WebPage { get; set; }

        [DataMember]
        public string? Facebook { get; set; }

        [DataMember]
        public string? Instagram { get; set; }

        [DataMember]
        public string? PhoneNumber { get; set; }

        [DataMember]
        public string? PhoneNumber2 { get; set; }

        [DataMember]
        public string? Address { get; set; }

        [DataMember]
        public string? Address2 { get; set; }

        [DataMember]
        public byte[]?  Avatar { get; set; }
    }
}
