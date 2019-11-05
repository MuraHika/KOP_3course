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
using System.Reflection;
using System.Text.RegularExpressions;

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

        public void SaveJSON(string path, object[] org)
        {
            try
            {
                if (File.Exists(path + "ZipBackup.rar"))
                {
                    File.Delete(path + "ZipBackup.rar");
                }
                else
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(org.GetType());
                    string pathDir = path + "directory";
                    DirectoryInfo directoryinfo = Directory.CreateDirectory(pathDir);

                    string pathJSON = pathDir + "//backup.json";
                    try
                    {
                        foreach (var item in org)
                        {
                            Type t = item.GetType();
                            if (t.IsSerializable)
                            {
                                MessageBox.Show("Класс" + t + " не является сериализуемым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

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
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Ошибка");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Класс не является сериализуемым", "Ошибка");
            }
        }
    }
}
