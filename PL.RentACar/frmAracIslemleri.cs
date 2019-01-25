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
    public partial class frmAracIslemleri : Form
    {
        public frmAracIslemleri()
        {
            InitializeComponent();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            txtMarka.Focus();
        }
    }
}
