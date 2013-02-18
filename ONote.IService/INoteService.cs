using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Dto;
using ONote.Model;

namespace ONote.IService
{
   public interface INoteService
    {
        IList<Note> GetAllNote();
        IList<Note> GetNoteByCondition(QueryNoteDto queryNoteDto);
        /// <summary>
        /// 查询记事内容，设置一个name属性，可查找name和content内容！
        /// </summary>
        /// <param name="queryNoteDto"></param>
        /// <returns></returns>
        IList<Note> SearchNotes(Dto.QueryNoteDto queryNoteDto);
       void SaveOrUpdata(Note note);
       void Delete(IList<Note> notes);
       /// <summary>
       /// 获取提醒
       /// </summary>
       /// <returns></returns>
       IList<Note> GetRemind();
       /// <summary>
       /// 获取未完成的remind
       /// </summary>
       /// <returns></returns>
       IList<Note> GetNoCompleteRemind();
       //虚拟删除
       void VirtualDelete(IList<Note> notes);
       /// <summary>
       /// 获取回收站中的文件
       /// </summary>
       /// <returns></returns>
       IList<Note> GetDeletedNotes();
       /// <summary>
       /// 还原回收站的项目
       /// </summary>
       /// <param name="notes"></param>
       void RevertNote(IList<Note> notes);
    }
}
