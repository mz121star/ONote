using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.Schedule.Model;
using ONote.Common.Forms;
using ONote.Dto;
using ONote.Model;

namespace ONote
{
    public partial class Form2 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// 显示MDI窗体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void ShowForm<T>()
    where T : Form, new()
        {
            T f = SingletonForms<T>.Instance;
            f.MdiParent = this;
            f.Show();
          f.WindowState = FormWindowState.Maximized;
            f.BringToFront();
        }  
      

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowForm<Notesfrm>();
            SingletonForms<Notesfrm>.Instance.SetQuery(new QueryNoteDto { CreateDate = DateTime.Now.Date.ToString() });
        }

      
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            NoteEditFrm frm = new NoteEditFrm();
            frm.Show();
             
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            ShowForm<Notesfrm>();
            SingletonForms<Notesfrm>.Instance.SetQuery(new QueryNoteDto() );
          
         
        }

       
        private void switchButtonItem1_ValueChanged(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = !switchButtonItem1.Value;
            navigationPane1.Expanded = !switchButtonItem1.Value;
        }

       

        

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txtsearchbox_LostFocus(object sender, EventArgs e)
        {
             
            if (txtsearchbox.Text.Trim() == "")
            {
                txtsearchbox.Text = "搜索记事内容";
            }
        }

        private void txtsearchbox_GotFocus(object sender, EventArgs e)
        {
            
            if (txtsearchbox.Text == "搜索记事内容")
            {
                txtsearchbox.Text = "";
            }
        }

        private void txtsearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                search();
        }
      private void search()
      {
          if (txtsearchbox.Text == null)
              return;

          ShowForm<Notesfrm>();

          SingletonForms<Notesfrm>.Instance.SetQuery(new QueryNoteDto { NoteContent = txtsearchbox.Text.Trim() });
      }

   
      private void btnnewcontact_Click(object sender, EventArgs e)
      {
          AddressBookEditfrm frm = new AddressBookEditfrm();
          frm.Show();
      }

      private void btncontacts_Click(object sender, EventArgs e)
      {
          ShowForm<AddressBookfrm>();
      }

      private void 新建记事ToolStripMenuItem_Click(object sender, EventArgs e)
      {
          NoteEditFrm frm = new NoteEditFrm();
          frm.Show();
      }

      private void 新建联系人ToolStripMenuItem_Click(object sender, EventArgs e)
      {
          AddressBookEditfrm frm = new AddressBookEditfrm();
          frm.Show();
      }

      private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
      {
          
          Application.Exit();
          
      }
      protected override void OnClosing(CancelEventArgs e)
      {
        
          base.OnClosing(e);
          e.Cancel = true;
          this.Hide();
      }
    

      private void toolStripMenuItem3_Click(object sender, EventArgs e)
      {
          this.Show();
          this.WindowState = FormWindowState.Maximized;
      }

     

      private void notifyIcon1_DoubleClick(object sender, EventArgs e)
      {
          this.Show();
          this.WindowState = FormWindowState.Maximized;
      }

    
      
        //public void SetNoCompleteRemin()
        //{
        //    cmbremind.DataSource = ClsCommon.GetNoteService.GetNoCompleteRemind();
        //    cmbremind.ValueMember = "NoteName";
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            RemindService.Remind();
        }

        private void monthCalendarAdv1_ItemClick_1(object sender, EventArgs e)
        {
            ShowForm<Notesfrm>();
            DateTime date = monthCalendarAdv1.SelectedDate;

            SingletonForms<Notesfrm>.Instance.SetQuery(new QueryNoteDto { CreateDate = date.ToString() });
        }

        private void buttonItem9_Click_1(object sender, EventArgs e)
        {
            ShowForm<AddressBookfrm>();

        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            ShowForm<Remindfrm>();
            SingletonForms<Remindfrm>.Instance.SetData();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            ShowForm<Notesfrm>();
            SingletonForms<Notesfrm>.Instance.SetQuery(new QueryNoteDto { CreateDate = DateTime.Today.ToString() });
        }

        private void btnrevert_Click(object sender, EventArgs e)
        {
            ShowForm<Recyclefrm>();
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            //string appDomain = ClsCommon.GetAppDomain;
            try
            {

           
            string timespan = DateTime.Now.ToString();
            timespan=timespan.Replace(@"\","");
            timespan = timespan.Replace(@":", "");
            timespan = timespan.Replace(@"/", "");
            timespan = timespan.Replace(@" ", "");
            timespan = timespan.Replace(@"-", "");
            Common.Files.BackUp.CreateDirectory(ClsCommon.GetBackupDomain);
            Common.Files.BackUp.BackUpFile(ClsCommon.GetAppDomain + "ONote.sdf",
                                           ClsCommon.GetBackupDomain+"\\" + timespan + ".sdf");
                MessageBox.Show("数据库备份到" + ClsCommon.GetBackupDomain + "成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show("备份数据库失败，详细原因如下：" + ex.Message);
            }
        }

        private void btndbrevert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("数据库恢复操作请谨慎使用！如需恢复数据操作，请联系开发人员！");
        }
    }
}