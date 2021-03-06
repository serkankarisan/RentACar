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
    public partial class frmSozlesmeKayitAc : Form
    {
        public frmSozlesmeKayitAc()
        {
            InitializeComponent();
        }
        SozlesmeRepository sozrepo = new SozlesmeRepository();
        PersonelRepository perrepo = new PersonelRepository();
        MusteriRepository musrepo = new MusteriRepository();
        DateTime bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        bool msec = false;
        bool psec = false;
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.ShowDialog();
            msec = true;
            if (Genel.MusteriID != 0)
            {
                Musteri m = musrepo.MusteriGetirById(Genel.MusteriID);
                MusteriHareketRepository mhrep = new MusteriHareketRepository();
                if (mhrep.MusteriHareketPuanGetir(Genel.MusteriID)<30 )
                {
                    if ((MessageBox.Show("Müşteri Puanı Alt Sınırda Sözleşmeye Devam Edilsin Mi?", "Sözleşme Yapılsınmı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        txtMusteriAdi.Text = m.Adi;
                        txtMusteriSoyadi.Text = m.Soyadi;
                        txtMusteriTelefon.Text = m.Telefon;
                        txtMusteriEmail.Text = m.Email;
                        txtMusteriAdres.Text = m.Adres;
                        txtMusteriTCKNo.Text = m.TcKimlikNo;
                        cbMusteriCinsiyet.Text = m.Cinsiyet;
                        txtMusteriEhliyetNo.Text = m.EhliyetNo;
                        ListeGoster();
                        if (msec && psec)
                        {
                            btnKayitAc.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sözleşme İptal Edildi!","Puan Düşük");
                        this.Close();
                    }
                }
                else
                {
                    txtMusteriAdi.Text = m.Adi;
                    txtMusteriSoyadi.Text = m.Soyadi;
                    txtMusteriTelefon.Text = m.Telefon;
                    txtMusteriEmail.Text = m.Email;
                    txtMusteriAdres.Text = m.Adres;
                    txtMusteriTCKNo.Text = m.TcKimlikNo;
                    cbMusteriCinsiyet.Text = m.Cinsiyet;
                    txtMusteriEhliyetNo.Text = m.EhliyetNo;
                    ListeGoster();
                    if (msec && psec)
                    {
                        btnKayitAc.Enabled = true;
                    }
                }
            }
        }

        private void btnPersonelSec_Click(object sender, EventArgs e)
        {
            frmPersonelSorgulama frm = new frmPersonelSorgulama();
            frm.ShowDialog();
            psec = true;
            if (Genel.PersonelID!=0)
            {
                Personel p = perrepo.PersonelGetirById(Genel.PersonelID);
                txtPersonelAdi.Text = p.Adi;
                txtPersonelSoyadi.Text = p.Soyadi;
                ListeGoster();
                if (msec && psec)
                {
                    btnKayitAc.Enabled = true;
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitAc_Click(object sender, EventArgs e)
        {
            msec = false;
            psec = false;
            Sozlesme s = new Sozlesme();
            if (Genel.MusteriID!=0)
            {
                if (Genel.PersonelID!=0)
                {
                    s.AracSayisi = 0;
                    s.MusteriId = Genel.MusteriID;
                    s.PersonelId = Genel.PersonelID;
                    s.Silindi = false;
                    s.SozlesmeTarihi = DateTime.Now;
                    s.SozlesmeTutari = 0;
                    s.Alınan = 0;
                    s.Borc = 0;
                    if (sozrepo.SozlesmeKontrol(s))
                    {
                        MessageBox.Show("Bu Sözleşme Kayıtlı!", "Hatalı Bilgi Girişi!");
                    }
                    else
                    {
                        if (sozrepo.SozlesmeEkle(s))
                        {
                            MessageBox.Show("Yeni Sözleşme Eklendi.", "Kayıt Gerçekleşti.");
                            ListeGoster();
                            Genel.soz = s;
                            Temizle();
                            this.Hide();
                            frmKirala frm = new frmKirala();
                            FormAc(frm);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bir Personel Seçmelisiniz!", "Eksik Bilgi Girişi!");
                }
            }
            else
            {
                MessageBox.Show("Bir Müşteri Seçmelisiniz!", "Eksik Bilgi Girişi!");
            }
            ListeGoster();
        }
        private void Temizle()
        {
            txtMusteriAdi.Clear();
            txtMusteriSoyadi.Clear();
            txtMusteriTelefon.Clear();
            txtMusteriAdres.Clear();
            txtMusteriEmail.Clear();
            txtMusteriTCKNo.Clear();
            txtPersonelAdi.Clear();
            txtPersonelSoyadi.Clear();
            txtMusteriEhliyetNo.Clear();
        }
        private void ListeGoster()
        {
            dgvSozlesmeler.DataSource = sozrepo.SozlesmeListeleByMusteriId(Genel.MusteriID);
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

        private void frmSozlesmeKayitAc_Load(object sender, EventArgs e)
        {
            if (Genel.PersonelID != 0)
            {
                psec = true;
                Personel p = perrepo.PersonelGetirById(Genel.PersonelID);
                txtPersonelAdi.Text = p.Adi;
                txtPersonelSoyadi.Text = p.Soyadi;
                ListeGoster();
                if (msec && psec)
                {
                    btnKayitAc.Enabled = true;
                }
            }
            dtpSozlesmeTarihi.Value = bugun;
            ListeGoster();
        }
        private void FormAc(Form AF)
        {
            AF.TopLevel = false;
            this.Parent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        
        private void dtpSozlesmeTarihi_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
