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
        private void frmMusteriDetay_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriListele();
            dgvMusteriler.Columns[0].Visible = false;
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

            dgvMusteriler.DataSource = mhr.MusteriHareketListeleByMusteri(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value));
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriListele();
            dgvMusteriler.Columns[0].Visible = false;
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mhr.MusteriHareketSorgula(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value), dtpBaslangic.Value, dtpBitis.Value);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mhr.MusteriHareketSorgula(Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value), dtpBaslangic.Value, dtpBitis.Value);
        }
    }
}
