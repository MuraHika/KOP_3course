using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [DataContract]
    public class Postav
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string TypeOrg { get; set; }
        [DataMember]
        public DateTime? DateLastPost { get; set; }
    }
}
