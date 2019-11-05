using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Component
{
    public partial class NameOrgListComponent : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndexName;
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _comboBoxSelectedElementChangeName;

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndexName
        {
            get { return _selectedIndexName; }
            set
            {
                if (value > -2 && value < comboBoxType.Items.Count)
                {
                    _selectedIndexName = value;
                    comboBoxType.SelectedIndex = _selectedIndexName;
                }
            }
        }

        /// <summary>
        /// Текст выбранной записи
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedTextName
        {
            get { return comboBoxType.Text; }
        }

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChangeName += value; }
            remove { _comboBoxSelectedElementChangeName -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public NameOrgListComponent()
        {
            InitializeComponent();
            comboBoxType.SelectedIndexChanged += (sender, e) =>
            {
                _comboBoxSelectedElementChangeName?.Invoke(sender, e);
            };
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadEnumerationName(Type type)
        {
            foreach (var elem in Enum.GetValues(type))
            {
                comboBoxType.Items.Add(elem.ToString());
            }
        }
    }
}
