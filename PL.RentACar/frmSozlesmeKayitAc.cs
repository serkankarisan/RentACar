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
        DateTime bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        bool msec = false;
        bool psec = false;
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {

            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.ShowDialog();
            msec = true;
            Musteri m = musrepo.MusteriGetirById(Genel.MusteriID);
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

        private void btnPersonelSec_Click(object sender, EventArgs e)
        {
            frmPersonelSorgulama frm = new frmPersonelSorgulama();
            frm.ShowDialog();
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
            dgvSozlesmeler.Columns[1].Visible = false;
            dgvSozlesmeler.Columns[2].Visible = false;
            dgvSozlesmeler.Columns[3].Width = 150;
            dgvSozlesmeler.Columns[3].HeaderText = "Sözleşme Tarihi";
            dgvSozlesmeler.Columns[4].Width = 80;
            dgvSozlesmeler.Columns[4].HeaderText = "Tutar";
            dgvSozlesmeler.Columns[5].Width = 75;
            dgvSozlesmeler.Columns[5].HeaderText = "Araç Sayısı";
            dgvSozlesmeler.Columns[6].Visible = false;
            dgvSozlesmeler.Columns[7].Visible = false;
            dgvSozlesmeler.Columns[8].Width = 160;
            dgvSozlesmeler.Columns[8].HeaderText = "Müşteri"; ;
        }

        private void frmSozlesmeKayitAc_Load(object sender, EventArgs e)
        {
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
