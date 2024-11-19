using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEK301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.tblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.tblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId

            }).ToList();

            cbxGuide.DisplayMember = "FullName";
            cbxGuide.ValueMember = "GuideId";
            cbxGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblLocation loc = new tblLocation();
            loc.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            loc.LocationCity = txtCity.Text;
            loc.LocationCountry = txtCountry.Text;
            loc.LocationPrice = decimal.Parse(txtPrice.Text);
            loc.DayNight = txtDayNight.Text;
            loc.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());

            db.tblLocation.Add(loc);
            db.SaveChanges();

            MessageBox.Show("Ekleme İşlemi Başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var removeItem = db.tblLocation.Find(id);
            db.tblLocation.Remove(removeItem);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var updatedItem = db.tblLocation.Find(id);

            updatedItem.LocationCity = txtCity.Text;
            updatedItem.LocationCountry = txtCountry.Text;
            updatedItem.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updatedItem.LocationPrice = decimal.Parse(txtPrice.Text);
            updatedItem.DayNight = txtDayNight.Text;
            updatedItem.GuideId = int.Parse(cbxGuide.SelectedValue.ToString());

            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı!");
        }
    }
}
