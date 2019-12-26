using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using DataBaseDAL;
using DataBase;

namespace DataBaseView
{
    public partial class FacadePatternView : UserControl
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        public FacadePatternView()
        {
            InitializeComponent();
        }

        public void LoadNameOrg() {
            nameOrgListComponent.LoadEnumerationName(typeof(TypeOrganization.TypeOrg));
        }

        public void AddDate(string NameOrg, IPostavService service) {
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new PostavBindingModel
                    {
                        Id = id.Value,
                        Name = NameOrg,
                        TypeOrg = nameOrgListComponent.SelectedTextName,
                        DateLastPost = dateView.getValue()
                    });
                }
                else
                {
                    service.AddElement(new PostavBindingModel
                    {
                        Name = NameOrg,
                        TypeOrg = nameOrgListComponent.SelectedTextName,
                        DateLastPost = dateView.getValue()
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
