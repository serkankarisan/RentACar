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
            cbMarkalar.Items.Clear();
            cbMarkalar.DisplayMember = "Marka";
            cbMarkalar.DataSource = ARep.AracListele();
            ShowListView(ARep.AracListele());
            MessageBox.Show(cbMarkalar.SelectedIndex + "");
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvDetaylar.Items.Clear();
            List<Arac> liste = ARep.AracListele();
            //if (cbMarkalar.SelectedItem.ToString() == liste[cbMarkalar.SelectedIndex].Marka)
            //{
                lvDetaylar.Items.Add(liste[cbMarkalar.SelectedIndex].Model, cbMarkalar.SelectedIndex);
                lvDetaylar.Items[cbMarkalar.SelectedIndex].SubItems.Add(liste[cbMarkalar.SelectedIndex].Tip);
                lvDetaylar.Items[cbMarkalar.SelectedIndex].SubItems.Add(liste[cbMarkalar.SelectedIndex].Renk);
                lvDetaylar.Items[cbMarkalar.SelectedIndex].SubItems.Add(liste[cbMarkalar.SelectedIndex].Plaka);
                lvDetaylar.Items[cbMarkalar.SelectedIndex].SubItems.Add(liste[cbMarkalar.SelectedIndex].AracDurumu);
                lvDetaylar.Items[cbMarkalar.SelectedIndex].SubItems.Add(liste[cbMarkalar.SelectedIndex].GünlükFiyat.ToString());
                //lvDetaylar.Items.Add("Q7", 0);
                //lvDetaylar.Items[0].SubItems.Add("Jeep");
                //lvDetaylar.Items[0].SubItems.Add("Beyaz");
                //lvDetaylar.Items[0].SubItems.Add("34SDF56");
                //lvDetaylar.Items[0].SubItems.Add("Hasar Yok");
                //lvDetaylar.Items[0].SubItems.Add("700");

                //lvDetaylar.Items.Add("A7", 1);
                //lvDetaylar.Items[1].SubItems.Add("Sedan");
                //lvDetaylar.Items[1].SubItems.Add("Beyaz");
                //lvDetaylar.Items[1].SubItems.Add("34SDF56");
                //lvDetaylar.Items[1].SubItems.Add("Hasar Yok");
                //lvDetaylar.Items[1].SubItems.Add("600");

                //lvDetaylar.Items.Add("A3", 2);
                //lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("Hatchback");
                //lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("Beyaz");
                //lvDetaylar.Items[2].SubItems.Add("34SDF56");
                //lvDetaylar.Items[2].SubItems.Add("Hasar Yok");
                //lvDetaylar.Items[2].SubItems.Add("110");


            //}
        }
        private void ShowListView(List<Arac> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                lvDetaylar.Items.Add(liste[i].Model, 0);
                lvDetaylar.Items[i].SubItems.Add(liste[i].Tip);
                lvDetaylar.Items[i].SubItems.Add(liste[i].Renk);
                lvDetaylar.Items[i].SubItems.Add(liste[i].Plaka);
                lvDetaylar.Items[i].SubItems.Add(liste[i].AracDurumu);
                lvDetaylar.Items[i].SubItems.Add(liste[i].GünlükFiyat.ToString());
            }
            
        }
    }
}
