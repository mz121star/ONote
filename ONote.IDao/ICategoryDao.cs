using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.Model;

namespace ONote.IDao
{
    public interface ICategoryDao : IRepositoryBase<Category>
    {
        IList<Category> GetAllCategory();
        IList<Category> GetCategoryByName(string name);
    }
}
