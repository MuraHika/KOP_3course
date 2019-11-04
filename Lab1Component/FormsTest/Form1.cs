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

            Test org1 = new Test(Test.NameOrg.Авиастар.ToString(), Test.TypeOrg.ОАО.ToString());
            Test org2 = new Test(Test.NameOrg.УАЗ.ToString(), Test.TypeOrg.ООО.ToString());
            Test[] org = new Test[] { org1, org2 };
            saveBackupComponent.SaveJSON("O://", org);
        }
    }
}
