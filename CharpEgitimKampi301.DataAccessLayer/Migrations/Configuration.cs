namespace CharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharpEgitimKampi301.DataAccessLayer.Context.KampContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        /*
            Configuration nedir
                Bu sınıf genellikle System.Configuration ad alanında bulunur ve uygulama dosyasındaki App.config veya Web.config
                bilgileri okumak için kullanılır. Özellikle DataAccess (Veri Erişim) katmanında sıkça kullanılır.
        */

        protected override void Seed(CharpEgitimKampi301.DataAccessLayer.Context.KampContext context)
        {
            // CharpEgitimKampi301.DataAccessLayer içinde Migrations.Configuration oluşturmak için
            /*
              View - Other Windows - Package Manager Console menüsüne gelmemiz gerekiyor.
                Orada sırasıyla önce clear ile ekranı temizleyip 
                1) enable-migrations yazıp enter dememiz gerekiyor. 
                2) update-database yazıp enter dememiz gerekiyor. 
                Burada CharpEgitimKampi301.PresentationLayer içindeki App.config dosyasındaki connection string parantezinde
                    belirtmiş olduğumuz veri tabanına Code Firts ile bizim yapmış olduğumuz veri tabanını ekleyecektir.
            */
        }
    }
}
