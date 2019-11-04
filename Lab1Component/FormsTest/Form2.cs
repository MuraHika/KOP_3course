using Lab1ComponentDasha;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chastotaDiapComponent.LoadEnumerationName("01/01/2000", "04/11/2019");
        }

        private void buttonSavePDF_Click(object sender, EventArgs e)
        {
            List<Test> tests = new List<Test>();
            tests.Add(new Test("Поставщик 1", "Тип 1 "));
            tests.Add(new Test("Поставщик 2", "Тип 2 "));
            tests.Add(new Test("Поставщик 3", "Тип 1 "));
            tests.Add(new Test("Поставщик 4", "Тип 3 "));
            List<string> fields = new List<string> { "Post", "Type" };
            List<string> title = new List<string> { "Поставщики и типы их поставляемых изделий", "ФИО поставщиков", "Типы изделий" };
            requestPDFComponent.SavePDF("O://Postavsiki.pdf", tests, fields, title, "Столбец");
        }
    }
}
