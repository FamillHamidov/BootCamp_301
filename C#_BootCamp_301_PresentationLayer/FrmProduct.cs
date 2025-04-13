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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__BootCamp_301_PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            ; InitializeComponent();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetAll();
            dataGridView1.DataSource = products;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var products = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductPrice = int.Parse(txtProductPrice.Text);
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TInsert(product);
            MessageBox.Show("Product added");

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.TGetAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var product = _productService.TGetById(id);
            product.ProductName = txtProductName.Text;
            product.ProductStock = int.Parse(txtProductStock.Text);
            product.ProductPrice = int.Parse(txtProductPrice.Text);
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            _productService.TUpdate(product);
            MessageBox.Show("Product updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var product = _productService.TGetById(id);
            _productService.TDelete(product);
            MessageBox.Show("Product deleted");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var product = _productService.TGetById(id);
            dataGridView1.DataSource = product;
        }
    }
}
