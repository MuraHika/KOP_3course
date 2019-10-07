using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1ComponentKate
{
    public partial class VivodTableComponent : UserControl
    {
        public VivodTableComponent()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumerationName(List<string> list1, List<string> list2)
        {
            List<string> listName = list1;
            List<string> listNumber = list2;
            for (int i = 0; i < 2; i++)
                dataGridView.Columns[i].HeaderText = Convert.ToString(i + 1);
            for (int i = 0; i < listName.Count; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView.Rows.Add(listName[i], listNumber[i], i);
            }
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumerationNumber(Type type)
        {
            List<string> list = new List<string>();
            foreach (var elem in Enum.GetValues(type))
            {
                list.Add(elem.ToString());
            }
            for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView.Rows.Add("Пример 1, Товар " + i, list[i], i);
            }
            
        }
    }
}
