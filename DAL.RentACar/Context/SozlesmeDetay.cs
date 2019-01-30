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
    [Table("SozlesmeDetaylar")]
    public class SozlesmeDetay
    {
        [Key]
        public int Id { get; set; }
        public int SozlesmeId { get; set; }
        public int AracId { get; set; }
        [Required]
        public decimal Tutar { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations

        [ForeignKey("SozlesmeId")]
        public virtual Sozlesme Sozlesme { get; set; }
        [ForeignKey("AracId")]
        public virtual Arac Arac { get; set; }
        public SozlesmeDetay()
        {
            Silindi = false;
            Tutar = 0;
            AracId = 0;
            BaslangicTarihi = DateTime.Now;
            BitisTarihi = DateTime.Now;
        }
    }
}
