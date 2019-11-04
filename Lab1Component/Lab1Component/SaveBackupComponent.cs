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

        public void SaveJSON(string path, Test[] org)
        {

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Test[]));
            string pathDir = path + "directory";
            DirectoryInfo directoryinfo = Directory.CreateDirectory(pathDir);

            string pathJSON = pathDir + "//backup.json";
            using (FileStream fs = new FileStream(pathJSON, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, org);
            }

            string sfd = path + "ZipBackup.rar";
            ZipFile zf = new ZipFile(sfd);
            zf.AddDirectory(directoryinfo.FullName);
            zf.Save();
            directoryinfo.Delete(true);
            MessageBox.Show("Архивация прошла успешно.", "Выполнено");
        }
    }
}
