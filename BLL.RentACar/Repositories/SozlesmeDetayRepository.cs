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
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetayGetir()
        {
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetayGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetayGetirByMusteri(string Ad, string Soyad, string TCKNo, string EhliyetNo)
        {
            throw new NotImplementedException();
        }

        public List<SozlesmeDetay> SozlesmeDetayGetirByTarih(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeDetayGuncelle(SozlesmeDetay s)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeDetaySil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SozlesmeDetaySil(SozlesmeDetay s)
        {
            throw new NotImplementedException();
        }
    }
}