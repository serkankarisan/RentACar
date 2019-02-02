using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class MusteriRepository : IMusteriRepository
    {
        public bool MusteriEkle(Musteri M)
        {
            bool Sonuc = false;
            Genel.ent.Musteriler.Add(M);
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public Musteri MusteriGetirById(int ID)
        {
            Musteri musteri = (from m in Genel.ent.Musteriler
                                      where m.Id == ID
                                      select m).FirstOrDefault();

            return musteri;
        }

        public bool MusteriGuncelle(Musteri M)
        {
            //arakatman sorununu çözmek için değiştirmeyi burada yaptım.
            bool Sonuc = false;
            Musteri bulunan = MusteriGetirById(M.Id);
            bulunan.Adi = M.Adi;
            bulunan.Soyadi = M.Soyadi;
            bulunan.Telefon = M.Telefon;
            bulunan.Email = M.Email;
            bulunan.EhliyetNo = M.EhliyetNo;
            bulunan.EhliyetTarihi = M.EhliyetTarihi;
            bulunan.Adres = M.Adres;
            bulunan.Cinsiyet = M.Cinsiyet;
            bulunan.DogumTarihi = M.DogumTarihi;
            bulunan.Silindi = M.Silindi;
            bulunan.TcKimlikNo = M.TcKimlikNo;
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool MusteriKontrol(Musteri yeni)
        {
            return Convert.ToBoolean(Genel.ent.Musteriler.Where(m => m.TcKimlikNo == yeni.TcKimlikNo).ToList().Count);
        }
        public bool MusteriEmailKontrol(string mail)
        {
            return Convert.ToBoolean(Genel.ent.Musteriler.Where(m => m.Email == mail).ToList().Count);
        }

        public List<Musteri> MusteriListele()
        {
            return Genel.ent.Musteriler.Where(m => m.Silindi == false).ToList();
        }

        public bool MusteriSil(int ID)
        {
            bool Sonuc = false;
            Musteri silinen = (from m in Genel.ent.Musteriler
                                      where m.Id == ID
                                      select m).FirstOrDefault();
            silinen.Silindi = true;
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public bool MusteriSil(Musteri M)
        {
            bool Sonuc = false;
            Genel.ent.Musteriler.Remove(M);
            try
            {
                Genel.ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }

        public List<Musteri> MusteriSorgula(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            return Genel.ent.Musteriler.Where(m => m.Silindi == false && m.Adi.StartsWith(Ad) && m.Soyadi.StartsWith(Soyad) && m.TcKimlikNo.StartsWith(TCKNo) && m.EhliyetNo.StartsWith(EhliyetNo)).ToList();
        }

        //public List<Musteri> MusteriSorgula(string Ad, string Soyad, string TCKNo, string EhliyetNo,DateTime baslangic,DateTime bitis)
        //{
        //    return Genel.ent.Musteriler.Where(m => m.Silindi == false && m.Adi.Substring(0, Ad.Length) == Ad.Substring(0, Ad.Length) && m.Soyadi.Substring(0, Soyad.Length) == Soyad.Substring(0, Soyad.Length) && m.TcKimlikNo.Substring(0, TCKNo.Length) == TCKNo.Substring(0, TCKNo.Length) && m.EhliyetNo.Substring(0, EhliyetNo.Length) == EhliyetNo.Substring(0, EhliyetNo.Length) && ).ToList();
        //}
        public bool MusteriKontrolFromDegistir(Musteri yeni)
        {
            return Convert.ToBoolean(Genel.ent.Musteriler.Where(m => m.TcKimlikNo == yeni.TcKimlikNo && m.Id != yeni.Id).ToList().Count);
        }
    }
}
