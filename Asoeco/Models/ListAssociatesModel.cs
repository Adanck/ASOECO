using System.Runtime.Serialization;

namespace Asoeco.Models
{
    [DataContract]
    [Serializable]
    public class ListAssociatesModel
    {
        [DataMember]
        public List<AssociatesModel> listAssociates { get; set; } = new List<AssociatesModel> ();
    }
}
