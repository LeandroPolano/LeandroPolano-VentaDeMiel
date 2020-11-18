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
    public partial class FrmColmenaresAE : Form
    {
        public FrmColmenaresAE()
        {
            InitializeComponent();
        }

            private FrmColmenares frm;
        public FrmColmenaresAE(FrmColmenares frm)
        {
            InitializeComponent();
            this.frm = frm;

        }


        private readonly ServicioColmenar _servicioCiudades = new ServicioColmenar();
        private readonly ServicioCiudad _servicioCiudad = new ServicioCiudad();

        private Colmenar colmenar;
        private ServicioColmenar _servicio = new ServicioColmenar();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ServicioCiudad servicioCiudad = new ServicioCiudad();
            ComboBoxCiudad.DataSource = null;
            List<Ciudad> lista = servicioCiudad.GetLista();
            var defaultMedida = new Ciudad { CiudadID = 0, ciudad = "[Seleccione]" };
            lista.Insert(0, defaultMedida);
            ComboBoxCiudad.DataSource = lista;
            ComboBoxCiudad.DisplayMember = "ciudad";
            ComboBoxCiudad.ValueMember = "CiudadID";
            ComboBoxCiudad.SelectedIndex = 0;
            if (colmenar != null)
            {
                ComboBoxCiudad.SelectedValue = colmenar.Ciudad.CiudadID;
                textBoxColmenar.Text = colmenar.NombreColmenar;

            }
        }

        private bool _esEdicion = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (colmenar == null)
                {
                    colmenar = new Colmenar();
                }

                colmenar.Ciudad = (Ciudad)ComboBoxCiudad.SelectedItem;
                colmenar.NombreColmenar = textBoxColmenar.Text;
                if (ValidarObjeto())
                {

                    if (!_esEdicion)
                    {
                        try
                        {
                            _servicio.Guardar(colmenar);
                            if (frm != null)
                            {
                                frm.AgregarFila(colmenar);

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
            var valido = true;
            errorProvider1.Clear();
            if (ComboBoxCiudad.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ComboBoxCiudad, "Debe seleccionar una Ciudad");
            }

            if (string.IsNullOrEmpty(textBoxColmenar.Text) ||
                string.IsNullOrWhiteSpace(textBoxColmenar.Text))
            {
                valido = false;
                errorProvider1.SetError(textBoxColmenar, "Debe ingresar una colmenar");
            }


            return valido;
        }

        private void InicializarControles()
        {

            colmenar = null;
            ComboBoxCiudad.SelectedIndex = 0;
        }

        private bool ValidarObjeto()
        {
            var valido = true;
            errorProvider1.Clear();
            if (_servicio.Existe(colmenar))
            {
                valido = false;
                errorProvider1.SetError(textBoxColmenar, "Colmenar repetido");
            }

            return valido;
        }

       public void SetColmenar(Colmenar Colmenar)
        {
            this.colmenar = Colmenar;
        }

        public Colmenar GetColmenar()
        {
            return colmenar;
        }

        private void FrmColmenaresAE_Load(object sender, EventArgs e)
        {

        }
    }
    
}
