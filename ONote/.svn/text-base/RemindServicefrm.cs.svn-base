using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Model;

namespace ONote
{
    public partial class RemindServicefrm : DevComponents.DotNetBar.Office2007Form
    {
        public RemindServicefrm()
        {
            InitializeComponent();
        }

        private Note _note;
        public RemindServicefrm(Note note)
        {
            InitializeComponent();
            _note = note;
            this.Text = "您有新的提醒:"+note.NoteName;
            lbltime.Text = "距离本次事件发生还有" + (DateTime.Now - note.RemindTime).Minutes.ToString() + "分钟";
            txtname.Text = note.NoteName;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            NoteEditFrm frm = new NoteEditFrm(_note);
            frm.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            _note.IsRemind = false;
            try
            {
                ClsCommon.GetNoteService.SaveOrUpdata(_note);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}