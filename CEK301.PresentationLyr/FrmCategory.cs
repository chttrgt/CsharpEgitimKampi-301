using CEK301.BusinessLayer.Abstract;
using CEK301.BusinessLayer.Concrete;
using CEK301.DataAccessLayer.EntityFramework;
using CEK301.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEK301.PresentationLyr
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnListCategory_Click(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            dataGridView1.DataSource = categories;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.CategoryName = txtCategoryName.Text;
            cat.CategoryStatus = true;
            _categoryService.TInsert(cat);
            MessageBox.Show("Category Added");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var cat = _categoryService.TGetById(id);
            _categoryService.TDelete(cat);
            MessageBox.Show("Category Deleted");
        }

        private void btnGetCategoryById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var cat = _categoryService.TGetById(id);
            dataGridView1.DataSource = cat;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtCategoryId.Text);
            var category = _categoryService.TGetById(id);
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = catStatus;
            _categoryService.TUpdate(category);
            MessageBox.Show("Category Updated!!!");
        }

        bool catStatus = false;
        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {
            catStatus = true;
        }

        private void rdbPassive_CheckedChanged(object sender, EventArgs e)
        {
            catStatus = false;
        }
    }
}
