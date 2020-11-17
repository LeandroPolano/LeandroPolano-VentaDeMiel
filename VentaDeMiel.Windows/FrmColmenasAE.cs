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
    public partial class FrmColmenasAE : Form
    {
        public FrmColmenasAE()
        {
            InitializeComponent();
        }

        public FrmColmenasAE(FrmColmenas frmColmenas)
        {
            this.frm = frmColmenas;
            InitializeComponent();

        }

        internal void SetColmena(Colmena CantidadDeAlzas)
        {
            this.CantidadDeAlzas = CantidadDeAlzas;
        }

        internal Colmena GetColmena()
        {
            return CantidadDeAlzas;
        }

        private void FrmColmenasAE_Load(object sender, EventArgs e)
        {

        }
        private Colmena CantidadDeAlzas;
        private bool _esEdicion = false;
        private ServicioColmena _servicio = new ServicioColmena();
        private FrmColmenas frmColmenas;
        private readonly FrmColmenas frm;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (CantidadDeAlzas == null)
                {
                    CantidadDeAlzas = new Colmena();
                }

                CantidadDeAlzas.CantidadDeAlzas = TextBoxColmena.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(CantidadDeAlzas);
                            if (frm != null)
                            {
                                frm.AgregarFila(CantidadDeAlzas);

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
            TextBoxColmena.Clear();
            TextBoxColmena.Focus();
            CantidadDeAlzas = null;
        }

        private bool ValidarObjeto()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(CantidadDeAlzas))
            {
                valido = false;
                errorProvider1.SetError(TextBoxColmena, "Colmena repetida");
            }

            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (CantidadDeAlzas != null)
            {
                TextBoxColmena.Text = CantidadDeAlzas.CantidadDeAlzas;
                _esEdicion = true;
            }
        }
        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxColmena.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxColmena.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxColmena, "Debe ingresar una CantidadDeAlzas");
            }

            return valido;
        }

        private void TextBoxColmena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
