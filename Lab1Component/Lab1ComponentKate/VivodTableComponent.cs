using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Lab1ComponentKate
{
    public partial class VivodTableComponent : UserControl
    {
        private event EventHandler _gridViewSelectedElementChangeName;

        [Category("Спецификация"), Description("Событие выбора элемента")]
        public event EventHandler GridViewSelectedElementChange
        {
            add { _gridViewSelectedElementChangeName += value; }
            remove { _gridViewSelectedElementChangeName -= value; }
        }
        public VivodTableComponent()
        {
            InitializeComponent();
            dataGridView.CellClick += (sender, e) =>
            {
                _gridViewSelectedElementChangeName?.Invoke(sender, e);
            };
            dataGridView.CellClick += (e, a) => MessageBox.Show("Значение ячейки: " + SelectedTextName, "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //При нажатии на ячейку таблицы, выведиться содержание ячейки
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedTextName
        {
            get { return dataGridView.CurrentCell.Value.ToString(); }
        }

        //Загрузка таблицы: список объектво класса, список заголовков, список полей, которые необходимо вывести
        public void LoadEnumerationName(List<object> listPost, List<string> titles, List<string> fields)
        {
            dataGridView.Rows.Clear();
            if (titles.Count != fields.Count)
            {
                MessageBox.Show("Количество колонок не соответствует количеству заголовков", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Заполнение заголовков
            for (int i = 0; i < titles.Count; i++)
                dataGridView.Columns.Add("Column" + i, titles[i]);
            //Вызов метода конфигурации таблицы
            ChangeColumn();
            //Заполнение таблицы
            foreach (var item in listPost)
            {
                Type t = item.GetType();
                string[] field = new string[titles.Count];
                int i = 0;
                foreach (var _field in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    if (fields.Contains(new Regex(@"<(.*?)>").Match(_field.Name).Groups[1].Value))
                    {
                        var str = _field.GetValue(item);
                        if (str != null)
                        {
                            field[i++] = str.ToString();
                        }
                    }
                }
                //Вызов метода добавления строки в таблицу
                AddRow(field);
            }
        }

        //Метод добавления  строки в таблицу
        public void AddRow(string[] field)
        {
            dataGridView.Rows.Add(field);
        }

        //Метод конфигурации таблицы
        public void ChangeColumn()
        {
            Table table = new Table(120);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
                dataGridView.Columns[i].Width = table.Width;
        }
    }
}
