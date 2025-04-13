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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        BootCampTravelDbEntities db = new BootCampTravelDbEntities();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var locationId=int.Parse(txtLocationId.Text);
            var location=db.LocationTBLs.Find(locationId);
            location.City=txtCityName.Text;
            location.Country=txtCountryName.Text;
            location.Capacity=byte.Parse(nmrcCapactiy.Text.ToString());
            location.Price=int.Parse(txtPrice.Text.ToString());
            location.DayNight = txtDayNight.Text;
            location.GuideId=int.Parse(cmbGuideName.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Location updated successfuly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.LocationTBLs.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            LocationTBL location = new LocationTBL();
            location.City=txtCityName.Text;
            location.Country=txtCountryName.Text;
            location.Capacity =byte.Parse(nmrcCapactiy.Value.ToString());
            location.Price=int.Parse(txtPrice.Text.ToString());
            location.DayNight=txtDayNight.Text;
            location.GuideId=int.Parse(cmbGuideName.SelectedValue.ToString());
            db.LocationTBLs.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location added successfuly");
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guide = db.GuideTBLs.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuideName.DisplayMember = "FullName";
            cmbGuideName.ValueMember = "GuideId";
            cmbGuideName.DataSource= guide;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var locationId=int.Parse(txtLocationId.Text);
            var location = db.LocationTBLs.Find(locationId);
            db.LocationTBLs.Remove(location);
            db.SaveChanges();
            MessageBox.Show("Location remove successfuly");
        }
    }
}
