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
    public partial class frmPersonelSorgulama : Form
    {
        public frmPersonelSorgulama()
        {
            InitializeComponent();
        }
        PersonelRepository pr = new PersonelRepository();

        private void frmPersonelSorgulama_Load(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = pr.PersonelListele();
        }

        private void dgvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Genel.PersonelID = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value);
            this.Close();
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = pr.PersonelSorgula(txtAdi.Text, txtSoyadi.Text);
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = pr.PersonelSorgula(txtAdi.Text, txtSoyadi.Text);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
