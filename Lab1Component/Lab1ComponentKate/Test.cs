using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ComponentKate
{
    public class Test
    {
        public string Name { get; set; }
        public string ManagerFIO { get; set; }
        public int CountPost { get; set; }
        public string Telephone { get; set; }

        public Test(string name, string managerFIO, string telephone)
        {
            Name = name;
            ManagerFIO = managerFIO;
            Telephone = telephone;
        }

        public Test(string managerFIO, int countPost)
        {
            ManagerFIO = managerFIO;
            CountPost = countPost;
        }
    }
}