using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Common.Data;
using ONote.Model;

namespace ONote
{
    public partial class Recyclefrm : DevComponents.DotNetBar.Office2007Form
    {
        public Recyclefrm()
        {
            InitializeComponent();
        }

        private void Recyclefrm_Load(object sender, EventArgs e)
        {
            SetData();
        }
        private void SetData()
        {
            dataGridViewX1.AutoGenerateColumns = false;
            var allNote = ClsCommon.GetNoteService.GetDeletedNotes();
            BindingCollection<Note> bnotes = new BindingCollection<Note>();
            foreach (Note bnote in allNote)
            {
                bnotes.Add(bnote);
            }
            dataGridViewX1.DataSource = bnotes;
        }
        private void btnrevert_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("您确定要还原选中的记录？", "确定", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {


                IList<Note> note = new List<Note>();
                DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = dataGridViewX1.SelectedRows;

                foreach (DataGridViewRow dataGridViewRow in dataGridViewSelectedRowCollection)
                {
                    note.Add(dataGridViewRow.DataBoundItem as Note);
                }
                ClsCommon.GetNoteService.RevertNote(note);
                MessageBox.Show("还原记事成功！");
                SetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("还原数据时候出现异常" + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("您确定要彻底删除选中的记录？删除之后无法恢复！", "确定", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {


                IList<Note> note = new List<Note>();
                DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = dataGridViewX1.SelectedRows;

                foreach (DataGridViewRow dataGridViewRow in dataGridViewSelectedRowCollection)
                {
                    note.Add(dataGridViewRow.DataBoundItem as Note);
                }
                ClsCommon.GetNoteService.Delete(note);
                MessageBox.Show("彻底删除记事成功！");
                SetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("彻底删除数据时候出现异常" + ex.Message);
            }
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.CurrentRow != null)
            {
                NoteEditFrm frm = new NoteEditFrm(dataGridViewX1.CurrentRow.DataBoundItem as Note, false);
                frm.ShowDialog();
            }
        }
    }
}