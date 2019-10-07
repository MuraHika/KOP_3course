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
        public int year_post = 0;
        public int month_post = 0;
        public int day_post = 0;
        public string date { get; set; }
        public ChastotaDiapComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumerationName(List<string> list)
        {
            dates = list;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textBoxYear.Text != "")
            {
                if (CorrectDate(textBoxYear.Text.ToString()) == true)
                {
                    //string date = textBoxYear.Text.ToString();
                    date = textBoxYear.Text.ToString();
                    year = Convert.ToInt32(date.Split('/')[2]);
                    month = Convert.ToInt32(date.Split('/')[1]);
                    day = Convert.ToInt32(date.Split('/')[0]);
                    int count = 0;
                    for (int i = 0; i < dates.Count; i++)
                    {
                        year_post = Convert.ToInt32(dates[i].Split('/')[2]);
                        month_post = Convert.ToInt32(dates[i].Split('/')[1]);
                        day_post = Convert.ToInt32(dates[i].Split('/')[0]);
                        if (year_post == year)
                        {
                            if (month_post == month)
                            {
                                if (day_post <= day)
                                {
                                    count++;
                                }
                            }
                            else if (month_post < month)
                            {
                                count++;
                            }
                        }
                        else if (year_post == year - 1)
                        {
                            if (month_post == month)
                            {
                                if (day_post >= day)
                                {
                                    count++;
                                }
                            }
                            else if (month_post > month)
                            {
                                count++;
                            }
                        }
                    }
                    textBox.Text = count.ToString();
                }
                else
                {
                    MessageBox.Show("Неверный формат введеной даты", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не введена дата. Пожалуйста, заполните поле даты", "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
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
