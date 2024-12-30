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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory( )
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            //Datagridview içindeki tabloyu orantıladık.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txt_CategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_CategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme Başarılı");
        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_CategoryId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1.DataSource = values;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            int updateId = Convert.ToInt32(txt_CategoryId.Text);
            var updatedValue = _categoryService.TGetById(updateId);

            updatedValue.CategoryName = txt_CategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);

        }
    }
}
