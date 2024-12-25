using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharpEgitimKampi301.EntityLayer.Concrete;

namespace CharpEgitimKampi301.DataAccessLayer.Context
{
    //Veri tabanına yansıyacak olan bütün sınıflar burada yer alıcak.
    public class KampContext: DbContext
    {
        //Category:Sınıf --- Categories:Tablo
        public DbSet <Category> Categories{ get; set; }

        //Product:Sınıf --- Products:Tablo
        public DbSet <Product>Products { get; set; }

        //Order:Sınıf --- Orders:Tablo
        public DbSet<Order> Orders { get; set; }

        //Customer:Sınıf --- Customers:Tablo
        public DbSet<Customer> Customers { get; set; }

        //Admin:Sınıf --- Admins:Tablo
        public DbSet<Admin>Admins { get; set; }
    }
}
