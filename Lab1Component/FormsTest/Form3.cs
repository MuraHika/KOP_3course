using Lab1ComponentKate;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            vivodTableComponent.LoadEnumerationName(Test.listName, Test.listNumber);
        }

        private void buttonCreateD_Click(object sender, EventArgs e)
        {
            diagrammaExcelComponent.CreateDiagram();
        }
    }
}
