using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Common.Data;
using ONote.Common.Forms;
using ONote.Model;

namespace ONote
{
    public partial class Remindfrm : DevComponents.DotNetBar.Office2007Form
    {
        public Remindfrm()
        {
            InitializeComponent();
        }

        private void Remindfrm_Load(object sender, EventArgs e)
        {
            SetData();
        }
        public void SetData()
        {
            
            dataGridViewX1.AutoGenerateColumns = false;
            var allNote = ClsCommon.GetNoteService.GetRemind();
            BindingCollection<Note> bnotes = new BindingCollection<Note>();
            foreach (Note bnote in allNote)
            {
                bnotes.Add(bnote);
            }
            dataGridViewX1.DataSource = bnotes;
            //SingletonForms<Form2>.Instance.SetNoCompleteRemin();

        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteEditFrm noteEditFrm = new NoteEditFrm(dataGridViewX1.CurrentRow.DataBoundItem as Note);
            noteEditFrm.Show();
        }
    }
}