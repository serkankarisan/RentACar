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
        int ID;
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
                List<Arac> liste = ARep.AracListele();
                int j = 0;
                for (int i = 0; i < liste.Count; i++)
                {
                    if (cbMarkalar.SelectedItem.ToString() == liste[i].Marka)
                    {
                        lvDetaylar.Items.Add(liste[i].Model, i);
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
            for (int i = 0; i < listem.Count; i++)
            {
                lvDetaylar.Items.Add(listem[i].Model, i);
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
                    ID = liste[i].Id;
                    
                }               

            }
            MessageBox.Show("" + ID);
        }
    }
}
