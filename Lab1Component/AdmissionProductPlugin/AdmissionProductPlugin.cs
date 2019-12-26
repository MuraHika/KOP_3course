using DataBaseDAL;
using DataBaseImplementDataBase;
using DataBaseView;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionProductPlugin
{
    [Export(typeof(IPlugin))]
    public class AdmissionProductPlugin : IPlugin
    {
        private DataBaseDbContext context;
        public AdmissionProductPlugin(DataBaseDbContext context)
        {
            this.context = context;
        }
        public string Operation => "Поставка товара";

        public void RunPlugin(PluginsView pluginsView)
        {
            List<PostavBindingModel> result = context.Postavs.Select(rec => new PostavBindingModel
            {
                Id = rec.Id,
                Name = rec.Name,
                TypeOrg = rec.TypeOrg,
                DateLastPost = rec.DateLastPost
            }).ToList();
            pluginsView.listB = new List<PostavBindingModel>(result);
        }

        public override string ToString()
        {
            return Operation;
        }
    }
}
