using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.IDao;
using ONote.Model;

namespace ONote.Dao
{
    public class UserDao : RepositoryBase<User>,IUserDao
    {
       

        public User UserLogin(string uname, string password)
        {
            return Session.QueryOver<User>().Where(x => x.UserName == uname && x.PassWord == password).SingleOrDefault();
        }

        


        public IList<User> GetAllUser()
        {
            IList<User> list= Session.QueryOver<User>().OrderBy(x => x.UserName).Asc.List();
            return list;
        }
 
    }
}
