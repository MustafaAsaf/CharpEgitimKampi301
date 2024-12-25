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
    public partial class form_lokasyonIslemleri : Form
    {
        public form_lokasyonIslemleri()
        {
            InitializeComponent();
        }

        private EgitimKampiEFTravelDbEntities dataBase = new EgitimKampiEFTravelDbEntities();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void form_lokasyonIslemleri_Load(object sender, EventArgs e)
        {
            RehberleriGetir();
            Listele();
        }

        public void RehberleriGetir()
        {
            var values = dataBase.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbBox_Rehber.DisplayMember = "FullName";
            cmbBox_Rehber.ValueMember = "GuideId";
            cmbBox_Rehber.DataSource = values;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Location location = new Location();

            location.Capacity = Convert.ToByte(numericUpDown_Kapasite.Value.ToString());
            location.City = txt_Sehir.Text;
            location.Country = txt_Ulke.Text;
            location.Price = Convert.ToDecimal(txt_Fiyat.Text);
            location.DayNight = txt_GunGece.Text;
            location.GuideId =Convert.ToInt32(cmbBox_Rehber.SelectedValue.ToString());

            dataBase.Location.Add(location);
            dataBase.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            Listele();
        }

        public void Listele()
        {
            var values = dataBase.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_RehberId.Text);
            var deletedValue = dataBase.Location.Find(id);
            dataBase.Location.Remove(deletedValue);
            dataBase.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı !");
            Listele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_RehberId.Text);
            var updateValue = dataBase.Location.Find(id);

            updateValue.DayNight = txt_GunGece.Text;
            updateValue.Price = decimal.Parse(txt_Fiyat.Text);
            updateValue.Capacity = byte.Parse(numericUpDown_Kapasite.Value.ToString());
            updateValue.City = txt_Sehir.Text;
            updateValue.Country = txt_Ulke.Text;
            updateValue.GuideId = Convert.ToInt32(cmbBox_Rehber.SelectedValue.ToString());
            dataBase.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            Listele();
        }

        private void btn_Id_ye_Gore_Getir_Click(object sender, EventArgs e)
        {

        }
    }
}
