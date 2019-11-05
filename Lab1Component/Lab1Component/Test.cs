using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Component
{
    [Serializable]
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
        
        public string _nameOrg{ get;set;}
        
        public string _typeOrg{get; set;}

        public Test(string nameOrg, string typeOrg)
        {
            _nameOrg = nameOrg;
            _typeOrg = typeOrg;
        }
    }
}
