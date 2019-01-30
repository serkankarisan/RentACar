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
    public partial class frmMaasOdeme : Form
    {
        public frmMaasOdeme()
        {
            InitializeComponent();
        }
        decimal ToplamMaas = 0;
        decimal ToplamPirim = 0;
        decimal Total = 0;
        frmPersonelSorgulama frm = new frmPersonelSorgulama();
        PersonelRepository pr = new PersonelRepository();
        KasaHareketRepository khr = new KasaHareketRepository();
        Personel p = new Personel();
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            p=pr.PersonelGetirById(Genel.PersonelID);
            txtAdi.Text = p.Adi;
            txtSoyadi.Text = p.Soyadi;
            txtMaas.Text = p.Maas.ToString();

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim()!="" && txtSoyadi.Text.Trim()!="" && (txtMaas.Text.Trim()!="" || txtPrim.Text.Trim()!=""))
            {
                KasaHareket kh = new KasaHareket();
                kh.AracId = 0;
                kh.SozlesmeId = 0;
                kh.PersonelId = Genel.PersonelID;
                kh.Tarih = DateTime.Now;
                kh.GelirGiderId = 1;
                kh.Tutar = Convert.ToDecimal(txtMaas.Text);
                kh.ParaBirimi = "TL";
                kh.Silindi = false;
                if (khr.KasaHareketEkle(kh))
                {
                    MessageBox.Show("Maaş Ödendi.", "Kayıt gerçekleşti.");
                    txtAdi.Clear();
                    txtSoyadi.Clear();
                    txtAdi.Focus();
               
                }
                else { MessageBox.Show("Kayit gerceklesmedi"); }
                
            }
            else
            {
                MessageBox.Show("Gerekli alanlari doldurunuz!");
            }

        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {
            ToplamMaas = Convert.ToDecimal(txtMaas.Text);
            Total = ToplamMaas + ToplamPirim;
            txtToplamOdeme.Text = Total.ToString();
        }

        private void txtPrim_TextChanged(object sender, EventArgs e)
        {
            ToplamPirim = Convert.ToDecimal(txtPrim.Text);
            Total = ToplamMaas + ToplamPirim;
            txtToplamOdeme.Text = Total.ToString();
        }

        private void frmMaasOdeme_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
