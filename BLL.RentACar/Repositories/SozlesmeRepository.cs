using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class SozlesmeRepository : ISozlesmeRepository
    {
        public bool SozlesmeEkle(Sozlesme s)
        {
            bool Sonuc = false;
            Genel.ent.Sozlesmeler.Add(s);
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

        public Sozlesme SozlesmeGetirById(int ID)
        {
            Sozlesme sozlesme = (from s in Genel.ent.Sozlesmeler
                               where s.Id == ID
                               select s).FirstOrDefault();

            return sozlesme;
        }

        public bool SozlesmeGuncelle(Sozlesme s)
        {
            bool Sonuc = false;
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

        public bool SozlesmeKontrol(Sozlesme yeni)
        {
            return Convert.ToBoolean(Genel.ent.Sozlesmeler.Where(s => s.Id == yeni.Id).ToList().Count);
        }

        public List<Sozlesme> SozlesmeListele()
        {
            return Genel.ent.Sozlesmeler.Where(s => s.Silindi == false).ToList();
        }

        public List<Sozlesme> SozlesmeListeleByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
           Musteri secilen = Genel.ent.Musteriler.Where(m => m.Silindi == false && m.Adi == Ad && m.Soyadi.Contains(Soyad) && m.TcKimlikNo.Contains(TCKNo) && m.EhliyetNo.Contains(EhliyetNo)).FirstOrDefault();
            return Genel.ent.Sozlesmeler.Where(s => s.Silindi == false && s.MusteriId == secilen.Id).ToList();
        }

        public List<Sozlesme> SozlesmeListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            return Genel.ent.Sozlesmeler.Where(s => s.Silindi == false && s.SozlesmeTarihi >= baslangic && s.SozlesmeTarihi <= bitis).ToList();
        }

        public bool SozlesmeSil(int ID)
        {
            bool Sonuc = false;
            Sozlesme silinen = (from s in Genel.ent.Sozlesmeler
                               where s.Id == ID
                               select s).FirstOrDefault();
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

        public bool SozlesmeSil(Sozlesme s)
        {
            bool Sonuc = false;
            Genel.ent.Sozlesmeler.Remove(s);
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
    }
}
