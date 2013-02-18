using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.Services.Description;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model.Primitives;
using ONote.Common.Data;
using ONote.Dto;
using ONote.Model;
using ONote.Model.Enum;

namespace ONote
{
    public partial class Notesfrm : DevComponents.DotNetBar.Office2007Form
    {
        public Notesfrm()
        {
            InitializeComponent();
        }

        private QueryNoteDto _queryNoteDtotemp=new QueryNoteDto() ;

        private void Notesfrm_Load(object sender, EventArgs e)
        {
            //IList<Note> allNote = ClsCommon.GetNoteService.GetAllNote();
            //dataGridViewX1.AutoGenerateColumns = false;
            ////ONote.Common.Data.BindingCollection<Note> bnotes = new BindingCollection<Note>();
            ////foreach (Note bnote in allNote)
            ////{
            ////    bnotes.Add(bnote);
            ////}
            ////dataGridViewX1.DataSource = bnotes;
            SetQuery(_queryNoteDtotemp);
        }

        private void dataGridViewX1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteEditFrm noteEditFrm = new NoteEditFrm(dataGridViewX1.CurrentRow.DataBoundItem as Note);
            noteEditFrm.Show();

        }

        /// <summary>
        /// 按照现有条件刷新数据
        /// </summary>
        public void RefreshData()
        {
            SetQuery(_queryNoteDtotemp);
        }

        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                splitContainer2.Panel2Collapsed = true;
            //将详细内容的panel展开！
            splitContainer2.Panel2Collapsed = false;
            if (dataGridViewX1.CurrentRow != null)
            {
                splitContainer2.Panel2Collapsed = false;
                htmlEditorControl1.InnerHtml = (dataGridViewX1.CurrentRow.DataBoundItem as Note).NoteContent;
            }
            else
            {
                splitContainer2.Panel2Collapsed = true;

            }
        }
        /// <summary>
        /// 拆分器边距设置
        /// </summary>
        /// <param name="hor">是否纵向显示panel，纵向显示用height 横向用width</param>
        private void SetSpilterDistance(bool hor)
        {
            if (hor)
                splitContainer2.SplitterDistance = splitContainer2.Height / 2;
            else
                splitContainer2.SplitterDistance = splitContainer2.Width / 2;
        }


        private void comboBoxEx1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.Text == "竖排")
            {
                splitContainer2.Orientation = Orientation.Vertical;
                SetSpilterDistance(false);
            }
            else
            {
                splitContainer2.Orientation = Orientation.Horizontal;
                SetSpilterDistance(true);
            }
        }
        /// <summary>
        /// 设置查询条件
        /// </summary>
        /// <param name="queryNoteDto"></param>
        public void SetQuery(Dto.QueryNoteDto queryNoteDto)
        {
            _queryNoteDtotemp = queryNoteDto;
            dataGridViewX1.AutoGenerateColumns = false;
            var allNote = ClsCommon.GetNoteService.GetNoteByCondition(queryNoteDto);
            BindingCollection<Note> bnotes = new BindingCollection<Note>();
            foreach (Note bnote in allNote)
            {
                bnotes.Add(bnote);
            }
            dataGridViewX1.DataSource = bnotes;
        }
         
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("您确定要删除选中的记录？", "确定", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                 
                 
                IList<Note> note = new List<Note>();
                DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = dataGridViewX1.SelectedRows;

                foreach (DataGridViewRow dataGridViewRow in dataGridViewSelectedRowCollection)
                {
                    note.Add(dataGridViewRow.DataBoundItem as Note);
                }
                ClsCommon.GetNoteService.VirtualDelete(note);
                MessageBox.Show("删除记事成功！");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除数据时候出现异常" + ex.Message);
            }

           // dataGridViewX1.Refresh();
        }

        private void dataGridViewX1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                splitContainer2.Panel2Collapsed = true;
        }

       

       

        
    }
}