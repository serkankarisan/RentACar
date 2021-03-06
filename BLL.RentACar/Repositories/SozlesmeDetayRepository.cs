﻿using System;
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
            DateTime b = Convert.ToDateTime(baslangic.ToShortDateString());
            List<SozlesmeDetay> SozlesmeDetay = (from s in Genel.ent.SozlesmeDetaylar
                               where s.Silindi==false && s.BaslangicTarihi.Day == b.Day && s.BaslangicTarihi.Month == b.Month && s.BaslangicTarihi.Year == b.Year && s.BitisTarihi.Day == bitis.Day && s.BitisTarihi.Month == bitis.Month && s.BitisTarihi.Year == bitis.Year
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

        public List<SozlesmeDetay> SozlesmeDetaySorgula(int SozlesmeId, string TckNo, string EhliyetNo)
        {
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.SozlesmeId.ToString().StartsWith(SozlesmeId.ToString()) && k.Sozlesme.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Sozlesme.Musteri.EhliyetNo.StartsWith(EhliyetNo)).ToList();
        }
        public List<SozlesmeDetay> SozlesmeDetaySorgula(string TckNo, string EhliyetNo)
        {
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.Sozlesme.Musteri.TcKimlikNo.StartsWith(TckNo) && k.Sozlesme.Musteri.EhliyetNo.StartsWith(EhliyetNo)).ToList();
        }

        public List<SozlesmeDetay> SozlesmeDetaySorgula(DateTime B)
        {
            DateTime basla = Convert.ToDateTime(B.ToShortDateString());
            //DateTime bit = Convert.ToDateTime(Bitis.ToShortDateString());
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.BaslangicTarihi == basla).ToList();
        }
        public List<SozlesmeDetay> SozlesmeDetaySorgulab(DateTime B)
        {
            DateTime bit = Convert.ToDateTime(B.ToShortDateString());
            //DateTime bit = Convert.ToDateTime(Bitis.ToShortDateString());
            return Genel.ent.SozlesmeDetaylar.Where(k => k.Silindi == false && k.BitisTarihi == bit).ToList();
        }
    }
}
