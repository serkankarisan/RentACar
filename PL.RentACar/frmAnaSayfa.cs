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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblKullanici.Text = Genel.UserName;
            lblYetki.Text = Genel.Yetki;
            lblTarih.Text = DateTime.Now.Date.ToLongDateString();
        }
        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void btnMenuAc_Click(object sender, EventArgs e)
        {
            pnlMenu.Width = 175;
            btnMenuAc.Visible = false;
            lblMenu.Visible = true;
            btnMenuKapat.Visible = true;
            pbHome.Visible = true;
        }

        private void btnMenuKapat_Click(object sender, EventArgs e)
        {
            pnlMenu.Width = 35;
            pbHome.Visible = false;
            btnMenuKapat.Visible = false;
            lblMenu.Visible = false;
            btnMenuAc.Visible = true;
        }

        private void btnSozlesmeMenu_Click(object sender, EventArgs e)
        {
            pnlAracMenu.Width = 0;
            pnlKasaMenu.Width = 0;
            pnlMusteriMenu.Width = 0;
            pnlPersonelMenu.Width = 0;
            if (pnlSozlesmeMenu.Width==0)
            {
                pnlSozlesmeMenu.Width = 170;
            }
            else
            {
                pnlSozlesmeMenu.Width = 0;
            }
        }

        private void btnMusteriMenu_Click(object sender, EventArgs e)
        {
            pnlAracMenu.Width = 0;
            pnlKasaMenu.Width = 0;
            pnlPersonelMenu.Width = 0;
            pnlSozlesmeMenu.Width = 0;
            if (pnlMusteriMenu.Width == 0)
            {
                pnlMusteriMenu.Width = 170;
            }
            else
            {
                pnlMusteriMenu.Width = 0;
            }
        }

        private void btnAracMenu_Click(object sender, EventArgs e)
        {
            pnlKasaMenu.Width = 0;
            pnlMusteriMenu.Width = 0;
            pnlPersonelMenu.Width = 0;
            pnlSozlesmeMenu.Width = 0;
            if (pnlAracMenu.Width == 0)
            {
                pnlAracMenu.Width = 170;
            }
            else
            {
                pnlAracMenu.Width = 0;
            }
        }

        private void btnPersonelMenu_Click(object sender, EventArgs e)
        {
            pnlAracMenu.Width = 0;
            pnlKasaMenu.Width = 0;
            pnlMusteriMenu.Width = 0;
            pnlSozlesmeMenu.Width = 0;
            if (pnlPersonelMenu.Width == 0)
            {
                pnlPersonelMenu.Width = 170;
            }
            else
            {
                pnlPersonelMenu.Width = 0;
            }
        }

        private void btnKasaMenu_Click(object sender, EventArgs e)
        {
            pnlAracMenu.Width = 0;
            pnlMusteriMenu.Width = 0;
            pnlPersonelMenu.Width = 0;
            pnlSozlesmeMenu.Width = 0;
            if (pnlKasaMenu.Width == 0)
            {
                pnlKasaMenu.Width = 170;
            }
            else
            {
                pnlKasaMenu.Width = 0;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            frmSozlesmeKayitAc frm = new frmSozlesmeKayitAc();
            PanelGizle();
            FormAc(frm);
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            frmTeslimAl frm = new frmTeslimAl();
            PanelGizle();
            FormAc(frm);
        }

        private void btnSozlesmeSorgula_Click(object sender, EventArgs e)
        {
            frmSozlesmeSorgulama frm = new frmSozlesmeSorgulama();
            PanelGizle();
            FormAc(frm);
        }
        private void PanelGizle()
        {
            pnlAracMenu.Width = 0;
            pnlKasaMenu.Width = 0;
            pnlMusteriMenu.Width = 0;
            pnlPersonelMenu.Width = 0;
            pnlSozlesmeMenu.Width = 0;
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            frmMusteriIslemleri frm = new frmMusteriIslemleri();
            PanelGizle();
            FormAc(frm);
        }

        private void btnMusteriDetay_Click(object sender, EventArgs e)
        {
            frmMusteriDetay frm = new frmMusteriDetay();
            PanelGizle();
            FormAc(frm);
        }

        private void btnMusteriSorgula_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            PanelGizle();
            FormAc(frm);
        }

        private void btnAracIslemleri_Click(object sender, EventArgs e)
        {
            frmAracIslemleri frm = new frmAracIslemleri();
            PanelGizle();
            FormAc(frm);
        }

        private void btnAracSorgula_Click(object sender, EventArgs e)
        {
            frmAracSorgulama frm = new frmAracSorgulama();
            PanelGizle();
            FormAc(frm);
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            frmPersonelIslemleri frm = new frmPersonelIslemleri();
            PanelGizle();
            FormAc(frm);
        }

        private void btnPersonelSorgula_Click(object sender, EventArgs e)
        {
            frmPersonelSorgulama frm = new frmPersonelSorgulama();
            PanelGizle();
            FormAc(frm);
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            frmKullaniciIslemleri frm = new frmKullaniciIslemleri();
            PanelGizle();
            FormAc(frm);
        }

        private void btnKasaDetay_Click(object sender, EventArgs e)
        {
            frmKasaDetaylari frm = new frmKasaDetaylari();
            PanelGizle();
            FormAc(frm);
        }

        private void btnMaasOdeme_Click(object sender, EventArgs e)
        {
            frmMaasOdeme frm = new frmMaasOdeme();
            PanelGizle();
            FormAc(frm);
        }

        private void btnRaporMenu_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            PanelGizle();
            FormAc(frm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
