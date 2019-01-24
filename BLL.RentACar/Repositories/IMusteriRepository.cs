using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IMusteriRepository
    {
        List<Musteri> MusteriGetir();
        List<Musteri> MusteriGetirById(int ID);
        List<Musteri> MusteriSorgula(string Ad,string Soyad,string TCKNo,string EhliyetNo);

        bool MusteriEkle(Musteri M);
        bool MusteriGuncelle(Musteri M);

        bool MusteriSil(int ID);
        bool MusteriSil(Musteri M);
    }
}
