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
        private void frmMusteriDetay_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = mr.MusteriListele();
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
    }
}
