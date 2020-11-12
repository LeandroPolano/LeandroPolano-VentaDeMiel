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
            FrmPaises frm = new FrmPaises();
            frm.ShowDialog(this);
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

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas frm = new FrmMarcas();
            frm.ShowDialog(this);
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTiposDocumentos frm = new FrmTiposDocumentos();
            frm.ShowDialog(this);
        }

        private void TsbTiposDeProductos_Click(object sender, EventArgs e)
        {
            FrmTiposDeProductos frm = new FrmTiposDeProductos();
            frm.ShowDialog(this);
        }

        private void TsbProvincias_Click(object sender, EventArgs e)
        {
            FrmProvincia frm = new FrmProvincia();
            frm.ShowDialog(this);
        }

        private void capacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapacidades frm = new FrmCapacidades();
            frm.ShowDialog(this);
        }
    }
}
