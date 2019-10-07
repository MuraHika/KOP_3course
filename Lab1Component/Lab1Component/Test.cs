using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Component
{
    [DataContract]
    public class Test
    {
        public enum TypeOrg
        {
            ООО,
            ОАО,
            ИП,
            АО,
            НПО
        }

        public enum NameOrg
        {
            УАЗ,
            МАРС,
            Авиастар
        }

        [DataMember]
        public string _nameOrg{ get;set;}

        [DataMember]
        public string _typeOrg{get; set;}

        public DateTime? Date { get; set; }

        public Test(string nameOrg, string typeOrg)
        {
            _nameOrg = nameOrg;
            _typeOrg = typeOrg;
        }

    }
}
