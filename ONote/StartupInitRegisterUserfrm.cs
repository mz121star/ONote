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
    public partial class StartupInitRegisterUserfrm : DevComponents.DotNetBar.Office2007Form
    {
        public StartupInitRegisterUserfrm()
        {
            InitializeComponent();
        }
        public StartupInitRegisterUserfrm(string info)
        {
            InitializeComponent();
            lblinfo.Text = info;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuname.Text.Trim()) || string.IsNullOrEmpty(txtpwd.Text.Trim()) || string.IsNullOrEmpty(txtconfirm.Text.Trim()))
            {
                MessageBox.Show("信息输入不完整！");

                return;
            }
            if(txtpwd.Text.Trim()!=txtconfirm.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            try
            {
                ClsCommon.GetUserService.SaveOrUpdata(new User { UserName = txtuname.Text.Trim(), PassWord = txtpwd.Text });
                MessageBox.Show("成功！请用此用户名密码登陆！");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("新增用户失败" + ex.Message);
            }
            
        }
    }
}