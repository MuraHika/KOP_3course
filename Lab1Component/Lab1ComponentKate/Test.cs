using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ComponentKate
{
    public class Test
    {
        public static List<string> listName = new List<string>() { "Название 1", "Название 2", "Название 3" };
        public static List<string> listNumber = new List<string>() { "8-909-352-20-65", "8-917-624-58-90", "8-906-354-90-47" };
        public static List<string> listManager;
        public static List<int> listPost;
        public string NameDiag { get; set; }
        public string Manager { get; set; }
        public string Postav { get; set; }

        public Test(string nameDiag, string manager, string postav)
        {
            NameDiag = nameDiag;
            Manager = manager;
            Postav = postav;
        }

        public static List<string> GetManagers()
        {
            listManager = new List<string>() { "Менеджер 1", "Менеджер 2", "Менеджер 3" };
            return listManager;
        }

        public static List<int> GetPosts()
        {
            listPost = new List<int>() { 26, 59, 178 };
            return listPost;
        }
    }
}