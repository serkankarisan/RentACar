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
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }
        PersonelRepository per = new PersonelRepository();
        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text) && (!string.IsNullOrEmpty(txtSoyad.Text)) && (!string.IsNullOrEmpty(txtTelefon.Text)) && (!string.IsNullOrEmpty(txtEmail.Text)) && (!string.IsNullOrEmpty(txtAdres.Text)) && (!string.IsNullOrEmpty(txtMaas.Text)))
            {

            }
            else
            {
                MessageBox.Show("Girelecek bilgiler boş bırakılamaz.", "Hata");
            }



            tsbYeni.Enabled = true;
            tsbKaydet.Enabled = false;
            tsbDegistir.Enabled = false;
            tsbSil.Enabled = false;
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            Supurge();
            tsbKaydet.Enabled = true;
            txtAd.Focus();
        }
        private void Supurge()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtMaas.Clear();
        }

        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
