using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    /// <summary>
    /// Category sınıfı sadece Category tablosuna ait değerleri tutar.
    /// </summary>
    public class Category //internal:sadece bulunduğu katmanda erişim vardır. Yani sadece Entity içinden erişim vardır.
    {
        public int CategoryId { get; set; } //Codefist için tablo sütunları yazılırken sınıf adıyla aynı olmalı.(Category)
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }


        /*
         Category sınıfımızı Product sınıfımızla ilişkilendirmiştik.
            Bir categoride birden fazla ürün olabileceği için 
            ilişkimizde List kullandık.
         */
        public List<Product> Products { get; set; }

        /*
          Order sınıfıyla Categori sınıfını ilişkilendirdik.
            Bir kategoride birden fazla Order(sipariş) olabileceği
            için ilişkimizde List kullandık.
         */
        public List<Order> Orders { get; set; }
    }
}
