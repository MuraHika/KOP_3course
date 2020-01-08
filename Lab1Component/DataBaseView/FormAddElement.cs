using DataBaseDAL;
using System;
using System.Windows.Forms;
using Unity;

namespace DataBaseView
{
    public partial class FormAddElement : Form
    {
        private readonly IPostavService service;

        public FormAddElement(IPostavService service)
        {
            InitializeComponent();
            this.service = service;
            facadePatternView.LoadNameOrg();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            facadePatternView.AddDate(textBoxName.Text, service);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
