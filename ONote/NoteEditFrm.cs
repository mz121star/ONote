using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NHibernate.Collection.Generic;
using ONote.Common.Forms;
using ONote.Model;

namespace ONote
{
    public partial class NoteEditFrm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public NoteEditFrm()
        {
            InitializeComponent();
        }
        public NoteEditFrm(Note note)
        {
            InitializeComponent();
            CurrentNote = note;
        }
        /// <summary>
        /// ������ʾ����վԤ��ʱ�Ĺ��캯��
        /// </summary>
        /// <param name="note"></param>
        /// <param name="dis"></param>
        public NoteEditFrm(Note note,bool dis)
        {
            InitializeComponent();
            CurrentNote = note;
            panelEx1.Enabled = dis;
            ribbonPanel1.Enabled = dis;
        }
        private Note CurrentNote { get; set; }

        private void btnsaveclose_Click(object sender, EventArgs e)
        {

            string title = txttitle.Text;
            string content = htmlEditor1.InnerHtml;

           
           
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("��������⣡");
                txttitle.Focus();
                return;

            }
            if(cmbcategory.SelectedItem==null)
            {
                MessageBox.Show("��ѡ����࣬��û�з������½���");
              
                return;
            }
            Category category = cmbcategory.SelectedItem as Category;
            try
            {
                bool remind = chkremind.Checked;
              
                
                if (CurrentNote == null)
                {
                    //�½�
                    Note note = new Note
                                    {
                                        CategoryID = category,
                                        CreateDate = DateTime.Now,
                                        ModifyDate = DateTime.Now,
                                        NoteContent = content,
                                        NoteName = title,
                                        
                                        UserID = ClsCommon.CurrentUser,
                                        IsRemind = remind
                                       
                                      
                                        
                                    };
                    if (remind) note.RemindTime = DateTime.Parse(txtremind.Text);
                    else
                        note.RemindTime =DateTime.Now;
                    ClsCommon.GetNoteService.SaveOrUpdata(note);

                    MessageBox.Show("����ɹ���");
                }
                else
                {
                    //����

                    CurrentNote.CategoryID = category;
                    CurrentNote.ModifyDate = DateTime.Now;
                    CurrentNote.NoteContent = content;
                    CurrentNote.NoteName = title;
                    CurrentNote.IsRemind = remind;
                    if (remind) CurrentNote.RemindTime = DateTime.Parse(txtremind.Text);
                    else
                        CurrentNote.RemindTime = DateTime.Now;
                    ClsCommon.GetNoteService.SaveOrUpdata(CurrentNote);
                    MessageBox.Show("����ɹ���");
                    CurrentNote = null;
                }
                SingletonForms<Notesfrm>.Instance.RefreshData();
                SingletonForms<Remindfrm>.Instance.SetData();
                ResetControl();
            }
            catch (Exception ex)
            {

                MessageBox.Show("����ʧ��" + ex.Message);
            }
          
        }
        private void ResetControl()
        {
            txttitle.Text = "";
            htmlEditor1.InnerHtml = "";
            cmbcategory.Text = "";

        }
        private void BindCategory()
        {
            cmbcategory.DataSource = ClsCommon.GetCategoryService.GetAllCategory();
            cmbcategory.ValueMember = "CategoryName";
        }
        private void NoteEditFrm_Load(object sender, EventArgs e)
        {
            if (CurrentNote != null) this.Text = CurrentNote.NoteName;
            lblcurrentname.Text = "��ǰ�û���" + ClsCommon.CurrentUser.UserName;
            BindCategory();
            if (CurrentNote != null)
                SetNotetoDategrid(CurrentNote);
        }
        private void SetNotetoDategrid(Note note)
        {
            txttitle.Text = note.NoteName;
            htmlEditor1.InnerHtml = note.NoteContent;
            cmbcategory.Text = note.CategoryID.CategoryName;
            if (note.IsRemind)
            {
                chkremind.Checked = true;
             //string rt=  note.RemindTime.ToString();//2011/11/11 11:22:00
              string rt = string.Format("{0:u}", note.RemindTime);//
                rt = rt.Replace("/", "");
                rt = rt.Replace(" ", "");
                rt = rt.Replace(":", "");
                txtremind.Text = rt;
            }
        }
       

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            htmlEditor1.SaveFilePrompt();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            htmlEditor1.OpenFilePrompt();
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            htmlEditor1.DocumentPrint();
            
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            CategoryManagementFrm frm = new CategoryManagementFrm();
            frm.ShowDialog();
            BindCategory();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (CurrentNote == null)
                return;
            if (MessageBox.Show("��ȷ��Ҫɾ���ü������ݣ�", "ȷ��", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                ClsCommon.GetNoteService.VirtualDelete(new List<Note> { CurrentNote });
                this.Close();
                SingletonForms<Notesfrm>.Instance.RefreshData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ɾ������ʧ��" + ex.Message);
            }
           
        }

        private void chkremind_CheckedChanged(object sender, EventArgs e)
        {
            if (chkremind.Checked)
                txtremind.Enabled = true;
            else if (!chkremind.Checked)
                txtremind.Enabled = false;
        }
    }
}