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
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RentACarDataSet2.KasaHareketler' table. You can move, or remove it, as needed.
            this.KasaHareketlerTableAdapter.Fill(this.RentACarDataSet2.KasaHareketler);
            // TODO: This line of code loads data into the 'RentACarDataSet1.MusteriHareketler' table. You can move, or remove it, as needed.
            this.MusteriHareketlerTableAdapter.Fill(this.RentACarDataSet1.MusteriHareketler);
            // TODO: This line of code loads data into the 'RentACarDataSet.Personeller' table. You can move, or remove it, as needed.
            this.PersonellerTableAdapter.Fill(this.RentACarDataSet.Personeller);
            // TODO: This line of code loads data into the 'RentACarDataSetArac.Araclar' table. You can move, or remove it, as needed.
            this.AraclarTableAdapter.Fill(this.RentACarDataSetArac.Araclar);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
