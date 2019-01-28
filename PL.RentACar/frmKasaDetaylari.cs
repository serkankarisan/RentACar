using BLL.RentACar.Repositories;
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
            KHRep.KasaHareketListeleByTarih(dtpBaslangic.Value, dtpBitis.Value);
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString()) > Convert.ToDateTime(dtpBitis.Value.ToShortDateString()))
            {
                dtpBitis.Value = DateTime.Now;
                dtpBaslangic.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");
                
            }
            else
            {
                dgvMusteriler.DataSource= KHRep.KasaHareketListeleByTarih(dtpBaslangic.Value, dtpBaslangic.Value);
            }
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString()) > Convert.ToDateTime(dtpBitis.Value.ToShortDateString()))
            {
                dtpBaslangic.Value = DateTime.Now;
                dtpBitis.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");              
                
            }
            else
            {
                dgvMusteriler.DataSource = KHRep.KasaHareketListeleByTarih(dtpBaslangic.Value, dtpBaslangic.Value);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
