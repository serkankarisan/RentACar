using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IPersonelRepository
    {
        List<Personel> PersonelListele();
        Personel PersonelGetirById(int ID);
        List<Personel> PersonelSorgula(string Ad,string Soyad);

        bool PersonelEkle(Personel P);
        bool PersonelGuncelle(Personel P);

        bool PersonelSil(int ID);
        bool PersonelSil(Personel P);
    }
}
