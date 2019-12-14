using DataBase;
using DataBaseDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace DataBaseView
{
    public partial class FormAddElement : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IPostavService service;
        private int? id;

        public FormAddElement(IPostavService service)
        {
            InitializeComponent();
            this.service = service;
            nameOrgListComponent.LoadEnumerationName(typeof(TypeOrganization.TypeOrg));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new PostavBindingModel
                    {
                        Id = id.Value,
                        Name = textBoxName.Text,
                        TypeOrg = nameOrgListComponent.SelectedTextName,
                        DateLastPost = dateView.getValue()
                    });
                }
                else
                {
                    service.AddElement(new PostavBindingModel
                    {
                        Name = textBoxName.Text,
                        TypeOrg = nameOrgListComponent.SelectedTextName,
                        DateLastPost = dateView.getValue()
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
