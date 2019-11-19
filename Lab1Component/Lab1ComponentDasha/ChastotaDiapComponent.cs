using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab1ComponentDasha
{
    public partial class ChastotaDiapComponent : UserControl
    {
        public int number { get; set; }
        public int NumberFrom { get; set; }
        public int NumberTo { get; set; }

        public ChastotaDiapComponent()
        {
            InitializeComponent();
        }

        public void LoadEnumerationName(int numberFrom, int numberTo)
        {
            NumberFrom = numberFrom;
            NumberTo = numberTo;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //Проверка на то, введено число или же иной символ
            try
            {
                number = Convert.ToInt32(textBoxYear.Text);
                //Вызов метода проверки
                if (CheckNumber(number) == true)
                {
                    textBoxYear.BackColor = Color.Green;
                }
                else
                {
                    number = NumberFrom;
                    textBoxYear.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                number = NumberFrom;
                textBoxYear.BackColor = Color.Red;
            }
        }

        //Проверка на входимость числа в данный диапозон
        public bool CheckNumber(int number)
        {
            if (NumberFrom < NumberTo)
            {
                if (number <= NumberTo && number >= NumberFrom)
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Минимальное число больше или равно максимальному", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}

