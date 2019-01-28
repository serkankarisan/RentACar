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
    public partial class frmSozlesmeKayitAc : Form
    {
        public frmSozlesmeKayitAc()
        {
            InitializeComponent();
        }
        SozlesmeRepository sozrepo = new SozlesmeRepository();
        PersonelRepository perrepo = new PersonelRepository();
        MusteriRepository musrepo = new MusteriRepository();
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.ShowDialog();
            txtMusteriAdi.Text = Genel.MusteriAdi;
            txtMusteriSoyadi.Text = Genel.MusteriSoyadi;
            txtMusteriTelefon.Text = Genel.MusteriTelefon;
            txtMusteriEmail.Text = Genel.MusteriEmail;
            txtMusteriAdres.Text = Genel.MusteriAdres;
            txtMusteriTCKNo.Text = Genel.MusteriTCKNo;
            cbMusteriCinsiyet.Text = Genel.MusteriCinsiyet;
            txtMusteriEhliyetNo.Text = Genel.MusteriEhliyetNo;
            ListeGoster();
        }

        private void btnPersonelSec_Click(object sender, EventArgs e)
        {
            //frmPersonelSorgulama frm = new frmPersonelSorgulama();
            //frm.ShowDialog();
            //txtPersonelAdi.Text = Genel.PersonelAdi;
            //txtPersonelSoyadi.Text = Genel.PersonelSoyadi;            
            txtPersonelAdi.Text = "Ali";
            txtPersonelSoyadi.Text = "Kaçar";
            ListeGoster();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitAc_Click(object sender, EventArgs e)
        {
            Sozlesme s = new Sozlesme();
            Personel p = perrepo.PersonelGetirById(Genel.PersonelID);
            Musteri m = musrepo.MusteriGetirById(Genel.MusteriID);
            s.PersonelAdiSoyadi = p.Adi + " " + p.Soyadi;
            s.MusteriAdiSoyadi = m.Adi + " " + m.Soyadi;
            s.AracSayisi = 0;
            s.MusteriId = Genel.MusteriID;
            s.PersonelId = 1;
            //s.PersonelId = Genel.PersonelID;
            s.Silindi = false;
            s.SozlesmeTarihi = Convert.ToDateTime(dtpSozlesmeTarihi.Text);
            s.SozlesmeTutari = 0;
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
                    Temizle();
                }
            }
        }
        private void Temizle()
        {
            Genel.MusteriID = 0;
            Genel.PersonelID = 0;
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
            dgvSozlesmeler.Columns[1].Width = 175;
            dgvSozlesmeler.Columns[1].HeaderText = "Müşteri";
            dgvSozlesmeler.Columns[2].Width = 175;
            dgvSozlesmeler.Columns[2].HeaderText = "Personel";
            dgvSozlesmeler.Columns[3].Visible = false;
            dgvSozlesmeler.Columns[4].Visible = false;
            dgvSozlesmeler.Columns[5].Width = 125;
            dgvSozlesmeler.Columns[6].Width = 75;
            dgvSozlesmeler.Columns[6].HeaderText = "Tutar";
            dgvSozlesmeler.Columns[7].Width = 125;
            dgvSozlesmeler.Columns[8].Visible = false;
            dgvSozlesmeler.Columns[9].Visible = false;
            dgvSozlesmeler.Columns[10].Visible = false;
        }

        private void frmSozlesmeKayitAc_Load(object sender, EventArgs e)
        {
            ListeGoster();
        }
    }
}
