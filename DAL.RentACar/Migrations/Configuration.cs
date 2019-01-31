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
                new Arac { Id = 1, Marka = "Audi", Model = "Q7", G�nl�kFiyat = 100, Tip = "Jeep", Renk = "Beyaz", Plaka = "34ERT12", AracDurumu = "Hasar Yok", YakitDurumu = "%50", Varmi = true, Silindi = false },
                new Arac { Id = 2, Marka = "Audi", Model = "A7", G�nl�kFiyat = 100, Tip = "Sedan", Renk = "Beyaz", Plaka = "34ASD12", AracDurumu = "Hasar Yok", YakitDurumu = "%75", Varmi = true, Silindi = false },
                new Arac { Id = 3, Marka = "Toyota", Model = "Corolla", G�nl�kFiyat = 100, Tip = "Sedan", Renk = "Beyaz", Plaka = "34NMB12", AracDurumu = "Hasar Yok", YakitDurumu = "%75", Varmi = true, Silindi = false }
                );
            context.GelirGider.AddOrUpdate(
                new GelirGider { Id = 1, Aciklama = "Maa� �deme", T�r = "Gider", Silindi = false },
                new GelirGider { Id = 2, Aciklama = "S�zle�me", T�r = "Gelir", Silindi = false },
                new GelirGider { Id = 3, Aciklama = "Ara� Sat��", T�r = "Gelir", Silindi = false }, 
                new GelirGider { Id = 4, Aciklama = "Ara� Vergi", T�r = "Gider", Silindi = false }, 
                new GelirGider { Id = 5, Aciklama = "Ara� Muayene", T�r = "Gider", Silindi = false },
                new GelirGider { Id = 6, Aciklama = "Ara� Di�er", T�r = "Gider", Silindi = false }
                );
            context.Kullanicilar.AddOrUpdate(
               new Kullanici { Id = 1, UserName = "rent", Password = "123",RoleId=1,PersonelId=1, Silindi = false }
               );
            context.Personeller.AddOrUpdate(
            new Personel { Id = 1,Adi = "Ali",Soyadi="U�ar",Telefon="2123114567",Maas=3000,Adres="Be�ikta� -�stanbul",Email="Ali@gmail.com", Silindi = false }
               );
            context.Yetkiler.AddOrUpdate(
            new Yetki { Id = 1, RoleName = "Y�netici"}, new Yetki { Id = 2, RoleName = "Personel" }
               );
        }
    }
}
