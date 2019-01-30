using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RentACar.Context;

namespace BLL.RentACar.Repositories
{
    public class SozlesmeDetayRepository : ISozlesmeDetayRepository
    {
        public bool SozlesmeDetayEkle(SozlesmeDetay s)
        {
            bool Sonuc = false;

            Genel.ent.SozlesmeDetaylar.Add(s);
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

        public List<SozlesmeDetay> SozlesmeDetayListeleBySozlesmeId(int ID)
        {
            List<SozlesmeDetay> bulunan = (from sd in Genel.ent.SozlesmeDetaylar
                                           where sd.SozlesmeId == ID && sd.Silindi == false
                            select sd).ToList();

            return bulunan;
        }
        public SozlesmeDetay SozlesmeDetayGetirById(int ID)
        {
            SozlesmeDetay bulunan = (from sd in Genel.ent.SozlesmeDetaylar
                                     where sd.Id == ID && sd.Silindi == false
                                           select sd).FirstOrDefault();

            return bulunan;
        }
        public decimal SozlesmeTutarGetirBySozlesmeId(int ID)
        {
            decimal toplamtutar = (from sd in Genel.ent.SozlesmeDetaylar
                                           where sd.SozlesmeId == ID
                                           select sd.Tutar).ToList().Sum();

            return toplamtutar;
        }

        public bool SozlesmeDetayGuncelle(SozlesmeDetay s)
        {
            bool Sonuc = false;
            SozlesmeDetay degisen = SozlesmeDetayGetirById(s.Id);
            degisen = s;
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

        public List<SozlesmeDetay> SozlesmeDetayListele()
        {
            return Genel.ent.SozlesmeDetaylar.Where(s=> s.Silindi==false).ToList();
        }

        public List<SozlesmeDetay> SozlesmeDetayListeleByAranan(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetayListeleByTarih(DateTime baslangic, DateTime bitis)
        {
            List<SozlesmeDetay> SozlesmeDetay = (from s in Genel.ent.SozlesmeDetaylar
                               where s.BaslangicTarihi==baslangic && s.BitisTarihi==bitis
                               select s).ToList();

            return SozlesmeDetay;
        }

        public bool SozlesmeDetaySil(int ID)
        {
            bool Sonuc = false;
            SozlesmeDetay silinen = (from a in Genel.ent.SozlesmeDetaylar
                            where a.Id == ID
                            select a).FirstOrDefault();
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

        public bool SozlesmeDetaySil(SozlesmeDetay s)
        {
            bool Sonuc = false;
            Genel.ent.SozlesmeDetaylar.Remove(s);
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

        public List<SozlesmeDetay> SozlesmeDetaySorgula(int SozlesmeId, string TckNo, string EhliyetNo, DateTime Baslangic, DateTime Bitis)
        {
            DateTime basla = Convert.ToDateTime(Baslangic.ToShortDateString());
            DateTime bit = Convert.ToDateTime(Bitis.ToShortDateString());
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.SozlesmeId.ToString().StartsWith(SozlesmeId.ToString()) && k.Sozlesme.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Sozlesme.Musteri.EhliyetNo.StartsWith(EhliyetNo) && k.BaslangicTarihi == basla  && k.BitisTarihi == bit).ToList();
        }
        public List<SozlesmeDetay> SozlesmeDetaySorgula(string TckNo, string EhliyetNo, DateTime Baslangic, DateTime Bitis)
        {
            DateTime basla = Convert.ToDateTime(Baslangic.ToShortDateString());
            DateTime bit = Convert.ToDateTime(Bitis.ToShortDateString());
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.Sozlesme.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Sozlesme.Musteri.EhliyetNo.StartsWith(EhliyetNo) && k.BaslangicTarihi == basla && k.BitisTarihi == bit).ToList();
        }

        public List<SozlesmeDetay> SozlesmeDetaySorgula(int SozlesmeId, string TckNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetaySorgula(DateTime Baslangic, DateTime Bitis)
        {
            DateTime basla = Convert.ToDateTime(Baslangic.ToShortDateString());
            DateTime bit = Convert.ToDateTime(Bitis.ToShortDateString());
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.BaslangicTarihi == basla && k.BitisTarihi == bit).ToList();
        }
    }
}
