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
    [Table("MusteriHareketler")]
    public class MusteriHareket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Tarih { get; set; }
        public int MusteriId { get; set; }
        [DefaultValue("TL")]
        public string ParaBirimi { get; set; }
        [DefaultValue(100)]
        public int MusteriPuanı { get; set; }
        [Required]
        public decimal MusteriGetirisi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //Relations

        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }
    }
}
