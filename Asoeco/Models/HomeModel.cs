using System.Runtime.Serialization;

namespace Asoeco.Models
{
    [DataContract]
    [Serializable]
    public class HomeModel
    {
        [DataMember]
        public string? HomeInformation { get; set; }
        [DataMember]
        public string? About { get; set; }
        [DataMember]
        public string? Mision { get; set; }
        [DataMember]
        public string? Vision { get; set; }
        [DataMember]
        public string? History { get; set; }
    }
}
