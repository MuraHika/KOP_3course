using Lab1ComponentDasha;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chastotaDiapComponent.LoadEnumerationName(Test.list);
        }

        private void buttonSavePDF_Click(object sender, EventArgs e)
        {
            requestPDFComponent.SavePDF();
        }
    }
}
