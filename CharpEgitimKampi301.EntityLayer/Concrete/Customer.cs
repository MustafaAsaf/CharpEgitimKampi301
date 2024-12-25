using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int  CustomerId { get; set; } //Id'si
        public string CustomerName { get; set; } // Müşteri adı
        public string CustomerSurname { get; set; } // Müşteri soyadı
        public string CustomerDistirct { get; set; } // Müşteri ilçesi
        public string CustomerCity { get; set; } // Müşteri şehri

        //Müşterinin verdiği siparişler.
        public List<Order> Orders { get; set; }

        public bool CustomerStatus { get; set; }
    }
}


/*
  SOLID
Single Responsibility: Tek sorumluluk ilkesi. Bir metot,sınıf,internface bağlı bulunduğu alanda tek bir işlem yapsın. Mesela bir metot hem matematik işlemi yapıp hemde veri kaydetmemeli.
O:
L:
I:
D:

 */
