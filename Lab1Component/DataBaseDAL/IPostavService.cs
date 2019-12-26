using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseDAL
{
    public interface IPostavService
    {
        List<PostavViewModel> GetList();
        PostavViewModel GetElement(string name);
        void AddElement(PostavBindingModel model);
        void UpdElement(PostavBindingModel model);
        void DelElement(int id);
    }
}
