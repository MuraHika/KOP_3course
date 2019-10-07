using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XL = Microsoft.Office.Interop.Excel;

namespace Lab1ComponentKate
{
    public partial class DiagrammaExcelComponent : Component
    {
        public DiagrammaExcelComponent()
        {
            InitializeComponent();
        }

        public DiagrammaExcelComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram() {
            Test test = new Test("Количество поставщиков у каждого менеджера", "Менеджеры", "Количество поставщиков");
            List<string> listManagers = Test.GetManagers();
            List<int> listPosts = Test.GetPosts();

            XL.Application XL1 = new XL.Application(); // Объявляем объект
            XL1.Workbooks.Add(); // Добавляем рабочую книгу

            // Заполнить ячейки A2 (со 2 по 6)
            for (int i = 0; i < listManagers.Count; i++) {
                string str = "A" + (i + 1);
                XL1.ActiveSheet.Range[str].Value = listManagers[i];
            }

            for (int i = 0; i < listPosts.Count; i++)
            {
                string str = "B" + (i + 1);
                XL1.ActiveSheet.Range[str].Value = listPosts[i];
            }
            /*XL1.ActiveSheet.Range["A2"].Value = "Март";
            XL1.ActiveSheet.Range["A3"].Value = "Апрель";
            XL1.ActiveSheet.Range["A4"].Value = "Май";
            XL1.ActiveSheet.Range["A5"].Value = "Июнь";
            XL1.ActiveSheet.Range["A6"].Value = "Июль";

            // Заполнить ячейки B2 (со 2 по 6)
            XL1.ActiveSheet.Range["B2"].Value = 150000;
            XL1.ActiveSheet.Range["B3"].Value = 225000;
            XL1.ActiveSheet.Range["B4"].Value = 56700;
            XL1.ActiveSheet.Range["B5"].Value = 280345;
            XL1.ActiveSheet.Range["B6"].Value = 500000;*/

            // Добавить новую диаграмму
            XL1.Charts.Add();

            // Задаем тип графика - столбчатая диаграммма
            XL1.ActiveChart.ChartType = XL.XlChartType.xlColumnClustered;
            // Отключаем легенду и задаем имя диаграммы
            XL1.ActiveChart.HasLegend = false;
            XL1.ActiveChart.HasTitle = true;
            XL1.ActiveChart.ChartTitle.Characters.Text = test.NameDiag; //установка названия диаграммы

            // Задаем подписи по оси X
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = test.Postav;

            // Задаем подписи по оси Y
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = test.Manager;

            // Сохраняем график в растровом файле
            XL1.ActiveChart.Export("O://University//3 курс//КОП//myFile.jpg");
            XL1.Visible = true;
        }
    }
}
