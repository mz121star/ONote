using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ONote.Dto;
using ONote.IService;
using ONote.Model;
using Spring.Context;
using Spring.Context.Support;

namespace ONote
{
    public partial class Form1 : Form
    {
        private Form1()
        {
            InitializeComponent();
        }

        
 
        //private static volatile Form1 instance = null;
       
     
        private void button1_Click(object sender, EventArgs e)
        {


          

            User user = new User();

            user.UserName = textBox1.Text;
            user.PassWord = textBox2.Text;
          ClsCommon.  GetUserService.SaveOrUpdata(user);

          IList<User> allUser = ClsCommon.GetUserService.GetAllUser();
            listBox1.DataSource = allUser;
            listBox1.DisplayMember = "UserName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IList<Category> allc = ClsCommon.GetCategoryService.GetAllCategory();
            listBox2.DataSource = allc;
            listBox2.DisplayMember = "CategoryName";
            IList<User> allUser = ClsCommon.GetUserService.GetAllUser();
            listBox1.DataSource = allUser;
            listBox1.DisplayMember = "UserName";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Category category = new Category();
            category.CategoryName = txtcategoryname.Text;
            ClsCommon.GetCategoryService.SaveOrUpdata(category);

            IList<Category> allc = ClsCommon.GetCategoryService.GetAllCategory();
            listBox2.DataSource = allc;
            listBox2.DisplayMember = "CategoryName";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.NoteName = txtnotename.Text;
            note.NoteContent = txtnotecontent.Text;
            note.CreateDate = DateTime.Now;
            note.ModifyDate = DateTime.Now;
            note.UserID = listBox1.SelectedItem as User;
            note.CategoryID = listBox2.SelectedItem as Category;
            ClsCommon.GetNoteService.SaveOrUpdata(note);
            dataGridView1.DataSource = ClsCommon.GetNoteService.GetAllNote();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsCommon.GetNoteService.GetNoteByCondition(new QueryNoteDto { CreateDate = dateTimePicker1.Value.ToString() });
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ClsCommon.GetNoteService.GetNoteByCondition(new QueryNoteDto { NoteContent = txtsearch.Text, CreateDate = dateTimePicker1.Value.ToString() });
        }
    }
}
