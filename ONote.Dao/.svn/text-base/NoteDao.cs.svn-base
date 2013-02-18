using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using ONote.Common.Dao;
using ONote.IDao;
using ONote.Model;
using Spring.Data.NHibernate;
using NHibernate.Engine;
using Spring.Data.NHibernate.Support;
namespace ONote.Dao
{
    public class NoteDao : RepositoryBase<Note>, INoteDao
    {

        public IList<Note> GetAllNote()
        {
            return Session.QueryOver<Note>().Where(x => x.IsDeleted == false).OrderBy(x => x.ModifyDate).Desc.List();
        }




        public IList<Note> GetNoteByCondition(Dto.QueryNoteDto queryNoteDto)
        {

            var result = Session.QueryOver<Note>().Where(x=>x.IsDeleted==false);

            if (queryNoteDto != null)
            {
                if (!string.IsNullOrEmpty(queryNoteDto.CategoryName))
                    result = result.Where(x => x.CategoryID.CategoryName == queryNoteDto.CategoryName);
                //if (!string.IsNullOrEmpty(queryNoteDto.CreateDate ))
                //    result = result.Where(x => x.CreateDate.Day == DateTime.Parse(queryNoteDto.CreateDate).Day);
             
                if (!string.IsNullOrEmpty(queryNoteDto.CreateDate))
                    result =
                        result.Where(
                            x =>
                            x.CreateDate > DateTime.Parse(queryNoteDto.CreateDate).Date &&
                            x.CreateDate < DateTime.Parse(queryNoteDto.CreateDate).Date.AddDays(1));

                if (!string.IsNullOrEmpty(queryNoteDto.ModifyDate))
                    result = result.Where(x => x.ModifyDate.Day == DateTime.Parse(queryNoteDto.ModifyDate).Day);
                if (!string.IsNullOrEmpty(queryNoteDto.NoteContent))
                    result = result.Where(x => x.NoteContent.IsLike(queryNoteDto.NoteContent, MatchMode.Anywhere));
                if (!string.IsNullOrEmpty(queryNoteDto.NoteName))
                    result = result.Where(x => x.NoteName.IsLike(queryNoteDto.NoteName, MatchMode.Anywhere));
                if (!string.IsNullOrEmpty(queryNoteDto.UserName))
                    result = result.Where((x => x.UserID.UserName == queryNoteDto.UserName));

            }

            return result.OrderBy(x=>x.CreateDate).Desc.List();
        }

        #region INoteDao 成员


        public IList<Note> SearchNotes(Dto.QueryNoteDto queryNoteDto)
        {
            var result =
                Session.QueryOver<Note>().Where(
                    x =>
                    x.NoteContent.IsLike(queryNoteDto.NoteName, MatchMode.Anywhere) ||
                    x.NoteName.IsLike(queryNoteDto.NoteName, MatchMode.Anywhere)).Where(x=>x.IsDeleted==false).OrderBy(x => x.CreateDate).Desc.List();
            return result;
        }

        #endregion

        #region INoteDao 成员


        public IList<Note> GetRemind()
        {
            var result =
                Session.QueryOver<Note>().Where(
                    x =>
                    x.IsRemind).Where(x => x.IsDeleted == false).OrderBy(x => x.CreateDate).Desc.List();
            return result;
        }

        #endregion

        #region INoteDao 成员


        public void VirtualDelete(IList<Note> notes)
        {
            foreach (Note note in notes)
            {
                note.IsDeleted = true;
                SaveOrUpdate(note);
                
            }
            
            
        }

        #endregion

        #region INoteDao 成员


        public IList<Note> GetDeletedNotes()
        {
            return Session.QueryOver<Note>().Where(x => x.IsDeleted == true).OrderBy(x => x.ModifyDate).Desc.List();
        }

        #endregion

        #region INoteDao 成员


        public void RevertNote(IList<Note> notes)
        {
            foreach (Note note in notes)
            {
                note.IsDeleted = false;
                SaveOrUpdate(note);

            }
        }

        #endregion
    }
}
