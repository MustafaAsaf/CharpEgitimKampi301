using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharpEgitimKampi301.BusinessLayer.Abstract;
using CharpEgitimKampi301.BusinessLayer.Concrete;
using CharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct( )
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetProductWithCategory();
        }

        public void GetAll()
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll(); // Kategorileri al
            cmb_Category.DataSource = values; // ComboBox'a bağla
            cmb_Category.DisplayMember = "CategoryName"; // Görünecek isim
            cmb_Category.ValueMember = "CategoryId"; // Değer olarak CategoryId

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetProductWithCategory();
        }

        public void GetProductWithCategory()
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ProductId.Text);
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            MessageBox.Show("Silme İşlemi Başarılı");
            GetProductWithCategory();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = Convert.ToInt32(cmb_Category.SelectedValue.ToString());
            product.ProducPrice = Convert.ToDecimal(txt_ProductPrice.Text);
            product.ProductName = txt_ProductName.Text;
            product.ProductDescription = txt_Description.Text;
            product.ProductStatus = Convert.ToInt32(txt_ProductStock.Text);
            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Yapıldı");
            GetProductWithCategory();
        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ProductId.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = value;
            GetProductWithCategory();
            
            
            Console.WriteLine("Id alanı boş");
            
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ProductId.Text);
            var value = _productService.TGetById(id);
            value.CategoryId = Convert.ToInt32(cmb_Category.SelectedValue.ToString());
            value.ProductDescription = txt_Description.Text;
            value.ProducPrice = Convert.ToDecimal(txt_ProductPrice.Text);
            value.ProductStatus = Convert.ToInt32(txt_ProductStock.Text);
            value.ProductName = txt_ProductName.Text;
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme İşlemi Başarıyla Yapıldı");
            GetProductWithCategory();
            
        }


        //DataGridView'e tıklandığı zaman.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçerli bir satıra tıklanıp tıklanmadığını kontrol edin
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırı alın
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // TextBox'lara değerleri aktarın
                txt_ProductId.Text = row.Cells["ProductId"].Value.ToString();
                txt_ProductName.Text = row.Cells["ProductName"].Value.ToString();
                txt_ProductStock.Text = row.Cells["ProductStatus"].Value.ToString();
                txt_ProductPrice.Text = row.Cells["ProducPrice"].Value.ToString();
                txt_Description.Text = row.Cells["ProductDescription"].Value.ToString();

                // ComboBox için CategoryName değerini seç
                if (dataGridView1.Columns.Contains("CategoryName"))
                {
                    string categoryName = row.Cells["CategoryName"].Value?.ToString();
                    cmb_Category.SelectedIndex = cmb_Category.FindStringExact(categoryName);
                }
                else
                {
                    MessageBox.Show("CategoryName sütunu bulunamadı!");
                }

            }
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapatır
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            // Form üzerindeki tüm TextBox nesnelerini temizle
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
