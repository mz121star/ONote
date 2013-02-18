using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.IDao;
using ONote.IService;
using ONote.Model;

namespace ONote.Service
{
    public class CategoryService : ServiceBase<ICategoryDao>, ICategoryService
    {

        public IList<Category> GetAllCategory()
        {
           return Dao.GetAllCategory();
        }

        public IList<Category> GetCategoryByName(string name)
        {
            return Dao.GetCategoryByName(name);
        }


        public void SaveOrUpdata(Category category)
        {
            Dao.SaveOrUpdate(category);
        }
    }
}
