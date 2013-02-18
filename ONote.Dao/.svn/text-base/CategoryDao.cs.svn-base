using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.IDao;
using ONote.Model;

namespace ONote.Dao
{
    public class CategoryDao : RepositoryBase<Category>, ICategoryDao
    {
        public IList<Category> GetAllCategory()
        {
          return  Session.QueryOver<Category>().OrderBy(x => x.CategoryName).Asc.List();
        }

        public IList<Category> GetCategoryByName(string name)
        {
            return Session.QueryOver<Category>().Where(x=>x.CategoryName.ToLower()==name.ToLower()).OrderBy(x => x.CategoryName).Asc.List();
        }
    }
}
