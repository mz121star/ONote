using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONote.Dto
{
  public  class QueryNoteDto
    {
       
        public  string  NoteName { get; set; }
        public  string  CreateDate { get; set; }
        public  string  ModifyDate { get; set; }
        public  string  NoteContent { get; set; }
        public  string UserName { get; set; }
        public string CategoryName{ get; set; }
    }
}
