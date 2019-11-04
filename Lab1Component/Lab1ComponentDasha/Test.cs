using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ComponentDasha
{
    public class Test
    {
        public string Post { get; set; }
        public string Type { get; set; }
        
        public Test(string post, string type)
        {
            Post = post;
            Type = type;
        }
    }
}
