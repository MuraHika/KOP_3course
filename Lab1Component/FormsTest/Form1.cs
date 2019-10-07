using Lab1Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameOrgListComponent.LoadEnumerationName(typeof(Test.TypeOrg));
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(nameOrgListComponent.SelectedTextName);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            saveBackupComponent.SaveJSON();
        }
    }
}
