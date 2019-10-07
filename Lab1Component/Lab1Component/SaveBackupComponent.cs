using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Ionic.Zip;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Component
{
    public partial class SaveBackupComponent : Component
    {
        FolderBrowserDialog bd = new FolderBrowserDialog();

        public SaveBackupComponent()
        {
            InitializeComponent();
        }

        public SaveBackupComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void buttonSaveBackup_Click(object sender, EventArgs e)
        {

        }

        public void SaveJSON()
        {

            Test org1 = new Test(Test.NameOrg.Авиастар.ToString(), Test.TypeOrg.ОАО.ToString());
            Test org2 = new Test(Test.NameOrg.УАЗ.ToString(), Test.TypeOrg.ООО.ToString());
            Test[] org = new Test[] { org1, org2 };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Test[]));
            SaveFileDialog path = new SaveFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directoryinfo = Directory.CreateDirectory(path.FileName);
                SaveFileDialog pathJSON = new SaveFileDialog();
                pathJSON.Filter = "JSON files (*.json)|*.json";
                if (pathJSON.ShowDialog() == DialogResult.OK)

                {
                    using (FileStream fs = new FileStream(pathJSON.FileName, FileMode.OpenOrCreate))
                    {
                        jsonFormatter.WriteObject(fs, org);
                    }
                }



                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Zip files (*.zip)|*.zip";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ZipFile zf = new ZipFile(sfd.FileName);
                    zf.AddDirectory(directoryinfo.FullName);
                    zf.Save();
                    directoryinfo.Delete(true);
                    MessageBox.Show("Архивация прошла успешно.", "Выполнено");
                }
            }
        }

    }
}
