using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharpEgitimKampi301.EFProject
{
    public partial class form_rehberIslemleri : Form
    {
        public form_rehberIslemleri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities dataBase = new EgitimKampiEFTravelDbEntities();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            var values = dataBase.Guide.ToList(); //Guide tablosundaki bütün verileri getir.
            dataGridView1.DataSource = values;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(); //Guide sınıfından(tablosundan) nesne türettik.
            guide.GuideName = txt_RehberAdi.Text;
            guide.GuideSurname = txt_RehberSoyadi.Text;
            dataBase.Guide.Add(guide); //dataBase içindeki Guide tablosuna ekle
            dataBase.SaveChanges();
            MessageBox.Show("Rehber Eklenmiştir.");
        }

        //Silme işlemi ID'ye göre yapılmaktadır.
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_RehberId.Text);
            var removeValue = dataBase.Guide.Find(id);
            dataBase.Guide.Remove(removeValue);
            dataBase.SaveChanges();
            MessageBox.Show("Rehber Silinmiştir !");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_RehberId.Text);
            var updateValue = dataBase.Guide.Find(id);
            updateValue.GuideName = txt_RehberAdi.Text;
            updateValue.GuideSurname = txt_RehberSoyadi.Text;
            dataBase.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btn_Id_ye_Gore_Getir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_RehberId.Text);
            var values = dataBase.Guide.Where(x => x.GuideId == id).ToList(); //where içindeki şarta göre ToList yap.
            dataGridView1.DataSource = values;
        }
    }
}
