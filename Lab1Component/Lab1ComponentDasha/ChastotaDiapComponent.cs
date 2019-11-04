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
        List<string> dates = new List<string>();
        public int year = 0;
        public int month = 0;
        public int day = 0;
        public string date { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ChastotaDiapComponent()
        {
            InitializeComponent();
        }

        public void LoadEnumerationName(string dateFrom, string dateTo)
        {
            DateFrom = DateTime.Parse(dateFrom);
            DateTo = DateTime.Parse(dateTo);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textBoxYear.Text != "")
            {
                if (CorrectDate(textBoxYear.Text.ToString()) == true)
                {
                    date = textBoxYear.Text.ToString();
                    if (CheckDate(date) == true)
                    {
                        MessageBox.Show("Дата входит в диапазон", "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Дата не входит в диапазон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    date = DateFrom.ToString();
                    MessageBox.Show("Неверный формат введеной даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                date = DateFrom.ToString();
                MessageBox.Show("Не введена дата. Пожалуйста, заполните поле даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckDate(string date)
        {
            year = Convert.ToInt32(date.Split('/')[2]);
            month = Convert.ToInt32(date.Split('/')[1]);
            day = Convert.ToInt32(date.Split('/')[0]);
            if (DateFrom.Year <= DateTo.Year && DateFrom.Month <= DateTo.Month && DateFrom.Day < DateTo.Day)
            {
                if (year < DateTo.Year && year > DateFrom.Year)
                {
                    return true;
                }
                else if (year == DateFrom.Year)
                {
                    if (month > DateFrom.Month)
                    {
                        return true;
                    }
                    else if (month == DateFrom.Month)
                    {
                        if (day >= DateFrom.Day)
                        {
                            return true;
                        }
                    }
                }
                else if (year == DateTo.Year)
                {
                    if (month < DateTo.Month)
                    {
                        return true;
                    }
                    else if (month == DateTo.Month)
                    {
                        if (day <= DateTo.Day)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Дата начала больше даты конца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool CorrectDate(string date)
        {
            Regex reg = new Regex(@"^(?:(?:31(/)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(/)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(/)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(/)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
            MatchCollection matches = reg.Matches(date);
            if (matches.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
