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
    public partial class frmSozlesmeSorgulama : Form
    {
        public frmSozlesmeSorgulama()
        {
            InitializeComponent();
        }
        SozlesmeRepository sr = new SozlesmeRepository();
        private void frmSozlesmeSorgulama_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = sr.SozlesmeListele();
        }

        private void dgvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            Genel.SozID = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            Genel.MusteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[2].Value);
            this.Close();
        }
    }
}
