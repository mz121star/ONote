using System;
using System.Collections.Generic;
using System.Text;

namespace ONote.Model
{
    [Serializable]
    public class Note
    {
        public virtual int NoteID { get; set; }
        public virtual string NoteName { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime ModifyDate { get; set; }
        public virtual DateTime RemindTime { get; set; }
        public virtual bool IsRemind { get; set; }
        public virtual string NoteContent { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual User UserID{ get; set; }
        public virtual Category CategoryID { get; set; }
 
    }
}
