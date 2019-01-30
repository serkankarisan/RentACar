using DAL.RentACar.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RentACar.Context
{
    public class RentContext : DbContext
    {
        public RentContext() : base("RentContext")
        {
            //Migration işlemleri için DbContext(RentContext) ile Migration eşleştirilmelidir.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RentContext, Configuration>("RentContext"));
        }
        public virtual DbSet<GelirGider> GelirGider { get; set; }
        public virtual DbSet<Arac> Araclar { get; set; }
        public virtual DbSet<KasaHareket> KasaHareketler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<MusteriHareket> MusteriHareketler { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Yetki> Yetkiler { get; set; }
        public virtual DbSet<Sozlesme> Sozlesmeler { get; set; }
        public virtual DbSet<SozlesmeDetay> SozlesmeDetaylar { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }

    }
}
