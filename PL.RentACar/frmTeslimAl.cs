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
    public partial class frmTeslimAl : Form
    {
        public frmTeslimAl()
        {
            InitializeComponent();
        }

        frmSozlesmeSorgulama frm = new frmSozlesmeSorgulama();
        SozlesmeDetayRepository sdr = new SozlesmeDetayRepository();
        private void btnSec_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();

            dgvSozlesmeDetay.DataSource = sdr.SozlesmeDetayListeleBySozlesmeId(Genel.SozID);
        }

      
    }
}
