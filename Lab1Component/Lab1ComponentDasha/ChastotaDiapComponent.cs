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

        [Category("Спецификация"), Description("Значение введенного элемента")]
        public int SelectedNumber
        {
            get { return number; }
            set
            {
                number = value;
            }
        }

        private event EventHandler _textBoxSelectedElementChangeName;

        [Category("Спецификация"), Description("Событие ввода элемента")]
        public event EventHandler TextBoxSelectedElementChange
        {
            add { _textBoxSelectedElementChangeName += value; }
            remove { _textBoxSelectedElementChangeName -= value; }
        }

        public ChastotaDiapComponent()
        {
            InitializeComponent();
            textBoxYear.TextChanged += (sender, e) =>
            {
                _textBoxSelectedElementChangeName?.Invoke(sender, e);
            };
        }

        public void LoadEnumerationName(int numberFrom, int numberTo)
        {
            NumberFrom = numberFrom;
            NumberTo = numberTo;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textBoxYear.TextLength != 0)
            {
                //Проверка на то, введено число или же иной символ
                try
                {
                    SelectedNumber = Convert.ToInt32(textBoxYear.Text);
                    //Вызов метода проверки
                    if (CheckNumber(SelectedNumber) == true)
                    {
                        textBoxYear.BackColor = Color.Green;
                    }
                    else
                    {
                        SelectedNumber = NumberFrom;
                        textBoxYear.BackColor = Color.Red;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введено не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SelectedNumber = NumberFrom;
                    textBoxYear.BackColor = Color.Red;
                }
            }
            else {
                MessageBox.Show("Строка пустая, пожалуйста, заполните ее!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectedNumber = NumberFrom;
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

