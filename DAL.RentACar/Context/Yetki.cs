using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RentACar.Context
{ 
    [Table("Yetkiler")]
    public class Yetki
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations
        public virtual List<Kullanici> Kullanicilar { get; set; }
        public override string ToString()
        {
            return RoleName;
        }
        public Yetki()
        {
            Silindi = false;
        }
    }
}
