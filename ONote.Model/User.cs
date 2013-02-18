using System;
using System.Collections.Generic;
using System.Text;

namespace ONote.Model
{
    [Serializable]
   public class User
   {
       public virtual int UserID { get; set; }
       public virtual string UserName { get; set; }
       public virtual string PassWord { get; set; }
       public override string ToString()
       {
           return UserName.ToString();
       }
   }
}
