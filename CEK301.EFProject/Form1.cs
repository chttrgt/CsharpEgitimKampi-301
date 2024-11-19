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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.tblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblGuide guide = new tblGuide();

            guide.GuideName = txtRehberAdi.Text;
            guide.GuideSurname = txtRehberSoyadi.Text;
            db.tblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var removeGuide = db.tblGuide.Find(id);
            db.tblGuide.Remove(removeGuide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var updateGuide = db.tblGuide.Find(id);
            updateGuide.GuideName = txtRehberAdi.Text;
            updateGuide.GuideSurname = txtRehberSoyadi.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla Güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetListById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var values = db.tblGuide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
