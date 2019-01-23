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
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int RoleId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations

        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }

        [ForeignKey("RoleId")]
        public virtual Yetki Yetki { get; set; }
    }
}
