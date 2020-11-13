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
    public partial class FrmTiposDeProductosAE : Form
    {
        

        public FrmTiposDeProductosAE(FrmTiposDeProductos frmTiposDeProductos)
        {
            this.frm = frmTiposDeProductos;
            InitializeComponent();

        }

        public FrmTiposDeProductosAE()
        {
            InitializeComponent();
        }

        private TipoDeProducto tipoDeProducto;
        private bool _esEdicion = false;
        private ServicioTipoDeProducto _servicio = new ServicioTipoDeProducto();
        private FrmTiposDeProductos frmTipoDeProducto;

        private readonly FrmTiposDeProductos frm;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeProducto == null)
                {
                    tipoDeProducto = new TipoDeProducto();
                }

                tipoDeProducto.tipoDeProducto = textBoxTipoDeProducto.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(tipoDeProducto);
                            if (frm != null)
                            {
                                frm.AgregarFila(tipoDeProducto);

                            }
                            MessageBox.Show("Registro Guardado");
                            DialogResult dr = MessageBox.Show("¿Desea dar de alta otro registro?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.Cancel;
                            }
                            else
                            {
                                InicializarControles();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }

                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }
                }

            }
        }

        private void InicializarControles()
        {
            textBoxTipoDeProducto.Clear();
            textBoxTipoDeProducto.Focus();
            tipoDeProducto = null;
        }

        private bool ValidarObjeto()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(tipoDeProducto))
            {
                valido = false;
                errorProvider1.SetError(textBoxTipoDeProducto, "Tipo de producto repetido");
            }

            return valido;
        }

        internal void SetTipoDeProducto(TipoDeProducto tipodeproducto)
        {
            this.tipoDeProducto = tipodeproducto;
        }

        internal TipoDeProducto GetTipoDeProducto()
        {
            return tipoDeProducto;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(tipoDeProducto))
            {
                valido = false;
                errorProvider1.SetError(textBoxTipoDeProducto, "Tipo de producto repetido");
            }

            return valido;
        }

        private void FrmTiposDeProductosAE_Load(object sender, EventArgs e)
        {

        }
    }
}
