﻿using DataBaseDAL;
using DataBaseImplementDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseView
{
    public class Manager
    {
        [ImportMany(typeof(IPlugin))]
        public List<IPlugin> Plugins = new List<IPlugin>();
        private DataBaseDbContext model;
        public Manager(DataBaseDbContext model)
        {
            this.model = model;
        }

        public void LoadPlugins(string dir)
        {
            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dir);
            string[] files = Directory.GetFiles(folder, "*.dll");
            foreach (string file in files)
            {
                IPlugin plugin = IsPlugin(file);
                if (plugin != null)
                    Plugins.Add(plugin);
            }
        }

        private IPlugin IsPlugin(string file_url)
        {

            byte[] b = System.IO.File.ReadAllBytes(file_url);
            System.Reflection.Assembly assembly = System.Reflection.Assembly.Load(b);
            foreach (Type type in assembly.GetTypes())
            {
                if (type.GetInterface("IPlugin") != null)
                {
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(type, model);
                    return plugin;
                }
            }
            return null;
        }
    }
}
