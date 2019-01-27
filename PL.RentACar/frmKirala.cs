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
    public partial class frmKirala : Form
    {
        public frmKirala()
        {
            InitializeComponent();
        }

        //private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lvDetaylar.Items.Clear();
        //    if (cbMarkalar.SelectedItem.ToString() == "Audi")
        //    {
        //        lvDetaylar.Items.Add("Q7", 0);
        //        lvDetaylar.Items[0].SubItems.Add("Jeep");
        //        lvDetaylar.Items[0].SubItems.Add("Beyaz");
        //        lvDetaylar.Items[0].SubItems.Add("34ASD12");
        //        lvDetaylar.Items[0].SubItems.Add("Hasar Yok");
        //        lvDetaylar.Items[0].SubItems.Add("500");

        //        lvDetaylar.Items.Add("A7", 1);
        //        lvDetaylar.Items[1].SubItems.Add("Sedan");
        //        lvDetaylar.Items[1].SubItems.Add("Beyaz");
        //        lvDetaylar.Items[1].SubItems.Add("34ERT34");
        //        lvDetaylar.Items[1].SubItems.Add("Hafif çizik var");
        //        lvDetaylar.Items[1].SubItems.Add("600");

        //        lvDetaylar.Items.Add("A4", 2);
        //        lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("Hatchback");
        //        lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("Beyaz");
        //        lvDetaylar.Items[2].SubItems.Add("34ERT56");
        //        lvDetaylar.Items[2].SubItems.Add("Hasar Yok");
        //        lvDetaylar.Items[2].SubItems.Add("400");
        //    }
        //    else if (cbMarkalar.SelectedItem.ToString() == "Renault")
        //    {
        //        lvDetaylar.Items.Add("Galaxy A9", 0);
        //        lvDetaylar.Items[0].SubItems.Add("1,5 GHz");
        //        lvDetaylar.Items[0].SubItems.Add("4 GB");
        //        lvDetaylar.Items[0].SubItems.Add("5,5 \"");
        //        lvDetaylar.Items[0].SubItems.Add("10 MP");
        //        lvDetaylar.Items[0].SubItems.Add("4500");

        //        lvDetaylar.Items.Add("Galaxy S9", 1);
        //        lvDetaylar.Items[1].SubItems.Add("1,6 GHz");
        //        lvDetaylar.Items[1].SubItems.Add("6 GB");
        //        lvDetaylar.Items[1].SubItems.Add("5,7 \"");
        //        lvDetaylar.Items[1].SubItems.Add("12 MP");
        //        lvDetaylar.Items[1].SubItems.Add("6000");

        //        lvDetaylar.Items.Add("Galaxy Note9", 2);
        //        lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("1,8 GHz");
        //        lvDetaylar.Items[lvDetaylar.Items.Count - 1].SubItems.Add("8 GB");
        //        lvDetaylar.Items[2].SubItems.Add("5,8 \"");
        //        lvDetaylar.Items[2].SubItems.Add("15 MP");
        //        lvDetaylar.Items[2].SubItems.Add("11000");
        //    }
        //}

        //private void mitmLargeIcon_Click(object sender, EventArgs e)
        //{
        //    lvDetaylar.View = View.LargeIcon;

        //}

        //private void mitmDetails_Click(object sender, EventArgs e)
        //{
        //    lvDetaylar.View = View.Details;

        //}

        //private void mitmSmallIcon_Click(object sender, EventArgs e)
        //{
        //    lvDetaylar.View = View.SmallIcon;

        //}

        //private void mitmList_Click(object sender, EventArgs e)
        //{
        //    lvDetaylar.View = View.List;

        //}

        //private void mitmTile_Click(object sender, EventArgs e)
        //{
        //    lvDetaylar.View = View.Tile;

        //}

       
    }
}
