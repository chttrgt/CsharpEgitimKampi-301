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
    public partial class FrmProduct : Form
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            var products = productManager.TGetAll();
            dataGridView1.DataSource = products;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var products = productManager.TGetProductsByCategory();
            dataGridView1.DataSource = products;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = productManager.TGetById(id);
            productManager.TDelete(product);
            MessageBox.Show("Product Deleted");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.ProductDescription = txtProductDescription.Text;
            product.CategoryId = Convert.ToInt32(cbxCategroy.SelectedValue.ToString());

            productManager.TInsert(product);
            MessageBox.Show("Product Added");
        }

        private void btnGetCategoryById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = productManager.TGetById(id);
            dataGridView1.DataSource = product;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductId.Text);
            var product = productManager.TGetById(id);
            product.ProductName = txtProductName.Text;
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductStock = Convert.ToInt32(txtProductStock.Text);
            product.ProductDescription = txtProductDescription.Text;
            product.CategoryId = Convert.ToInt32(cbxCategroy.SelectedValue.ToString());
            productManager.TUpdate(product);
            MessageBox.Show("Product Updated!!!");
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

            var values = categoryManager.TGetAll();
            cbxCategroy.DataSource = values;
            cbxCategroy.DisplayMember = "CategoryName";
            cbxCategroy.ValueMember = "CategoryId";

        }
    }
}
