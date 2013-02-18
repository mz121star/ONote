using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Common.Forms;
using ONote.Model;

namespace ONote
{
    public partial class AddressBookEditfrm : DevComponents.DotNetBar.Office2007Form
    {
        public AddressBookEditfrm()
        {
            InitializeComponent();
        }

        private AddressBook _addressBook;
        public AddressBookEditfrm(AddressBook addressBook)
        {
            InitializeComponent();
            _addressBook = addressBook;
        }

        private void AddressBookEditfrm_Load(object sender, EventArgs e)
        {
            if (_addressBook != null)
            {
                this.Text = _addressBook.Name;
                 txtaddress.Text= _addressBook.Address;
                txtcompany.Text=_addressBook.Company;
                 txtdepartment.Text=_addressBook.Department;
              txtmail.Text=_addressBook.Email;
               txtmobile.Text=_addressBook.Mobile ;
               txtname.Text= _addressBook.Name ;
               txtphone.Text= _addressBook.Phone ;
               txtQQ.Text = _addressBook.QQ;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            lblname.Text = txtname.Text;
        }

        private void txtcompany_TextChanged(object sender, EventArgs e)
        {
            lblcompany.Text = txtcompany.Text;
        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {
            lbldepartment.Text = txtdepartment.Text;
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            lblemail.Text = txtmail.Text;
        }

        private void txtQQ_TextChanged(object sender, EventArgs e)
        {
            lblqq.Text = txtQQ.Text;
        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {
            lblmobile.Text = txtmobile.Text;
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            lblphone.Text = txtphone.Text;
        }
        private void clearcontrol()
        {
              txtaddress.Text="";
              txtcompany.Text = "";
              txtdepartment.Text = "";
              txtmail.Text = "";
              txtmobile.Text = "";
              txtname.Text = "";
              txtphone.Text = "";
              txtQQ.Text = "";
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            try
            {
                if (_addressBook == null)
                {
                    ClsCommon.GetAddressBookService.SaveOrUpdata(new AddressBook
                                                                     {
                                                                         Address = txtaddress.Text,
                                                                         Company = txtcompany.Text,
                                                                         Department = txtdepartment.Text,
                                                                         Email = txtmail.Text,
                                                                         Mobile = txtmobile.Text,
                                                                         Name = txtname.Text,
                                                                         Phone = txtphone.Text,
                                                                         QQ = txtQQ.Text,
                                                                         UserID = ClsCommon.CurrentUser
                                                                     });
                    _addressBook = null;
                    MessageBox.Show("新增操作成功！");
                    clearcontrol();
                }
                    
                else
                {

                    _addressBook.Address = txtaddress.Text;
                    _addressBook.Company = txtcompany.Text;
                    _addressBook.Department = txtdepartment.Text;
                    _addressBook.Email = txtmail.Text;
                    _addressBook.Mobile = txtmobile.Text;
                    _addressBook.Name = txtname.Text;
                    _addressBook.Phone = txtphone.Text;
                    _addressBook.QQ = txtQQ.Text;
                    _addressBook.UserID = ClsCommon.CurrentUser;
                    ClsCommon.GetAddressBookService.SaveOrUpdata(_addressBook);
                    _addressBook = null;
                    MessageBox.Show("更新操作成功！");
                    clearcontrol();
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("操作失败！" + ex.Message);
            }
            SingletonForms<AddressBookfrm>.Instance.RefreshData();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出编辑？", "确定", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            this.Close();
        }
    }
}