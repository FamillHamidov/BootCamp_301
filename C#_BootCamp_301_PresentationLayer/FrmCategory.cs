using C__BootCamp_301_BusinessLayer.Abstract;
using C__BootCamp_301_BusinessLayer.Concrete;
using C__BootCamp_301_DataAccessLayer.EntityFramework;
using C__BootCamp_301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__BootCamp_301_PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var categoryId=int.Parse(txtCategoryId.Text);
            var deletedCategory=_categoryService.TGetById(categoryId);
            _categoryService.TDelete(deletedCategory);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var categoryId=int.Parse(txtCategoryId.Text);
            var updatedCategory=_categoryService.TGetById(categoryId);
            updatedCategory.CategoryName=txtCategoryName.Text;
            updatedCategory.CategoryStatus = true;
            _categoryService.TUpdate(updatedCategory);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var categories=_categoryService.TGetAll();
            dataGridView1.DataSource = categories;
        }
        private void btnGetById_Click(object sender, EventArgs e)
        {
            var categoryId= int.Parse(txtCategoryId.Text);
            var category=_categoryService.TGetById(categoryId);
            dataGridView1.DataSource= category.ToString().FirstOrDefault();
        }

        private void rdbCategoryStatusFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbCategoryStatusTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
