using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ONote.Common.Dao;
using ONote.Dto;
using ONote.Model;

namespace ONote.IDao
{
    public interface INoteDao : IRepositoryBase<Note>
    {
        IList<Note> GetAllNote();
        IList<Note> GetNoteByCondition(QueryNoteDto queryNoteDto);
        /// <summary>
        /// 查询记事内容，设置一个name属性，可查找name和content内容！
        /// </summary>
        /// <param name="queryNoteDto"></param>
        /// <returns></returns>
        IList<Note> SearchNotes(QueryNoteDto queryNoteDto);
        /// <summary>
        /// 获取提醒
        /// </summary>
        /// <returns></returns>
        IList<Note> GetRemind();
        /// <summary>
        /// 虚拟删除，将记事本删入回收站！
        /// </summary>
        void VirtualDelete(IList<Note> notes);
        /// <summary>
        /// 还原回收站的项目
        /// </summary>
        /// <param name="notes"></param>
        void RevertNote(IList<Note> notes);
        /// <summary>
        /// 获取回收站中的文件
        /// </summary>
        /// <returns></returns>
        IList<Note> GetDeletedNotes();
    }
}
