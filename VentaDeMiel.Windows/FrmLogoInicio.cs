using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeClase.ReportLayer;

namespace VentaDeMiel.Windows
{
    public partial class FrmLogoInicio : Form
    {
        public FrmLogoInicio()
        {
            InitializeComponent();
        }
        private void FrmLogoInicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void FrmLogoInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuPrincipal FM = new FrmMenuPrincipal();
            FM.ShowDialog(this);
        }
    }
}
