using DataBase;
using DataBaseDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplementDataBase
{
    public class DataBaseServiceDB : IPostavService
    {
        private DataBaseDbContext context; 
        public DataBaseServiceDB(DataBaseDbContext context)
        {
            this.context = context;
        }
        public List<PostavViewModel> GetList()
        {
            List<PostavViewModel> result = context.Postavs.Select(rec => new PostavViewModel
            {
                Id = rec.Id,
                Name = rec.Name,
                TypeOrg = rec.TypeOrg,
                DateLastPost = rec.DateLastPost.ToString()
            }).ToList();
            return result;
        }

        public PostavViewModel GetElement(int id)
        {
            Postav element = context.Postavs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new PostavViewModel
                {
                    Id = element.Id,
                    Name = element.Name,
                    TypeOrg = element.TypeOrg,
                    DateLastPost = element.DateLastPost.ToString()
                };
            }
            throw new Exception("Поставка не найдена");
        }

        public void AddElement(PostavBindingModel model)
        {
            context.Postavs.Add(new Postav
            {
                Name = model.Name,
                TypeOrg = model.TypeOrg,
                DateLastPost = model.DateLastPost
            });
            context.SaveChanges();
        }

        public void UpdElement(PostavBindingModel model)
        {
            Postav element = context.Postavs.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Поставка не найдена");
            }
            element.Name = model.Name;
            element.TypeOrg = model.TypeOrg;
            element.DateLastPost = model.DateLastPost;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Postav element = context.Postavs.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Postavs.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Поставка не найдена");
            }
        }

    }
}
