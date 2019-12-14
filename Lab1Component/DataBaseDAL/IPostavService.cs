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
        PostavViewModel GetElement(int id);
        void AddElement(PostavBindingModel model);
        void UpdElement(PostavBindingModel model);
        void DelElement(int id);
    }
}
