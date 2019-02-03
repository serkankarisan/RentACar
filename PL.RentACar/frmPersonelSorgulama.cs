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
            dgvColumns();
        }

        private void dgvPersonel_DoubleClick(object sender, EventArgs e)
        {
            Genel.PersonelID = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value);
            if (MessageBox.Show("Personel Sorgulama Sayafasından Ayrılmak İstiyor musunuz?", "Sayfa Kapatılsın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = pr.PersonelSorgula(txtAdi.Text, txtSoyadi.Text);
            dgvColumns();
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            dgvPersonel.DataSource = pr.PersonelSorgula(txtAdi.Text, txtSoyadi.Text);
            dgvColumns();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvColumns()
        {
            dgvPersonel.Columns[0].Visible = false;
            dgvPersonel.Columns[1].Width = 100;
            dgvPersonel.Columns[2].Width = 100;
            dgvPersonel.Columns[3].Width = 125;
            dgvPersonel.Columns[4].Width = 175;
            dgvPersonel.Columns[5].Width = 175;
            dgvPersonel.Columns[6].Width = 125;
            dgvPersonel.Columns[7].Visible = false;
        }
    }
}
