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
    public partial class frmMusteriIslemleri : Form
    {
        public frmMusteriIslemleri()
        {
            InitializeComponent();
        }
        int ID;
        MusteriRepository musrepo = new MusteriRepository();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            Enable();
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            txtAd.Focus();
            Temizle();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                if (!string.IsNullOrEmpty(txtSoyad.Text))
                {

                    if (!string.IsNullOrEmpty(txtAdres.Text))
                    {
                        if (!string.IsNullOrEmpty(txtTelefon.Text))
                        {
                            if (!string.IsNullOrEmpty(txtEmail.Text))
                            {
                                Musteri yeni = new Musteri();
                                yeni.Adi = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
                                yeni.Soyadi = txtSoyad.Text.Substring(0, 1).ToUpper() + txtSoyad.Text.Substring(1).ToLower();
                                yeni.Email = txtEmail.Text + cbEmail.Text;
                                if (!musrepo.MusteriEmailKontrol(yeni.Email))
                                {
                                    try
                                    {
                                        Convert.ToInt32(txtEhliyetNo.Text);

                                    }
                                    catch (FormatException)
                                    {
                                        MessageBox.Show("Geçerli Bir EhliyetNo Girin!");
                                        return;
                                    }

                                    try
                                    {
                                        Convert.ToInt64(txtTCKNo.Text);

                                    }
                                    catch (FormatException)
                                    {
                                        MessageBox.Show("Geçerli Bir TC Kimlik No Girin!");
                                        return;
                                    }
                                    yeni.Telefon = txtTelefon.Text;
                                    yeni.Adres = txtAdres.Text.Substring(0, 1).ToUpper() + txtAdres.Text.Substring(1).ToLower();
                                    yeni.TcKimlikNo = txtTCKNo.Text;
                                    yeni.EhliyetNo = txtEhliyetNo.Text;
                                    yeni.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
                                    yeni.Cinsiyet = cbCinsiyet.Text.Substring(0, 1).ToUpper() + cbCinsiyet.Text.Substring(1).ToLower();
                                    yeni.EhliyetTarihi = Convert.ToDateTime(dtpEhliyetTarihi.Text);
                                    if (musrepo.MusteriKontrol(yeni))
                                    {
                                        MessageBox.Show("Bu Müşteri Kayıtlı! veya TC Kimlik No Hatalı!", "Hatalı Bilgi Girişi!");
                                    }
                                    else
                                    {
                                        if (musrepo.MusteriEkle(yeni))
                                        {
                                            MessageBox.Show("Yeni müşteri eklendi.", "Kayıt gerçekleşti.");
                                            ListeGoster();
                                            Temizle();
                                            tsKaydet.Enabled = false;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Başka Bir Email Girmelisiniz!", "Email Zaten Mevcut!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adres Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                    }
                }
                else
                {
                    MessageBox.Show("Soyad Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                }
            }
            else
            {
                MessageBox.Show("Ad Girmelisiniz!", "Bu Alan Boş Geçilemez!");
            }
            txtAd.Focus();
        }
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKNo.Clear();
            txtAdres.Clear();
            txtEhliyetNo.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
        }
        private void frmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Disable();
            cbEmail.SelectedIndex = 0;
            cbCinsiyet.SelectedIndex = 0;
            ListeGoster();
        }
        private void ListeGoster()
        {
            dgvMusteriler.DataSource = musrepo.MusteriListele();
            dgvMusteriler.Columns[0].Visible = false;
            dgvMusteriler.Columns[1].Width = 100;
            dgvMusteriler.Columns[2].Width = 100;
            dgvMusteriler.Columns[3].Width = 125;
            dgvMusteriler.Columns[4].Width = 175;
            dgvMusteriler.Columns[5].Width = 175;
            dgvMusteriler.Columns[6].Width = 125;
            dgvMusteriler.Columns[7].Width = 100;
            dgvMusteriler.Columns[8].Width = 75;
            dgvMusteriler.Columns[9].Width = 80;
            dgvMusteriler.Columns[10].Width = 100;
            dgvMusteriler.Columns[11].Visible = false;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeGoster();
        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                if (!string.IsNullOrEmpty(txtSoyad.Text))
                {

                    if (!string.IsNullOrEmpty(txtAdres.Text))
                    {
                        if (!string.IsNullOrEmpty(txtTelefon.Text))
                        {
                            if (!string.IsNullOrEmpty(txtEmail.Text))
                            {
                                Musteri degisen = new Musteri();
                                degisen.Adi = txtAd.Text.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower();
                                degisen.Soyadi = txtSoyad.Text.Substring(0, 1).ToUpper() + txtSoyad.Text.Substring(1).ToLower();
                                degisen.Email = txtEmail.Text + cbEmail.Text;
                                    try
                                    {
                                        Convert.ToInt32(txtEhliyetNo.Text);

                                    }
                                    catch (FormatException)
                                    {
                                        MessageBox.Show("Geçerli Bir EhliyetNo Girin!");
                                        return;
                                    }

                                    try
                                    {
                                        Convert.ToInt64(txtTCKNo.Text);

                                    }
                                    catch (FormatException)
                                    {
                                        MessageBox.Show("Geçerli Bir TC Kimlik No Girin!");
                                        return;
                                    }
                                degisen.Telefon = txtTelefon.Text;
                                degisen.Adres = txtAdres.Text.Substring(0, 1).ToUpper() + txtAdres.Text.Substring(1).ToLower();
                                degisen.TcKimlikNo = txtTCKNo.Text;
                                degisen.EhliyetNo = txtEhliyetNo.Text;
                                degisen.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
                                degisen.Cinsiyet = cbCinsiyet.Text.Substring(0, 1).ToUpper() + cbCinsiyet.Text.Substring(1).ToLower();
                                degisen.EhliyetTarihi = Convert.ToDateTime(dtpEhliyetTarihi.Text);
                                degisen.Id = ID;
                                if (musrepo.MusteriKontrolFromDegistir(degisen))
                                {
                                    MessageBox.Show("TC Kimlik No Hatalı!", "Hatalı Bilgi Girişi!");
                                    ListeGoster();
                                    txtTCKNo.Focus();
                                                                    }
                                else
                                {
                                    if (musrepo.MusteriGuncelle(degisen))
                                    {
                                        MessageBox.Show("Müşteri Bilgileri Değiştirildi.", "Kayıt gerçekleşti.");
                                        ListeGoster();
                                        Temizle();
                                        tsKaydet.Enabled = false;
                                        tsDegistir.Enabled = false;
                                        tsSil.Enabled = false;
                                        Temizle();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adres Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                    }
                }
                else
                {
                    MessageBox.Show("Soyad Girmelisiniz!", "Bu Alan Boş Geçilemez!");
                }
            }
            else
            {
                MessageBox.Show("Ad Girmelisiniz!", "Bu Alan Boş Geçilemez!");
            }
            txtAd.Focus();
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            Enable();
            ID = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            txtAd.Text = dgvMusteriler.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyad.Text = dgvMusteriler.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefon.Text = dgvMusteriler.SelectedRows[0].Cells[3].Value.ToString();
            string[] email = dgvMusteriler.SelectedRows[0].Cells[4].Value.ToString().Split('@');
            txtEmail.Text = email[0];
            foreach (string item in cbEmail.Items)
            {
                if (item == "@" + email[1])
                {
                    cbEmail.SelectedItem = item;
                }
            }
            txtAdres.Text = dgvMusteriler.SelectedRows[0].Cells[5].Value.ToString();
            txtTCKNo.Text = dgvMusteriler.SelectedRows[0].Cells[6].Value.ToString();
            dtpDogumTarihi.Text = dgvMusteriler.SelectedRows[0].Cells[7].Value.ToString();
            cbCinsiyet.Text = dgvMusteriler.SelectedRows[0].Cells[8].Value.ToString();
            txtEhliyetNo.Text = dgvMusteriler.SelectedRows[0].Cells[9].Value.ToString();
            dtpEhliyetTarihi.Text = dgvMusteriler.SelectedRows[0].Cells[10].Value.ToString();
            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;
            txtAd.Focus();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (musrepo.MusteriSil(ID))
                {
                    MessageBox.Show("Müşteri Bilgileri Silindi.", "Silme Gerçekleşti.");
                    ListeGoster();
                    tsDegistir.Enabled = false;
                    tsSil.Enabled = false;
                    Temizle();
                }
            }
        }
        private void Enable()
        {
            cbCinsiyet.Enabled = true;
            cbEmail.Enabled = true;
            dtpDogumTarihi.Enabled = true;
            dtpEhliyetTarihi.Enabled = true;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = true;
                }
            }
        }
        private void Disable()
        {
            cbCinsiyet.Enabled = false;
            cbEmail.Enabled = false;
            dtpDogumTarihi.Enabled = false;
            dtpEhliyetTarihi.Enabled = false;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
        }
    }
}
