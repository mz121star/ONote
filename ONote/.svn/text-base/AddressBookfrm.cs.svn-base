using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ONote.Common.Data;
using ONote.Dto;
using ONote.Model;

namespace ONote
{
    public partial class AddressBookfrm : DevComponents.DotNetBar.Office2007Form
    {
        public AddressBookfrm()
        {
            InitializeComponent();
        }
        private QueryAddressBookDto _queryAddressBookDto = new QueryAddressBookDto() ;
        private void AddressBookfrm_Load(object sender, EventArgs e)
        {
            SetQuery(_queryAddressBookDto);
        }
        /// <summary>
        /// 按照现有条件刷新数据
        /// </summary>
        public void RefreshData()
        {
            SetQuery(_queryAddressBookDto);
        }
        public void SetQuery(Dto.QueryAddressBookDto queryAddressBookDto)
        {
            _queryAddressBookDto = queryAddressBookDto;
            dataGridViewX1.AutoGenerateColumns = false;
            var alladdresss = ClsCommon.GetAddressBookService.GetAllAddressBookByCondition(queryAddressBookDto);
            BindingCollection<AddressBook> addressBooks = new BindingCollection<AddressBook>();
            foreach (AddressBook address in alladdresss)
            {
                addressBooks.Add(address);
            }
            dataGridViewX1.DataSource = addressBooks;
        }

       

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.CurrentRow != null)
            {
                AddressBookEditfrm frm = new AddressBookEditfrm((dataGridViewX1.CurrentRow.DataBoundItem as AddressBook));
                frm.Show();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("您确定要删除选中的记录？", "确定", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {


                IList<AddressBook> addressBooks = new List<AddressBook>();
                DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = dataGridViewX1.SelectedRows;

                foreach (DataGridViewRow dataGridViewRow in dataGridViewSelectedRowCollection)
                {
                    addressBooks.Add(dataGridViewRow.DataBoundItem as AddressBook);
                }
                ClsCommon.GetAddressBookService.Delete(addressBooks);
                MessageBox.Show("删除联系人成功！");
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除数据时候出现异常" + ex.Message);
            }

        }
    }
}