using ControlLibrary;
using DataBase;
using DataBaseDAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace DataBaseView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPostavService service;
        List<Month_Count> listCount;


        public FormMain(IPostavService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void LoadData()
        {
            try
            {
                List<PostavViewModel> list = service.GetList();

                if (list != null)
                {
                    treeView1.Nodes.Clear();
                    List<string> listType = new List<string>();
                    foreach (var elem in Enum.GetValues(typeof(TypeOrganization.TypeOrg)))
                    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAddElement>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSaveBackUp_Click(object sender, EventArgs e)
        {
            List<PostavViewModel> list = service.GetList();
            PostavViewModel[] org = new PostavViewModel[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                org[i] = list[i];
            }
            saveBackupComponent.SaveJSON("O://", org);
        }

        private void buttonWordRept_Click(object sender, EventArgs e)
        {
            List<PostavViewModel> list = service.GetList();
            List<List<string>> contents = new List<List<string>>();
            contents.Add(new List<string>());
            contents.Add(new List<string>());
            for (int i = 0; i < list.Count; i++)
            {
                contents[0].Add(list[i].Name);
                contents[1].Add(list[i].TypeOrg);
            }
            wordReport.SetData(contents);
            int RowCount = 0;
            for (int i = 0; i < contents.Count; i++)
            {
                if (contents[i].Count > RowCount)
                {
                    RowCount = contents[i].Count;
                }
            }
            wordReport.columnCount = contents.Count;
            wordReport.rowCount = RowCount;
            string[] rowName = { "Название", "Тип организации" };
            wordReport.CreateTable(rowName, null, "O://WordReport");
        }

        private void buttonWordDiagr_Click(object sender, EventArgs e)
        {
            List<PostavViewModel> list = service.GetList();
            string[] month = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int j = 0;
            int count_postav;
            while (j < month.Length)
            {
                count_postav = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if ((list[i].DateLastPost.Split(' ')[0] == month[j]))
                    {
                        count_postav++;
                    }
                }
                count[j] = count_postav;
                j++;
            }
            listCount = new List<Month_Count>();
            for (int k = 0; k < month.Length; k++)
            {
                listCount.Add(new Month_Count { Month = month[k], Count = count[k] });
            }
            WordDiagramMaker.CreateDiagram(listCount, "Month", "Count", "O://WordDiagr.docx");

        }

        private void button_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<PluginsView>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            LoadData();
        }
    }
}