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
    public partial class FrmProblemasDeColmenasAE : Form
    {
        public FrmProblemasDeColmenasAE()
        {
            InitializeComponent();
        }

        public FrmProblemasDeColmenasAE(FrmProblemasDeColmenas frmProblemasDeColmenas)
        {
            this.frm = frmProblemasDeColmenas;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (problemaDeColmena != null)
            {
                TextBoxProblema.Text = problemaDeColmena.TipoDeProblema;
                _esEdicion = true;
            }
        }
        internal void SetProblema(ProblemaDeColmena problema)
        {
            this.problemaDeColmena = problema; 
        }

        internal ProblemaDeColmena GetProblema()
        {
            return problemaDeColmena;
        }
        private ProblemaDeColmena problemaDeColmena;
        private bool _esEdicion = false;
        private ServicioProblemaDeColmena _servicio = new ServicioProblemaDeColmena();
        private FrmProblemasDeColmenas frmProblemasDeColmenas;
        private readonly FrmProblemasDeColmenas frm;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if ( problemaDeColmena== null)
                {
                    problemaDeColmena = new ProblemaDeColmena();
                }

                problemaDeColmena.TipoDeProblema = TextBoxProblema.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(problemaDeColmena);
                            if (frm != null)
                            {
                                frm.AgregarFila(problemaDeColmena);

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

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(TextBoxProblema.Text.Trim()) &&
                string.IsNullOrWhiteSpace(TextBoxProblema.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TextBoxProblema, "Debe ingresar un Problema");
            }

            return valido;
        }

        private void InicializarControles()
        {
            TextBoxProblema.Clear();
            TextBoxProblema.Focus();
            problemaDeColmena = null;
        }

        private bool ValidarObjeto()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(problemaDeColmena))
            {
                valido = false;
                errorProvider1.SetError(TextBoxProblema, "Problema repetido");
            }

            return valido;
        }

        private void FrmProblemasDeColmenasAE_Load(object sender, EventArgs e)
        {

        }
    }
}
