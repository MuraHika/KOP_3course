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

            List<Test> tests = new List<Test>();
            tests.Add(new Test("1", "Менеджер 1", "8-909-352-20-65"));
            tests.Add(new Test("2", "Менеджер 2", "8-917-624-58-90"));
            tests.Add(new Test("3", "Менеджер 3", "8-906-354-90-47"));
            tests.Add(new Test("4", "Менеджер 4", "8-917-596-25-78"));
            List<string> titles = new List<string> { "Наименование", "Менеджер", "Телефон" };
            List<string> fields = new List<string> {"Name", "ManagerFIO", "Telephone" };
            vivodTableComponent.LoadEnumerationName(tests, titles, fields);
        }

        private void buttonCreateD_Click(object sender, EventArgs e)
        {
            List<Test> tests = new List<Test>();
            tests.Add(new Test("Менеджер 1", 324));
            tests.Add(new Test("Менеджер 2", 16));
            tests.Add(new Test("Менеджер 3", 120));
            tests.Add(new Test("Менеджер 4", 49));
            List<string> fields = new List<string> { "ManagerFIO", "CountPost" };
            List<string> titles = new List<string> { "Количество поставщиков у каждого менеджера", "Менеджеры", "Количество поставщиков" };
            diagrammaExcelComponent.CreateDiagram("O:\\", tests, fields, titles);
        }
    }
}
