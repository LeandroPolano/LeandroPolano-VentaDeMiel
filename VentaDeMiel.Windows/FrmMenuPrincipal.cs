using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel.Windows;

namespace VentaDeClase.ReportLayer
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

       

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProblemasDeColmenas_Click(object sender, EventArgs e)
        {
            FrmProblemasDeColmenas frm = new FrmProblemasDeColmenas();
            frm.ShowDialog(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
