using BLL.RentACar.Repositories;
using DAL.RentACar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.RentACar
{
    public partial class frmKasaDetaylari : Form
    {
        public frmKasaDetaylari()
        {
            InitializeComponent();
        }
        KasaHareketRepository KHRep = new KasaHareketRepository();
        private void frmKasaDetaylari_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            DateTime bit = Convert.ToDateTime(dtpBitis.Value.ToShortDateString());
            if ( basla>bit )
            {
                dtpBitis.Value = DateTime.Now;
                dtpBaslangic.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");
                
            }
            else
            {
                //txtToplamBakiye.Text = KHRep.KasaHareketToplamTutarByTarih(basla, dtpBitis.Value).ToString();
                dgvKasaDetay.DataSource= KHRep.KasaHareketListeleByTarih(basla, dtpBitis.Value);
                txtToplamBakiye.Text = Hesapla().ToString();
            }
        }
        
        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            DateTime bit = Convert.ToDateTime(dtpBitis.Value.ToShortDateString());
            if (basla > bit)
            {
                dtpBaslangic.Value = DateTime.Now;
                dtpBitis.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");              
            }
            else
            {
                //txtToplamBakiye.Text = KHRep.KasaHareketToplamTutarByTarih(basla, dtpBitis.Value).ToString();
                dgvKasaDetay.DataSource = KHRep.KasaHareketListeleByTarih(basla, dtpBitis.Value);
                txtToplamBakiye.Text = Hesapla().ToString();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal Hesapla()
        {
            decimal Toplam = 0;
            decimal ToplamGiren = 0;
            decimal ToplamCikan = 0;
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            foreach (KasaHareket item in KHRep.KasaHareketListeleByTarih(basla, dtpBitis.Value))
            {
                if (item.GelirGider.Tür == "Gelir")
                {
                    ToplamGiren += item.Tutar;
                }
                else if (item.GelirGider.Tür == "Gider")
                {
                    ToplamCikan += item.Tutar;
                }
                Toplam = (ToplamGiren - ToplamCikan) ;
            }
            return Toplam;
        }
    }
}
