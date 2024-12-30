using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; } //Ürün Id'si
        public string ProductName { get; set; } //Ürün adı
        public int ProductStatus { get; set; } //Ürün durumu
        public decimal ProducPrice { get; set; } //Ürün açıklaması
        public string ProductDescription { get; set; } //Ürün açıklaması



        public int CategoryId { get; set; } //Kategori Id'si , Foreign Key
        /*
          Bir ürünün kategori bilgisine ulaşmak için Category sınıfıyla 
            Product sınıfını ilişkilendirdik. Her bir ürünün bir tane kategorisi olur.
          Context.Product.Category.CategoryName ulaşmak istediğimiz yer CategoryName
         */
        public virtual Category Category { get; set; }

    }
}
