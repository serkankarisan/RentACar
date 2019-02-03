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
    public partial class frmMusteriDetay : Form
    {
        public frmMusteriDetay()
        {
            InitializeComponent();
        }

        MusteriRepository mr = new MusteriRepository();
        MusteriHareketRepository mhr = new MusteriHareketRepository();
        int MusteriId;
        int MusteriHareketId;
        private void frmMusteriDetay_Load(object sender, EventArgs e)
        {
            dtpBitis.Enabled = false;
            dtpBaslangic.Enabled = false;
            dgvMusteriler.DataSource = mr.MusteriListele();
            musteridgv();
            MusteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            txtPuan.Text = mhr.MusteriHareketPuanGetir(MusteriId).ToString();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
           dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
            musteridgv();

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
            musteridgv();
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
            musteridgv();
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
            musteridgv();
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            dgvMusteriler.Width = 710;
            MusteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            Musteri m = mr.MusteriGetirById(MusteriId);
            txtAd.Text = m.Adi;
            txtSoyad.Text = m.Soyadi;
            txtTCKNo.Text = m.TcKimlikNo;
            txtEhliyetNo.Text = m.EhliyetNo;
            txtAd.ReadOnly = true;
            txtSoyad.ReadOnly = true;
            txtTCKNo.ReadOnly = true;
            txtEhliyetNo.ReadOnly = true;
            MusteriHareketId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            dgvMusteriler.DataSource = mhr.MusteriHareketListeleByMusteri(MusteriHareketId);
            musterihareketdgv();
            dtpBitis.Enabled = true;
            dtpBaslangic.Enabled = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            dgvMusteriler.Width = 950;
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKNo.Clear();
            txtEhliyetNo.Clear();
            txtAd.ReadOnly = false;
            txtSoyad.ReadOnly = false;
            txtTCKNo.ReadOnly = false;
            txtEhliyetNo.ReadOnly = false;
            dgvMusteriler.DataSource = mr.MusteriListele();
            musteridgv();
            txtPuan.Text = mhr.MusteriHareketPuanGetir(MusteriId).ToString();
            dtpBitis.Enabled = false;
            dtpBaslangic.Enabled = false;
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (basla > dtpBitis.Value)
            {
                dtpBaslangic.Value = DateTime.Now;
                dtpBitis.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");
                return;
            }
            else
            {
                dgvMusteriler.DataSource = mhr.MusteriHareketSorgula(MusteriHareketId, basla, dtpBitis.Value);
                musterihareketdgv();
            }
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime basla = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (basla > dtpBitis.Value)
            {
                dtpBitis.Value = DateTime.Now;
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tekrar tarih seçiniz!");
                return;
            }
            else
            {
                dgvMusteriler.DataSource = mhr.MusteriHareketSorgula(MusteriHareketId, basla, dtpBitis.Value);
                musterihareketdgv();
            }
            
        }
        private void musteridgv()
        {
            dgvMusteriler.Columns[0].Visible = false;
            dgvMusteriler.Columns[1].Width = 100;
            dgvMusteriler.Columns[1].HeaderText="Ad";
            dgvMusteriler.Columns[2].Width = 100;
            dgvMusteriler.Columns[2].HeaderText = "Soyad";
            dgvMusteriler.Columns[3].Width = 125;
            dgvMusteriler.Columns[3].HeaderText = "Telefon";
            dgvMusteriler.Columns[4].Width = 175;
            dgvMusteriler.Columns[4].HeaderText = "Email";
            dgvMusteriler.Columns[5].Width = 175;
            dgvMusteriler.Columns[5].HeaderText = "Adres";
            dgvMusteriler.Columns[6].Width = 125;
            dgvMusteriler.Columns[6].HeaderText = "TC Kimlik No";
            dgvMusteriler.Columns[7].Width = 100;
            dgvMusteriler.Columns[7].HeaderText = "Doğum Tarihi";
            dgvMusteriler.Columns[8].Visible = false;
            dgvMusteriler.Columns[9].Width = 80;
            dgvMusteriler.Columns[9].HeaderText = "Ehliyet No";
            dgvMusteriler.Columns[10].Visible = false;
            dgvMusteriler.Columns[11].Visible = false;
        }
        private void musterihareketdgv()
        {
            dgvMusteriler.Columns[0].Visible = false;
            dgvMusteriler.Columns[1].Width = 125;
            dgvMusteriler.Columns[1].HeaderText = "Tarih";
            dgvMusteriler.Columns[2].Visible = false;
            dgvMusteriler.Columns[3].Width = 75;
            dgvMusteriler.Columns[3].HeaderText = "Para Birimi";
            dgvMusteriler.Columns[4].Width = 75;
            dgvMusteriler.Columns[4].HeaderText = "Puan";
            dgvMusteriler.Columns[5].Width = 100;
            dgvMusteriler.Columns[5].HeaderText = "Tutar";
            dgvMusteriler.Columns[6].Width = 125;
            dgvMusteriler.Columns[6].HeaderText = "Tutar Türü";
            dgvMusteriler.Columns[7].Visible = false;
            dgvMusteriler.Columns[8].Width = 150;
            dgvMusteriler.Columns[8].HeaderText = "Müşteri Ad Soyad";
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
