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
    public partial class frmAracSorgulama : Form
    {
        public frmAracSorgulama()
        {
            InitializeComponent();
        }        
        AracRepository ARep = new AracRepository();
        int x;
        ImageList il = new ImageList();
        ImageList il2 = new ImageList();
        string projeAdres = Application.StartupPath;
        private void mitmLargeIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.LargeIcon;
        }

        private void mitmDetails_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Details;

        }

        private void mitmSmallIcon_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.SmallIcon;

        }

        private void mitmList_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.List;

        }

        private void mitmTile_Click(object sender, EventArgs e)
        {
            lvDetaylar.View = View.Tile;

        }

        private void frmAracSorgulama_Load(object sender, EventArgs e)
        {
            il.ImageSize = new Size(120, 120);
            il2.ImageSize = new Size(16, 16);
            txtMarka.Text = "Markalar";
            cbMarkalar.Items.Clear();
            cbMarkalar.DisplayMember = "Marka";
            cbMarkalar.ValueMember = "Id";
            cbMarkalar.DataSource = ARep.AracListeleByMarka();
            ShowListView(ARep.AracListele());
            x = 1;
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (x > 0)
            {
                lvDetaylar.Items.Clear();                
                
                lvDetaylar.LargeImageList = il;
                lvDetaylar.SmallImageList = il2;
                
                txtMarka.Text = cbMarkalar.SelectedItem.ToString();
                List<Arac> liste = ARep.AracListele();
                int j = 0;
                for (int i = 0; i < liste.Count; i++)
                {
                    if (cbMarkalar.SelectedItem.ToString() == liste[i].Marka)
                    {
                        il.Images.Add(Image.FromFile(projeAdres + liste[i].ResimYolu));
                        il2.Images.Add(Image.FromFile(projeAdres + liste[i].ResimYolu));
                        lvDetaylar.Items.Add(liste[i].Model, ResimIndisiGetir(liste[i].Id));
                        lvDetaylar.Items[j].SubItems.Add(liste[i].Tip);
                        lvDetaylar.Items[j].SubItems.Add(liste[i].Renk);
                        lvDetaylar.Items[j].SubItems.Add(liste[i].Plaka);
                        lvDetaylar.Items[j].SubItems.Add(liste[i].AracDurumu);
                        lvDetaylar.Items[j].SubItems.Add(liste[i].GünlükFiyat.ToString());
                        j++;
                    }
                }
            }
        }
        private void ShowListView(List<Arac> listem)
        {
            
            il.ImageSize = new Size(120, 120);
            il2.ImageSize = new Size(16, 16);
            lvDetaylar.LargeImageList = il;
            lvDetaylar.SmallImageList = il2;
            for (int i = 0; i < listem.Count; i++)
            {                
                il.Images.Add(Image.FromFile(projeAdres + listem[i].ResimYolu));
                il2.Images.Add(Image.FromFile(projeAdres + listem[i].ResimYolu));
                lvDetaylar.Items.Add(listem[i].Model, ResimIndisiGetir(listem[i].Id));
                lvDetaylar.Items[i].SubItems.Add(listem[i].Tip);
                lvDetaylar.Items[i].SubItems.Add(listem[i].Renk);
                lvDetaylar.Items[i].SubItems.Add(listem[i].Plaka);
                lvDetaylar.Items[i].SubItems.Add(listem[i].AracDurumu);
                lvDetaylar.Items[i].SubItems.Add(listem[i].GünlükFiyat.ToString());
            }            
        }

        private void lvDetaylar_DoubleClick(object sender, EventArgs e)
        {
            List<Arac> liste = ARep.AracListele();
            for (int i = 0; i < liste.Count; i++)
            {
                if (lvDetaylar.SelectedItems[0].SubItems[3].Text == liste[i].Plaka)
                {
                    Genel.AracID = liste[i].Id;                    
                }               
            }
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {//burada markaya göre plaka sorgulama olabilir. 
            txtMarka.Text = "Markalar";
            lvDetaylar.Items.Clear();
            List<Arac> liste = ARep.AracSorgulaByPlaka(txtPlaka.Text);
            int j = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                lvDetaylar.Items.Add(liste[i].Model, ResimIndisiGetir(liste[i].Id));
                lvDetaylar.Items[j].SubItems.Add(liste[i].Tip);
                lvDetaylar.Items[j].SubItems.Add(liste[i].Renk);
                lvDetaylar.Items[j].SubItems.Add(liste[i].Plaka);
                lvDetaylar.Items[j].SubItems.Add(liste[i].AracDurumu);
                lvDetaylar.Items[j].SubItems.Add(liste[i].GünlükFiyat.ToString());
                j++;
            }
            
        }
        private int ResimIndisiGetir(int ID)
        {
            int indis = 0;
            List<Arac> liste = ARep.AracListele();
            int[] diziID = new int[liste.Count];
            for (int i = 0; i < liste.Count; i++)
            {
                diziID[i] = liste[i].Id;               
            }
            for (int j = 0; j < liste.Count; j++)
            {
                if (ID == liste[j].Id)
                    indis = Array.IndexOf(diziID, liste[j].Id);
            }
            return indis;
        }
    }
}
