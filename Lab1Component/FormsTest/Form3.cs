using Lab1ComponentKate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            //Создается список объектов
            List<object> tests = new List<object>();
            tests.Add(new Test("1", "Менеджер 1", "8-909-352-20-65"));
            tests.Add(new Test("2", "Менеджер 2", "8-917-624-58-90"));
            tests.Add(new Test("3", "Менеджер 3", "8-906-354-90-47"));
            tests.Add(new Test("4", "Менеджер 4", "8-917-596-25-78"));
            //Создается список названий заголовков
            List<string> titles = new List<string> { "Наименование", "Менеджер", "Телефон" };
            //Название полей класса, которые необходимо вывести в таблицу (Названия такие же, как и у твоего класса)
            List<string> fields = new List<string> {"Name", "ManagerFIO", "Telephone" };
            //Вызов метода вывода в таблицу. 
            //1 аргумент - передается список объектов класса
            // 2 аргумент - передается список названий заголовков
            // 3 аргумент - передается список названий полей
            vivodTableComponent.LoadEnumerationName(tests, titles, fields);
        }

        private void buttonCreateD_Click(object sender, EventArgs e)
        {
            //Создается список объектов
            List<object> tests = new List<object>();
            tests.Add(new Test("Менеджер 1", 324));
            tests.Add(new Test("Менеджер 2", 16));
            tests.Add(new Test("Менеджер 3", 120));
            tests.Add(new Test("Менеджер 4", 49));
            //Название полей класса, которые необходимо вывести в диаграмму (Названия такие же, как и у твоего класса)
            List<string> fields = new List<string> { "ManagerFIO", "CountPost" };
            //Создается список названий заголовков
            List<string> titles = new List<string> { "Количество поставщиков у каждого менеджера", "Менеджеры", "Количество поставщиков" };
            //Вызов метода вывода в таблицу. 
            // 1 аргумент - передается путь, в который сохраняется диаграмма
            // 2 аргумент - передается список объектов класса
            // 3 аргумент - передается список названий полей
            // 4 аргумент - передается список названий заголовков
            diagrammaExcelComponent.CreateDiagram("O:\\", tests, fields, titles);
        }
    }
}
