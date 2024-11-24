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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        #region Toplam Lokasyon Sayısı
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.tblLocation.Count().ToString();
            lblTotalCapacity.Text = db.tblLocation.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.tblGuide.Count().ToString();

            double avg_capacity = double.Parse(db.tblLocation.Average(x => x.LocationCapacity).ToString());
            lblAverageCount.Text = avg_capacity.ToString("0.00");

            decimal avg_price = decimal.Parse(db.tblLocation.Average(x => x.LocationPrice).ToString());
            lblAverageLocationPrice.Text = avg_price.ToString("N2") + " ₺";

            int lastCountryId = db.tblLocation.Max(x => x.LocationId);
            lblLastCountery.Text = db.tblLocation.Where(x => x.LocationId == lastCountryId).Select(x => x.LocationCountry).FirstOrDefault();

            lblKapadokyaTurSayisi.Text = db.tblLocation.Where(x => x.LocationCity == "Kapadokya").Select(x => x.LocationCapacity).FirstOrDefault().ToString();

            lblTurCapAvg.Text = db.tblLocation.Where(x => x.LocationCountry == "Türkiye").Average(x => x.LocationCapacity).ToString();

            int guideId = (int)db.tblLocation.Where(x => x.LocationCity == "Roma").Select(x => x.GuideId).FirstOrDefault();
            lblRomeGuide.Text = db.tblGuide.Where(x => x.GuideId == guideId).Select(x => x.GuideName).FirstOrDefault();

            var maxCap = db.tblLocation.Max(x => x.LocationCapacity);
            lblMaxCapLoc.Text = db.tblLocation.Where(x => x.LocationCapacity == maxCap).Select(x => x.LocationCity).FirstOrDefault();

            var expensiveLoc = db.tblLocation.Max(x => x.LocationPrice);
            lblExpensiveLoc.Text = db.tblLocation.Where(x => x.LocationPrice == expensiveLoc).Select(x => x.LocationCity).FirstOrDefault();

            lblCihatturgutLocCount.Text = db.tblLocation.Count(x => x.GuideId == 5).ToString();
        }
        #endregion
    }
}
