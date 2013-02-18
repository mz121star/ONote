using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Forms;
using ONote.Model;

namespace ONote
{
   public class RemindService
    {
       public static void Remind()
       {
           var reminds = ClsCommon.GetNoteService.GetRemind().Where(
               x => (x.RemindTime - DateTime.Now).Minutes > -5 && (x.RemindTime - DateTime.Now).Minutes < 5).ToList();

           foreach (Note  remind in reminds)
           {
               if(remind!=null)
               {
                   RemindServicefrm remindServicefrm = new RemindServicefrm(remind);
                   remindServicefrm.Show();
               }
           }
       }
      
    }
}
