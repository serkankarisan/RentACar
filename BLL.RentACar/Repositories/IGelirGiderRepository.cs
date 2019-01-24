using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IGelirGiderRepository
    {
        List<GelirGider> GelirGiderGetir();
        List<GelirGider> GelirGiderGetirById(int ID);

        bool GelirGiderEkle(GelirGider gg);
        bool GelirGiderGuncelle(GelirGider gg);

        bool GelirGiderSil(int ID);
        bool GelirGiderSil(GelirGider gg);
    }
}
