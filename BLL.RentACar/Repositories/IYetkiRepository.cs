using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RentACar.Repositories
{
    public interface IYetkiRepository
    {
        List<Yetki> YetkiGetir();
        List<Yetki> YetkiGetirById(int ID);

        bool YetkiEkle(Yetki y);

        bool YetkiSil(int ID);
        bool YetkiSil(Yetki y);
    }
}
