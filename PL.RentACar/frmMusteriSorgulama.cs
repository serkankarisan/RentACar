﻿using BLL.RentACar.Repositories;
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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }
        MusteriRepository musrepo = new MusteriRepository();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ListeGoster(musrepo.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text));
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            ListeGoster(musrepo.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text));
        }

        private void txtTCKNo_TextChanged(object sender, EventArgs e)
        {
            ListeGoster(musrepo.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text));
        }

        private void txtEhliyetNo_TextChanged(object sender, EventArgs e)
        {
            ListeGoster(musrepo.MusteriSorgula(txtAd.Text, txtSoyad.Text, txtTCKNo.Text, txtEhliyetNo.Text));
        }
        private void ListeGoster(List<Musteri> Liste)
        {
            dgvMusteriler.DataSource = Liste;
            dgvMusteriler.Columns[0].Visible = false;
            dgvMusteriler.Columns[1].Width = 100;
            dgvMusteriler.Columns[1].HeaderText = "Ad";
            dgvMusteriler.Columns[2].Width = 100;
            dgvMusteriler.Columns[2].HeaderText = "Soyad";
            dgvMusteriler.Columns[3].Width = 125;
            dgvMusteriler.Columns[3].HeaderText = "Telefon";
            dgvMusteriler.Columns[4].Width = 175;
            dgvMusteriler.Columns[4].HeaderText = "Email";
            dgvMusteriler.Columns[5].Width = 175;
            dgvMusteriler.Columns[5].HeaderText = "Adres";
            dgvMusteriler.Columns[6].Width = 125;
            dgvMusteriler.Columns[6].HeaderText = "TC Kimlik No";
            dgvMusteriler.Columns[7].Width = 100;
            dgvMusteriler.Columns[7].HeaderText = "Doğum Tarihi";
            dgvMusteriler.Columns[8].Visible = false;
            dgvMusteriler.Columns[9].Width = 80;
            dgvMusteriler.Columns[9].HeaderText = "Ehliyet No";
            dgvMusteriler.Columns[10].Visible = false;
            dgvMusteriler.Columns[11].Visible = false;
        }

        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            ListeGoster(musrepo.MusteriListele());
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            frmMusteriIslemleri frm = new frmMusteriIslemleri();
            frm.ShowDialog();
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            Genel.MusteriID = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            if (MessageBox.Show("Müşteri Sorgulama Sayafasından Ayrılmak İstiyor musunuz?", "Sayfa Kapatılsın mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Genel.gecicimusteriId = Genel.MusteriID;
            {
                this.Close();
            }
        }
    }
}
