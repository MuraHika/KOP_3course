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
            //Проверка на вхождение в диапозон. 1 аргумент - минимальное значение, 2 - максимальное
            chastotaDiapComponent.LoadEnumerationName(1, 50);
        }

        private void buttonSavePDF_Click(object sender, EventArgs e)
        {
            //Создаем список из объектов класса
            List<object> tests = new List<object>();
            tests.Add(new Test("Поставщик 1", "Тип 1 "));
            tests.Add(new Test("Поставщик 2", "Тип 2 "));
            tests.Add(new Test("Поставщик 3", "Тип 1 "));
            tests.Add(new Test("Поставщик 4", "Тип 3 "));
            //Создаем список названий полей класса, которые необходимо вывести в отчет (Названия такие же, как прописаны в твоем классе)
            List<string> fields = new List<string> { "Post", "Type" };
            //Список названий заголовков
            List<string> title = new List<string> { "Поставщики и типы их поставляемых изделий", "ФИО поставщиков", "Типы изделий" };
            //Вызов метода создание отчета в формате pdf
            //1 аргумент - путь, в который сохраняется отчет
            //2 аргумент - передается список объектов класса
            //3 аргумент - передается список полей класса
            //4 аргумент - передается список названий заголоков
            //5 аргумент - указывается то, чем является шапка таблицы: столбцом или строкой. Указывается либо Столбец, либо Строка
            requestPDFComponent.SavePDF("O://Postavsiki.pdf", tests, fields, title, "Столбец");
        }
    }
}
