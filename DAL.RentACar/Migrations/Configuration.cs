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

            //context.Araclar.AddOrUpdate(
            //    new Arac { Id = 1, Marka = "Fiat", Model = "Doblo", G�nl�kFiyat = 100, Tip = "Cargo", Renk = "K�rm�z�", Plaka = "34DBL34", AracDurumu = "Hasar yok", YakitDurumu = "%50", Varmi = true, Silindi = false,ResimYolu="\\araclar\\doblok�rm�z�.png" },
            //    new Arac { Id = 2, Marka = "Audi", Model = "A7", G�nl�kFiyat = 150, Tip = "Sedan", Renk = "Beyaz", Plaka = "34ASD12", AracDurumu = "Hasar yok", YakitDurumu = "%75", Varmi = true, Silindi = false, ResimYolu = "\\araclar\\a7siyah.png.png" }
            //    );
            //context.GelirGider.AddOrUpdate(
            //    new GelirGider { Id = 1, Aciklama = "Maa� �deme", T�r = "Gider", Silindi = false },
            //    new GelirGider { Id = 2, Aciklama = "S�zle�me", T�r = "Gelir", Silindi = false },
            //    new GelirGider { Id = 3, Aciklama = "Ara� Sat��", T�r = "Gelir", Silindi = false }, 
            //    new GelirGider { Id = 4, Aciklama = "Ara� Vergi", T�r = "Gider", Silindi = false }, 
            //    new GelirGider { Id = 5, Aciklama = "Ara� Muayene", T�r = "Gider", Silindi = false },
            //    new GelirGider { Id = 6, Aciklama = "Ara� Di�er", T�r = "Gider", Silindi = false }
            //    );
            //context.Kullanicilar.AddOrUpdate(
            //   new Kullanici { Id = 1, UserName = "rent", Password = "123",RoleId=1,PersonelId=1, Silindi = false },
            //   new Kullanici { Id = 2, UserName = "a", Password = "1", RoleId = 2, PersonelId = 2, Silindi = false }
            //   );
            //context.Personeller.AddOrUpdate(
            //new Personel { Id = 1,Adi = "Ali",Soyadi="U�ar",Telefon="2123114567",Maas=3000,Adres="Be�ikta� -�stanbul",Email="ali@gmail.com", Silindi = false }, 
            //new Personel { Id = 2, Adi = "Ahmet", Soyadi = "Co�ar", Telefon = "2166543445", Maas = 2000, Adres = "Kartal -�stanbul", Email = "ahmet@gmail.com", Silindi = false }
            //   );
            //context.Yetkiler.AddOrUpdate(
            //new Yetki { Id = 1, RoleName = "Y�netici"}, new Yetki { Id = 2, RoleName = "Personel" }
            //   );
        }
    }
}
