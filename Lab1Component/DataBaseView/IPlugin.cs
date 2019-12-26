using DataBaseDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseView
{
    public interface IPlugin
    {
        public string Operation { get; }

        void RunPlugin(PluginsView pluginsView);
    }
}
