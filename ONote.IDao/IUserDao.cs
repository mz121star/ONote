using System;
using System.Collections.Generic;
using System.Text;
using ONote.Common.Dao;
using ONote.Model;

namespace ONote.IDao
{
    public interface IUserDao : IRepositoryBase<User>
    {
        User UserLogin(string uname, string password);
        IList<User> GetAllUser();

    }
}
