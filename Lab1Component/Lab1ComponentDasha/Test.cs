using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ComponentDasha
{
    public class Test
    {
        public static List<string> list = new List<string>() {
            "10/01/2008",
            "07/08/2018",
            "05/05/2019",
            "30/07/2018",
            "25/06/2010",
            "17/10/2005",
            "15/12/2018",
            "20/06/2009",
            "07/03/2019",
            "28/08/2005"
        };
        public static List<string> listPost ;
        public static List<string> listType ;
        public string Title { get; set; }
        public string NamePost { get; set; }
        public string NameType { get; set; }

        public Test(string title, string namePost, string nameType) {
            Title = title;
            NamePost = namePost;
            NameType = nameType;
        }

        public  List<string> GetPost()
        {
            listPost = new List<string> { "Поставщик 1", "Поставщик 2", "Поставщик 3", "Поставщик 4" };
            return listPost;
        }

        public  List<string> GetType()
        {
            listType = new List<string> { "Тип 1", "Тип 2", "Тип 3" };
            return listType;
        }


    }
}
