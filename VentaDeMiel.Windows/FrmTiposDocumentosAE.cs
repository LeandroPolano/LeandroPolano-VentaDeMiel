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
    public partial class FrmTiposDocumentosAE : Form
    {
        public FrmTiposDocumentosAE()
        {
            InitializeComponent();
        }

        public FrmTiposDocumentosAE(FrmTiposDocumentos frmTiposDocumentos)
        {
            this.frmTiposDocumentos = frmTiposDocumentos;
            InitializeComponent();
        }

        

        private void TextBoxTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        private tipoDocumento tipodocumento;
        private bool _esEdicion = false;
        private ServicioTipoDocumento _servicio = new ServicioTipoDocumento();
        private FrmTiposDocumentos frmTiposDocumentos;

        private readonly FrmTiposDocumentos frm;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipodocumento == null)
                {
                    tipodocumento = new tipoDocumento();
                }

                tipodocumento.TipoDocumento = TextBoxTipoDocumento.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(tipodocumento);
                            if (frm != null)
                            {
                                frm.AgregarFila(tipodocumento);

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
            TextBoxTipoDocumento.Clear();
            TextBoxTipoDocumento.Focus();
            tipodocumento = null;
        }

        private bool ValidarObjeto()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxTipoDocumento.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxTipoDocumento.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxTipoDocumento, "Debe ingresar un Tipo de documento");
            }

            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipodocumento != null)
            {
                TextBoxTipoDocumento.Text = tipodocumento.TipoDocumento;
                _esEdicion = true;
            }
        }
        

        private void TextBoxMarca_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(tipodocumento))
            {
                valido = false;
                errorProvider1.SetError(TextBoxTipoDocumento, "Tipo de documento repetido");
            }

            return valido;
        }

        internal tipoDocumento GetTipoDocumento()
        {
            return tipodocumento;
        }

        internal void SetTipoDocumento(tipoDocumento tipodocumento)
        {
            this.tipodocumento = tipodocumento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmTiposDocumentosAE_Load(object sender, EventArgs e)
        {

        }
    }
}
