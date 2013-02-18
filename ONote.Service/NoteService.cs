using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.IDao;
using ONote.IService;
using ONote.Model;

namespace ONote.Service
{
   public class NoteService:ServiceBase<INoteDao>,INoteService
    {
        public IList<Model.Note> GetAllNote()
        {
           return Dao.GetAllNote();
        }

        public IList<Model.Note> GetNoteByCondition(Dto.QueryNoteDto queryNoteDto)
        {
            return Dao.GetNoteByCondition(queryNoteDto);
        }


        public void SaveOrUpdata(Model.Note note)
        {
            Dao.SaveOrUpdate(note);
        }

     

       

        public void Delete(IList<Note> notes)
        {
          Dao.DeleteEntity( notes);
        }
 


        public IList<Note> SearchNotes(Dto.QueryNoteDto queryNoteDto)
        {
            return Dao.SearchNotes(queryNoteDto);
        }

     
     


        public IList<Note> GetRemind()
        {
           return  Dao.GetRemind();
        }

       


        public IList<Note> GetNoCompleteRemind()
        {
           return Dao.GetRemind().Where(x => x.RemindTime > DateTime.Now).ToList();
        }



        public void VirtualDelete(IList<Note> notes)
        {
            Dao.VirtualDelete(notes);
        }



        #region INoteService 成员


        public IList<Note> GetDeletedNotes()
        {
          return  Dao.GetDeletedNotes();
        }

        #endregion

        #region INoteService 成员


        public void RevertNote(IList<Note> notes)
        {Dao.RevertNote(notes);
        }

        #endregion
    }
}
