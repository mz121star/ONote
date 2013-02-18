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
    public partial class CategoryManagementFrm : DevComponents.DotNetBar.Office2007Form
    {
        public CategoryManagementFrm()
        {
            InitializeComponent();
        }

        private void CategoryManagementFrm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCommon.GetCategoryService.SaveOrUpdata(new Category {CategoryName = txtcategory.Text.Trim()});
                BindData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("新增分类失败" + ex.Message);
            }
        }
        private  void BindData()
        {
            treeCategory.DataSource = ClsCommon.GetCategoryService.GetAllCategory();
            treeCategory.ValueMember = "CategoryName";
        }

        private void treeCategory_AfterCellEdit(object sender, DevComponents.AdvTree.CellEditEventArgs e)
        {
        
            Rectangle rectangle = e.Cell.Bounds;
            MessageBox.Show(e.Cell.Text);
        }
    }
}