using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1ComponentDasha
{
    public partial class ChastotaDiapComponent : UserControl
    {
        List<int> date = new List<int>();
        public ChastotaDiapComponent()
        {
            InitializeComponent();
            numericUpDown.Maximum = DateTime.Now.Year;
            numericUpDown.Minimum = 2000;
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumerationName(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                date.Add(Convert.ToInt32(list[i].Split('/')[2]));
            }
            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < date.Count; i++)
            {
                if (date[i] == numericUpDown.Value)
                {
                    count++;
                }
            }
            textBox.Text = count.ToString();
        }
    }
}
