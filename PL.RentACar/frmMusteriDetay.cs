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
            dgvMusteriler.Columns[0].Visible = false;
            MusteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            txtPuan.Text = mhr.MusteriHareketPuanGetir(MusteriId).ToString();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
           dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
            
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
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
            dtpBitis.Enabled = true;
            dtpBaslangic.Enabled = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKNo.Clear();
            txtEhliyetNo.Clear();
            txtAd.ReadOnly = false;
            txtSoyad.ReadOnly = false;
            txtTCKNo.ReadOnly = false;
            txtEhliyetNo.ReadOnly = false;
            dgvMusteriler.DataSource = mr.MusteriListele();
            dgvMusteriler.Columns[0].Visible = false;
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
            }
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
