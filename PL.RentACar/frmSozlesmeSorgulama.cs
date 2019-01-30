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
    public partial class frmSozlesmeSorgulama : Form
    {
        public frmSozlesmeSorgulama()
        {
            InitializeComponent();
        }
        SozlesmeRepository sRep = new SozlesmeRepository();
        SozlesmeDetayRepository sdRep = new SozlesmeDetayRepository();

        private void frmSozlesmeSorgulama_Load(object sender, EventArgs e)
        {
            dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
        }

        private void txtSozlesmeId_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(Convert.ToInt32(txtSozlesmeId.Text), txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(Convert.ToInt32(txtSozlesmeId.Text), txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(Convert.ToInt32(txtSozlesmeId.Text), txtTCKNo.Text, txtEhliyetNo.Text);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSozlesmeId2_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text, Convert.ToDateTime(dtpBaslangıc), Convert.ToDateTime(dtpBitis));
        }

        private void txtTckNo2_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text, Convert.ToDateTime(dtpBaslangıc), Convert.ToDateTime(dtpBitis));
        }

        private void txtEhliyetNo2_TextChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text, Convert.ToDateTime(dtpBaslangıc), Convert.ToDateTime(dtpBitis));
        }

        private void dtpBaslangıc_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text, Convert.ToDateTime(dtpBaslangıc), Convert.ToDateTime(dtpBitis));
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text, Convert.ToDateTime(dtpBaslangıc), Convert.ToDateTime(dtpBitis));
        }
    }
}
