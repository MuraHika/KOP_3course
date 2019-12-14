using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDAL
{
    public class PostavBindingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeOrg { get; set; }
        public DateTime? DateLastPost { get; set; }
    }
}
