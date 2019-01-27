namespace DAL.RentACar.Migrations
{
    using DAL.RentACar.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.RentACar.Context.RentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.RentACar.Context.RentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Araclar.AddOrUpdate(
                new Arac { Id = 1,Marka="Audi", Model = "Q7", GünlükFiyat = 100, Tip = "Jeep", Renk = "Beyaz", Plaka = "34ERT12", AracDurumu = "Hasar Yok", YakýtDurumu = "%50", Varmi = true, Silindi = false },
                new Arac { Id = 2,Marka="Toyota", Model = "A7", GünlükFiyat = 100, Tip = "Sedan", Renk = "Beyaz", Plaka = "34ASD12", AracDurumu = "Hasar Yok", YakýtDurumu = "%75", Varmi = true, Silindi = false }
                
                );
        }
    }
}
