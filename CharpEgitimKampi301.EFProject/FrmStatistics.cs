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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private EgitimKampiEFTravelDbEntities database = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam Lokasyon Sayısı
            lbl_locationCount.Text = database.Location.Count().ToString();

            //Toplam Kapasite
            lbl_sumCapacity.Text = database.Location.Sum(x => x.Capacity).ToString();

            //Rehber Sayısı
            lbl_guideCount.Text = database.Guide.Count().ToString();

            //Ortalama Kapasite
            lbl_avgCapacity.Text = database.Location.Average(x => x.Capacity).ToString();

            //Ortalama Tur Fiyatı
            lbl_avgLocationPrice.Text = database.Location.Average(x => x.Price).ToString() + " ₺";

            //Eklenen Son Ülke
            int lastCountryId = database.Location.Max(x => x.LocationId);
            lbl_lastCountry.Text = database.Location.Where(x => x.LocationId == lastCountryId).Select(y =>
                y.Country).FirstOrDefault();

            //Kapadokya Tur Kapasitesi
            lbl_KapadokyaCapacity.Text = database.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity)
                .FirstOrDefault().ToString();

            //Türkiye Kapasitesi Ortalaması
            lbl_avgTurkey.Text =
                database.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            //Roma Gezisi Rehberi
            var romeRehberId = database.Location
                .Where(x => x.City == "Roma")
                .Select(x => x.GuideId)
                .FirstOrDefault();

            lbl_RomaGuide.Text = database.Guide
                .Where(x => x.GuideId == romeRehberId)
                .Select(y => y.GuideName + " " + y.GuideSurname)
                .FirstOrDefault()
                ?.ToString(); // Null kontrolü için.

            //En Yüksek Kapasiteli Tur
            var maxCapacity = database.Location.Max(x => x.Capacity);
            lbl_maxCapacityLocation.Text = database.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City)
                .FirstOrDefault().ToString();


            //En Pahalı Tur
            var maxPrice = database.Location.Max(x => x.Price);
            lbl_enPahaliTur.Text = database.Location.Where(x => x.Price == maxPrice).Select(y => y.City)
                .FirstOrDefault().ToString();


            //Asaf Çeliğin Tur Sayısı
            var guideIdByAsafCelik = database.Guide.Where(x => x.GuideName == "Asaf" && x.GuideSurname == "Çelik")
                .Select(y => y.GuideId).FirstOrDefault();
            lbl_AsafCelikTur.Text = database.Location.Where(x => x.GuideId == guideIdByAsafCelik).Count().ToString();

        }
    }
}
