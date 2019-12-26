using DataBase;
using DataBaseDAL;
using DataBaseImplementDataBase;
using DataBaseView;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateType
{
    [Export(typeof(IPlugin))]
    public class Type_update : IPlugin
    {
        private DataBaseDbContext context;
        public Type_update(DataBaseDbContext context)
        {
            this.context = context;
        }

        public string Operation => "Смена типа организации";

        public void RunPlugin(PluginsView pluginsView)
        {
            int id = pluginsView.listB[0].Id;
            Postav element = context.Postavs.FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Поставка не найдена");
            }
            element.TypeOrg = pluginsView.listB[0].TypeOrg;
            context.SaveChanges();
        }

        public override string ToString()
        {
            return Operation;
        }
    }
}
