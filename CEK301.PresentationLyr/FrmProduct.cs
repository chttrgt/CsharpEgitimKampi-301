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
            // silme işlemi
        }
    }
}
