namespace CharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up() //Veri tabanında değişiklik yapmak
        {
            //Customer sınıfına(tablosuna) sonradan yani veri tabanını oluşturduktan sonra CustomerStatus adında bir alan daha eklemek istiyoruz.
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down() //İşlemi geri alma
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }

    /*
        Customer sınıfımıza(tablosuna) yeni bir alan ekledikten sonra tekrardan
        Package Manager Console'dan oluşturulmamışsa 1 adet mig sınıfını oluşturmamız gerekiyor.
            add-migration mig1 kodunu yazıp enter dedikten sonra mig dosyamız oluşmaktadır.
            mig sınıfımız bizim sonradan yaptığımız düzenlemeleri tutan bir sınıftır.
            add-migration mig1 yazıp mig sınıfını oluşturduktan sonra update-database ile tekrardan veri tabanını güncelliyoruz.

    */
}
