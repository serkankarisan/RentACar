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
            dgvSozleme();
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
            dgvSozlemeDetay();
        }

        private void txtSozlesmeId_TextChanged(object sender, EventArgs e)
        {
            if (txtSozlesmeId.Text.Trim() != "")
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(Convert.ToInt32(txtSozlesmeId.Text), txtTCKNo.Text, txtEhliyetNo.Text);
                dgvSozleme();
            }
            else
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                dgvSozleme();
            }
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTCKNo.Text.Trim() != "")
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(txtTCKNo.Text, txtEhliyetNo.Text);
                dgvSozleme();
            }
            else
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                dgvSozleme();
            }
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEhliyetNo.Text.Trim() != "")
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeSorgula(txtTCKNo.Text, txtEhliyetNo.Text);
                dgvSozleme();
            }
            else
            {
                dgvSozlesmeler.DataSource = sRep.SozlesmeListele();
                dgvSozleme();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSozlesmeId2_TextChanged(object sender, EventArgs e)
        {
            if (txtSozlesmeId2.Text.Trim() != "")
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(Convert.ToInt32(txtSozlesmeId2.Text), txtTckNo2.Text, txtEhliyetNo2.Text);
                dgvSozlemeDetay();
            }
            else
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                dgvSozlemeDetay();
            }
        }

        private void txtTckNo2_TextChanged(object sender, EventArgs e)
        {
            if (txtTckNo2.Text.Trim() != "")
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(txtTckNo2.Text, txtEhliyetNo2.Text);
                dgvSozlemeDetay();
            }
            else
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                dgvSozlemeDetay();
            }
        }

        private void txtEhliyetNo2_TextChanged(object sender, EventArgs e)
        {
            if (txtEhliyetNo2.Text.Trim() != "")
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(txtTckNo2.Text, txtEhliyetNo2.Text);
                dgvSozlemeDetay();
            }
            else
            {
                dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetayListele();
                dgvSozlemeDetay();
            }
        }

        private void dtpBaslangıc_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgula(dtpBaslangıc.Value);
            dgvSozlemeDetay();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            dgvSozlesmeDetay.DataSource = sdRep.SozlesmeDetaySorgulab(dtpBitis.Value);
            dgvSozlemeDetay();
        }

        private void dgvSozlesmeDetay_DoubleClick(object sender, EventArgs e)
        {
            Genel.soz = sRep.SozlesmeGetirById(Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[1].Value));
            Genel.SozID = Convert.ToInt32(dgvSozlesmeDetay.SelectedRows[0].Cells[1].Value);
            if (MessageBox.Show("Sözleşme Detay Sorgulama Sayafasından Ayrılmak İstiyor musunuz?", "Sayfa Kapatılsın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvSozlesmeler_DoubleClick(object sender, EventArgs e)
        {
            Genel.soz = sRep.SozlesmeGetirById(Convert.ToInt32(dgvSozlesmeler.SelectedRows[0].Cells[0].Value));
            Genel.SozID = Convert.ToInt32(dgvSozlesmeler.SelectedRows[0].Cells[0].Value);
            if (MessageBox.Show("Sözleşme Detaylarını Görüntülemek İster misiniz?", "Detaylar Görüntülensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtSozlesmeId2.Text = Genel.SozID.ToString();
                this.tabControl1.SelectedIndex=1;
            }
            else
            {
                if (MessageBox.Show("Sözleşme Sorgulama Sayafasından Ayrılmak İstiyor musunuz?", "Sayfa Kapatılsın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        private void dgvSozleme()
        {
            dgvSozlesmeler.Columns[0].Visible = false;
            dgvSozlesmeler.Columns[1].Visible = false;
            dgvSozlesmeler.Columns[2].Visible = false;
            dgvSozlesmeler.Columns[3].Width = 125;
            dgvSozlesmeler.Columns[3].HeaderText = "Sözleşme Tarihi";
            dgvSozlesmeler.Columns[4].Width = 125;
            dgvSozlesmeler.Columns[4].HeaderText = "Sözleşme Tutarı";
            dgvSozlesmeler.Columns[5].Width = 100;
            dgvSozlesmeler.Columns[5].HeaderText = "Toplam Alacak";
            dgvSozlesmeler.Columns[6].Width = 100;
            dgvSozlesmeler.Columns[6].HeaderText = "Toplam Borç";
            dgvSozlesmeler.Columns[7].Width = 75;
            dgvSozlesmeler.Columns[7].HeaderText = "Araç Sayısı";
            dgvSozlesmeler.Columns[8].Visible = false;
            dgvSozlesmeler.Columns[9].Visible = false;
            dgvSozlesmeler.Columns[10].Visible = false;
        }
        private void dgvSozlemeDetay()
        {
            dgvSozlesmeDetay.Columns[0].Visible = false;
            dgvSozlesmeDetay.Columns[1].Visible = false;
            dgvSozlesmeDetay.Columns[2].Visible = false;
            dgvSozlesmeDetay.Columns[3].Width = 80;
            dgvSozlesmeDetay.Columns[3].HeaderText = "Araç Tutarı";
            dgvSozlesmeDetay.Columns[4].Width = 125;
            dgvSozlesmeDetay.Columns[4].HeaderText = "Başlangıç Tarihi";
            dgvSozlesmeDetay.Columns[5].Width = 125;
            dgvSozlesmeDetay.Columns[5].HeaderText = "Bitiş Tarihi";
            dgvSozlesmeDetay.Columns[6].Visible = false;
            dgvSozlesmeDetay.Columns[7].Visible = false;
            dgvSozlesmeDetay.Columns[8].Width = 175;
            dgvSozlesmeDetay.Columns[8].HeaderText = "Marka - Model";
        }
    }
}
