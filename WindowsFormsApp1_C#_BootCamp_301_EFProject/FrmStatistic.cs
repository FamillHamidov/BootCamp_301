using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_C__BootCamp_301_EFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        BootCampTravelDbEntities db=new BootCampTravelDbEntities();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.LocationTBLs.Count().ToString();
            lblGuideCount.Text=db.GuideTBLs.Count().ToString();

            var lastAddedLocationId = db.LocationTBLs.Max(x => x.LocationId);
            lblLastAddedLocation.Text=db.LocationTBLs.Where(x=>x.LocationId==lastAddedLocationId).Select(y=>y.City).FirstOrDefault().ToString();

            var maxCapacityLocation = db.LocationTBLs.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.LocationTBLs.Where(x => x.Capacity == maxCapacityLocation).Select(y => y.City).FirstOrDefault().ToString();

            var maxPriceLocation=db.LocationTBLs.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.LocationTBLs.Where(x => x.Price == maxPriceLocation).Select(y => y.City).FirstOrDefault().ToString();

            lblAzerbaijanLocationCount.Text = db.LocationTBLs.Where(x => x.Country == "Azerbaijan").Count().ToString();

            lblAvgCapacityLocation.Text=db.LocationTBLs.Average(x=>x.Capacity).ToString();

            lblAvgPriceLocation.Text=db.LocationTBLs.Average(x=>x.Price).ToString();

            lblCountryWithMaxLocation.Text=db.LocationTBLs.Select(x=>x.Country).FirstOrDefault().ToString();

            var guideId=db.GuideTBLs.Where(x=>x.GuideName=="Tural" && x.GuideSurname=="Hemidli").Select(y=>y.GuideId).FirstOrDefault();
            lblTuralHemidliLocation.Text = db.LocationTBLs.Where(x => x.GuideId == guideId).Count().ToString();

            var minPriceLocation = db.LocationTBLs.Min(x => x.Price);
            lblMinPriceLocation.Text=db.LocationTBLs.Where(x=>x.Price== minPriceLocation).Select(x=>x.City).FirstOrDefault().ToString();

            var minCapacityLocation=db.LocationTBLs.Min(x=>x.Capacity);
            lblMinCapacityLocation.Text = db.LocationTBLs.Where(x=>x.Capacity==minCapacityLocation).Select(x=>x.City).FirstOrDefault().ToString();
        }
    }
}
