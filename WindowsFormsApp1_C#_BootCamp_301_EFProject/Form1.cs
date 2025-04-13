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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BootCampTravelDbEntities db = new BootCampTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.GuideTBLs.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GuideTBL guide = new GuideTBL();
            guide.GuideName = txtGuideName.Text;
            guide.GuideSurname = txtGuideSurname.Text;
            db.GuideTBLs.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide added succesfuly");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtGuideId.Text);
            var guide = db.GuideTBLs.Find(id);
            db.GuideTBLs.Remove(guide);
            db.SaveChanges();
            MessageBox.Show("Guide remove succesfuly");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtGuideId.Text);
            var guide = db.GuideTBLs.Find(id);
            guide.GuideName=txtGuideName.Text;
            guide.GuideSurname=txtGuideSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide update successuly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtGuideId.Text);
            var guide=db.GuideTBLs.Where(x=>x.GuideId==id).ToList();
            dataGridView1.DataSource = guide;
        }
    }
}
