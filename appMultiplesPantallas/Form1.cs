using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMultiplesPantallas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliFacturas frmCliFac = new frmCliFacturas();
            frmCliFac.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdPrecios frmProdPre = new frmProdPrecios();
            frmProdPre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmActCliente frmActCli = new frmActCliente();
            frmActCli.Show();
        }
    }
}
