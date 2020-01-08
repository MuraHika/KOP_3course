using DataBase;
using DataBaseDAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using System.Runtime.CompilerServices;
using DependencyAttribute = Unity.DependencyAttribute;
using Octokit;

namespace DataBaseView
{
    public partial class PluginsView : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        Manager manager;
        private readonly IPostavService service;
        public List<PostavBindingModel> listB;
        public PluginsView(IPostavService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void PluginsView_Load(object sender, EventArgs e)
        {
            LoadData();
            

            manager = Container.Resolve<Manager>();
            manager.LoadPlugins("plugins");
            if (manager.Plugins.Count != 0 && manager.Plugins != null)
            {
                comboBoxOperation.Items.AddRange(manager.Plugins.ToArray());
                comboBoxOperation.Text = manager.Plugins[0].ToString();
            }
        }

        public void LoadData() {
            treeView1.Nodes.Clear();
            List<string> listType = new List<string>();
            List<PostavViewModel> list = service.GetList();
            foreach (var elem in Enum.GetValues(typeof(TypeOrganization.TypeOrg)))
            {
                comboBoxTypeOrg.Items.Add(elem.ToString());
                listType.Add(elem.ToString());
            }
            for (int i = 0; i < listType.Count; i++)
            {
                treeView1.Nodes.Add(listType[i].ToString());
                for (int j = 0; j < list.Count; j++)
                {
                    if (listType[i].Equals(list[j].TypeOrg))
                        treeView1.Nodes[i].Nodes.Add(list[j].Name);
                }

            }
        }

        private void buttonChangeType_Click(object sender, EventArgs e)
        {
            try
            {
                var temp1 = treeView1.SelectedNode.Text;
                var temp = service.GetElement(temp1);
                var date = temp.DateLastPost;
                PostavBindingModel bdm = new PostavBindingModel
                {
                    Id = temp.Id,
                    Name = temp.Name,
                    TypeOrg = comboBoxTypeOrg.SelectedItem.ToString(),
                    DateLastPost = temp.DateLastPost.Equals("") ? (DateTime?)null : Convert.ToDateTime(temp.DateLastPost)
                };
                listB = new List<PostavBindingModel>();
                listB.Add(bdm);
                ((IPlugin)comboBoxOperation.SelectedItem).RunPlugin(this);
                MessageBox.Show("Отлично обновлено", "Отлично", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Ошибка", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void buttonAdmission_Click(object sender, EventArgs e)
        {
            try
            {
                listB = new List<PostavBindingModel>();
                ((IPlugin)comboBoxOperation.SelectedItem).RunPlugin(this);
                for (int i = 0; i < listB.Count; i++)
                {
                    listBox.Items.Add(listB[i].Name + " - " + listB[i].DateLastPost.ToString());
                }
                MessageBox.Show("Список получен и выведен", "Отлично", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Ошибка", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            try
            {
                List<PostavViewModel> list = service.GetList();
                listB = new List<PostavBindingModel>();
                for (int i = 0; i < list.Count; i++)
                {
                    PostavBindingModel bdm = new PostavBindingModel
                    {
                        Id = list[i].Id,
                        Name = list[i].Name,
                        TypeOrg = list[i].TypeOrg,
                        DateLastPost = list[i].DateLastPost.Equals("") ? (DateTime?)null : Convert.ToDateTime(list[i].DateLastPost)
                    };
                    listB.Add(bdm);
                }
                ((IPlugin)comboBoxOperation.SelectedItem).RunPlugin(this);
                MessageBox.Show("Отчет сформирован", "Отлично", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Ошибка", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
