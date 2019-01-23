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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        RentContext ent = new RentContext();
        private void frmGiris_Load(object sender, EventArgs e)
        {
            ent.Database.CreateIfNotExists();
            //dataGridView1.DataSource = ent.Kullanicilar.ToList();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text== "Kullanici Adi")
            {
                txtKullaniciAdi.Clear();
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Sifre")
            {
                txtSifre.Clear();
            }
        }

       
    }
}
