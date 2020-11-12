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
    public partial class FrmTiposDeProductos : Form
    {
        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmTiposDeProductosAE frm = new FrmTiposDeProductosAE(this);
            frm.Text = "Nueva Marca";
            DialogResult dr = frm.ShowDialog(this);
        }
        public FrmTiposDeProductos()
        {
            InitializeComponent();
        }
        internal void AgregarFila(TipoDeProducto tipoDeProducto)
        {
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, tipoDeProducto);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeProducto tipoDeProducto)
        {
            r.Cells[CmlTipoDeProducto.Index].Value = tipoDeProducto.tipoDeProducto;

            r.Tag = tipoDeProducto;
        }

        private ServicioTipoDeProducto _servicio;
        private List<TipoDeProducto> _lista;

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                TipoDeProducto tipodeproducto = (TipoDeProducto)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"¿Desea dar de baja el Tipo de producto {tipodeproducto.tipoDeProducto}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(tipodeproducto.TipoDeProductoID);
                        DatosDataGridView.Rows.Remove(r);
                        MessageBox.Show("Registro borrado");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);

                    }
                }
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                TipoDeProducto tipodeproducto = (TipoDeProducto)r.Tag;
                FrmTiposDeProductosAE frm = new FrmTiposDeProductosAE();
                frm.Text = "Editar Tipo de producto";
                frm.SetTipoDeProducto(tipodeproducto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipodeproducto = frm.GetTipoDeProducto();
                        if (!_servicio.Existe(tipodeproducto))
                        {
                            _servicio.Guardar(tipodeproducto);
                            SetearFila(r, tipodeproducto);
                            MessageBox.Show("Registro Editado");
                        }
                        else
                        {
                            MessageBox.Show("Tipo De Producto Repetido");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void CerrarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTiposDeProductos_Load(object sender, EventArgs e)
        {
            try
            {
                _servicio = new ServicioTipoDeProducto();
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
            foreach (var marca in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, marca);
                AgregarFila(r);
            }
        }
    }
}
