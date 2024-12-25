using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }

        /*Hangi ürünü sattığımız bilmek için Product sınıfıyla(tablosuyla) ilişki kurduk*/
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; } //Ürünün sipariş adedi
        public decimal UnitPrice { get; set; } //Birim Adedi
        public decimal TotalPrice { get; set; } //Toplam fiyat

        //Bu ürün kime satıldı
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }//Müşterinin diğer bilgilerine erişmek için tanımladık
    }
}
