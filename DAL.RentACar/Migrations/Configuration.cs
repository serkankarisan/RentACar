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
            //    new Arac { Id = 1, Marka = "Fiat", Model = "Doblo", GünlükFiyat = 100, Tip = "Cargo", Renk = "Kýrmýzý", Plaka = "34DBL34", AracDurumu = "Hasar yok", YakitDurumu = "%50", Varmi = true, Silindi = false,ResimYolu="\\araclar\\doblokýrmýzý.png" },
            //    new Arac { Id = 2, Marka = "Audi", Model = "A7", GünlükFiyat = 150, Tip = "Sedan", Renk = "Beyaz", Plaka = "34ASD12", AracDurumu = "Hasar yok", YakitDurumu = "%75", Varmi = true, Silindi = false, ResimYolu = "\\araclar\\a7siyah.png.png" }
            //    );
            //context.GelirGider.AddOrUpdate(
            //    new GelirGider { Id = 1, Aciklama = "Maaþ Ödeme", Tür = "Gider", Silindi = false },
            //    new GelirGider { Id = 2, Aciklama = "Sözleþme", Tür = "Gelir", Silindi = false },
            //    new GelirGider { Id = 3, Aciklama = "Araç Satýþ", Tür = "Gelir", Silindi = false }, 
            //    new GelirGider { Id = 4, Aciklama = "Araç Vergi", Tür = "Gider", Silindi = false }, 
            //    new GelirGider { Id = 5, Aciklama = "Araç Muayene", Tür = "Gider", Silindi = false },
            //    new GelirGider { Id = 6, Aciklama = "Araç Diðer", Tür = "Gider", Silindi = false }
            //    );
            //context.Kullanicilar.AddOrUpdate(
            //   new Kullanici { Id = 1, UserName = "rent", Password = "123",RoleId=1,PersonelId=1, Silindi = false },
            //   new Kullanici { Id = 2, UserName = "a", Password = "1", RoleId = 2, PersonelId = 2, Silindi = false }
            //   );
            //context.Personeller.AddOrUpdate(
            //new Personel { Id = 1,Adi = "Ali",Soyadi="Uçar",Telefon="2123114567",Maas=3000,Adres="Beþiktaþ -Ýstanbul",Email="ali@gmail.com", Silindi = false }, 
            //new Personel { Id = 2, Adi = "Ahmet", Soyadi = "Coþar", Telefon = "2166543445", Maas = 2000, Adres = "Kartal -Ýstanbul", Email = "ahmet@gmail.com", Silindi = false }
            //   );
            //context.Yetkiler.AddOrUpdate(
            //new Yetki { Id = 1, RoleName = "Yönetici"}, new Yetki { Id = 2, RoleName = "Personel" }
            //   );
        }
    }
}
