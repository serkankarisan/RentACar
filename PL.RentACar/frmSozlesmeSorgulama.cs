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
        int a;
        private void frmSozlesmeSorgulama_Load(object sender, EventArgs e)
        {
            dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
        }

        private void txtSozlesmeId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSozlesmeId.Text, out a) || txtSozlesmeId.Text == "")
            {
                if (txtSozlesmeId.Text.Trim() != "")
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(Convert.ToInt32(txtSozlesmeId.Text), txtTCKNo.Text, txtEhliyetNo.Text);
                }
                else
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtSozlesmeId.Clear();
            }
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTCKNo.Text, out a) || txtTCKNo.Text == "")
            {
                if (txtTCKNo.Text.Trim() != "")
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(txtTCKNo.Text, txtEhliyetNo.Text);
                }
                else
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtTCKNo.Clear();
            }
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtEhliyetNo.Text, out a) || txtEhliyetNo.Text == "")
            {
                if (txtEhliyetNo.Text.Trim() != "")
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(txtTCKNo.Text, txtEhliyetNo.Text);
                }
                else
                {
                    dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtEhliyetNo.Clear();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSozlesmeId2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSozlesmeId2.Text, out a) || txtSozlesmeId2.Text == "")
            {
                if (txtSozlesmeId2.Text.Trim() != "")
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text);
                }
                else
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtSozlesmeId2.Clear();
            }
        }

        private void txtTckNo2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTckNo2.Text, out a) || txtTckNo2.Text == "")
            {
                if (txtTckNo2.Text.Trim() != "")
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(txtTckNo2.Text, txtEhliyetNo2.Text);
                }
                else
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtTckNo2.Clear();
            }
        }

        private void txtEhliyetNo2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtEhliyetNo2.Text, out a) || txtEhliyetNo2.Text == "")
            {
                if (txtEhliyetNo2.Text.Trim() != "")
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(txtTckNo2.Text, txtEhliyetNo2.Text);
                }
                else
                {
                    dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                }
            }
            else
            {
                MessageBox.Show("Sayı girilmelidir!", "Yanlış giriş!");
                txtEhliyetNo2.Clear();
            }
        }

        private void dtpBaslangıc_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(dtpBaslangıc.Value);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgulab(dtpBitis.Value);
        }

        private void dgvSozlesmeDetay_DoubleClick(object sender, EventArgs e)
        {
            Genel.soz = sRep.SozlesmeGetirById(Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[1].Value));
            Genel.SozID = Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[1].Value);
            this.Close();
        }

        private void dgvSozlesmeler_DoubleClick(object sender, EventArgs e)
        {
            Genel.soz = sRep.SozlesmeGetirById(Convert.ToInt32(dgvSozlesmeler.SelectedRows[0].Cells[0].Value));
            Genel.SozID = Convert.ToInt32(dgvSozlesmeler.SelectedRows[0].Cells[0].Value);
            this.Close();
        }
    }
}
