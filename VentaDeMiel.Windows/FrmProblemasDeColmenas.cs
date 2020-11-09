using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel.BusinessLayer.Entities;
using VentaDeMiel.ServiceLayer.Servicios;

namespace VentaDeMiel.Windows
{
    public partial class FrmProblemasDeColmenas : Form
    {
        public FrmProblemasDeColmenas()
        {
            InitializeComponent();
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProblemasDeColmenas_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioProblemaDeColmena();
                _lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void MostrarEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var Problema in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, Problema);
                AgregarFila(r);
            }
        }
        public void AgregarFila(ProblemaDeColmena problema)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, problema);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, ProblemaDeColmena problema)
        {
            r.Cells[CmlTipoDeProblema.Index].Value = problema.TipoDeProblema;

            r.Tag = problema;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private ServicioProblemaDeColmena _servicio;
        private List<ProblemaDeColmena> _lista;
    }
}
