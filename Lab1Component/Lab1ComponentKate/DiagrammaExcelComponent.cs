using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using XL = Microsoft.Office.Interop.Excel;

namespace Lab1ComponentKate
{
    public partial class DiagrammaExcelComponent : Component
    {

        XL.Workbook xlWorkBook;
        XL.Worksheet xlWorkSheet;
        object misValue = System.Reflection.Missing.Value;

        public DiagrammaExcelComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //Создание диаграммы: путь, список объектво класса, список полей, которые необходимо вывести, список заголовков
        public void CreateDiagram(string path, List<object> tests, List<string> fields, List<string> title)
        {
            try
            {
                //Создание списка названий столбцов гистограммы
                List<string> listManagers = new List<string>();
                //Создание списка значений
                List<int> listPosts = new List<int>();
                //Добавление в списки
                foreach (var item in tests)
                {
                    Type t = item.GetType();
                    string[] field = new string[t.GetFields().Length];
                    foreach (var _field in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (fields.Contains(new Regex(@"<(.*?)>").Match(_field.Name).Groups[1].Value) || fields.Contains(_field.Name))
                        {
                            var str = _field.GetValue(item);
                            int num;
                            bool isNum = int.TryParse(str.ToString(), out num);
                            if (isNum)
                                listPosts.Add(Convert.ToInt32(str));
                            else
                                listManagers.Add(str.ToString());
                        }
                    }
                }

                XL.Application XL1 = new XL.Application(); // Объявляем объект
                xlWorkBook = XL1.Workbooks.Add(1);
                xlWorkSheet = (XL.Worksheet)xlWorkBook.Sheets[1];
                //Заполнение диаграммы
                for (int i = 0; i < listManagers.Count; i++)
                {
                    string str = "A" + (i + 1);
                    XL1.ActiveSheet.Range[str].Value = listManagers[i];
                }

                for (int i = 0; i < listPosts.Count; i++)
                {
                    string str = "B" + (i + 1);
                    XL1.ActiveSheet.Range[str].Value = listPosts[i];
                }
                // Добавить новую диаграмму
                XL1.Charts.Add();

                // Задаем тип графика - столбчатая диаграммма
                XL1.ActiveChart.ChartType = XL.XlChartType.xlColumnClustered;
                // Отключаем легенду и задаем имя диаграммы
                XL1.ActiveChart.HasLegend = false;
                XL1.ActiveChart.HasTitle = true;
                XL1.ActiveChart.ChartTitle.Characters.Text = title[0]; //установка названия диаграммы

                // Задаем подписи по оси X
                XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
                XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = title[2];

                // Задаем подписи по оси Y
                XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
                XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = title[1];

                xlWorkBook.SaveAs(path + "example.xls", XL.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XL.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                XL1.Quit();

                MessageBox.Show("Сохранение диаграммы прошло успешно!", "Отлично", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
