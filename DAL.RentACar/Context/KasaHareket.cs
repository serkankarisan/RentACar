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
    [Table("KasaHareketler")]
    public class KasaHareket
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue(0)]
        public int SozlesmeId { get; set; }
        [DefaultValue(0)]
        public int AracId { get; set; }
        [DefaultValue(0)]
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public int GelirGiderId { get; set; }
        public string Tutar { get; set; }
        public string ParaBirimi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }
        //Relations
        [ForeignKey("GelirGiderId")]
        public virtual GelirGider GelirGider { get; set; }
    }
}
