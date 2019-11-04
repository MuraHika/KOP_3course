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
        public VivodTableComponent()
        {
            InitializeComponent();
            dataGridView.CellClick += (e, a) => MessageBox.Show("Значение ячейки: " + SelectedTextName, "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedTextName
        {
            get { return dataGridView.CurrentCell.Value.ToString(); }
        }

        public void LoadEnumerationName(List<Test> listPost, List<string> titles, List<string> fields)
        {
            for (int i = 0; i < titles.Count; i++)
                dataGridView.Columns.Add("Column" + i, titles[i]);
            ChangeColumn();
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
                AddRow(field);
            }
        }

        public void AddRow(string[] field)
        {
            dataGridView.Rows.Add(field);
        }

        public void ChangeColumn()
        {
            Table table = new Table(120);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
                dataGridView.Columns[i].Width = table.Width;
        }
    }
}
