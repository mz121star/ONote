using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ONote.Model;

namespace ONote
{
  public  class StartupInit
    {
      public static  void ONoteStart()
      {
          IList<User> allUser = ClsCommon.GetUserService.GetAllUser();
          if(allUser.Count==0)
          {
              StartupInitRegisterUserfrm registerUserfrm = new StartupInitRegisterUserfrm("新用户登陆系统，请先注册一个用户！");
              registerUserfrm.ShowDialog();

              if (ClsCommon.GetUserService.GetAllUser().Count!=0)
                         Application.Run(new LoginFrm());
           
          }
          else
          {
              Application.Run(new LoginFrm());
          }
          
      }
    }
}
