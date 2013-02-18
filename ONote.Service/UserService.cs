using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.IDao;
using ONote.IService;
using ONote.Model;

namespace ONote.Service
{
   public class UserService: ServiceBase<IUserDao>, IUserService
    {
       

        public Model.User UserLogin(string username, string password)
        {
            return   Dao.UserLogin(username, password);
        }



        #region IUserService 成员


        public IList<Model.User> GetAllUser()
        {
            return Dao.GetAllUser();
        }

        #endregion

        #region IUserService 成员


        public void SaveOrUpdata(User user)
        {
          Dao.SaveOrUpdate(user);
        }

        #endregion
    }
}
