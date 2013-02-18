using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Model;

namespace ONote
{
    public partial class LoginFrm : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtuser.Text)||string.IsNullOrEmpty(txtuser.Text))
                return;
            User userLogin = ClsCommon.GetUserService.UserLogin(txtuser.Text, txtpwd.Text);
            if(userLogin!=null)
            {
                if (chkrember.Checked)
                {
                    Common.Configs.AppConfigManager.UpdateAppConfig("Uname", userLogin.UserName);
                    Common.Configs.AppConfigManager.UpdateAppConfig("Upwd", userLogin.PassWord);
                    Common.Configs.AppConfigManager.UpdateAppConfig("aoutlogin", "1");
                }
                else
                {
                    Common.Configs.AppConfigManager.UpdateAppConfig("Uname", "");
                    Common.Configs.AppConfigManager.UpdateAppConfig("Upwd", "");
                    Common.Configs.AppConfigManager.UpdateAppConfig("aoutlogin", "2");
                }
                ClsCommon.CurrentUser = userLogin;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("µ«¬º ß∞‹£¨«Î÷ÿ ‘£°");

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            string appSetting = ConfigurationManager.AppSettings["aoutlogin"];
            if(appSetting=="1")
            {
                txtuser.Text = ConfigurationManager.AppSettings["Uname"];
                txtpwd.Text = ConfigurationManager.AppSettings["Upwd"];
                chkrember.Checked = true;
            }

        }
    }
}