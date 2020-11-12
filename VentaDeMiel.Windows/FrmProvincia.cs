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
    public partial class FrmProvincia : Form
    {
        public FrmProvincia()
        {
            InitializeComponent();
        }
        private ServicioProvincia _servicio;
        private List<Provincia> _lista;
        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioProvincia();
                _lista = _servicio.GetLista();
                MostrarEnGrilla();
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
        }

        private void MostrarEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var producto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, producto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[CmlProvincia.Index].Value = provincia.provincia;
            r.Cells[ClmPaisID.Index].Value = provincia.Pais.PaisID;
            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }
    }
}
