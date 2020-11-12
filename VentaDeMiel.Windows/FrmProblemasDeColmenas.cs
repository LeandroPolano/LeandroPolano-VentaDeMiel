﻿using System;
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
        private void FrmProblemaDeColmena_Load(object sender, EventArgs e)
        {
            try
            {
                Iniciar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Iniciar()
        {
            _servicio = new ServicioProblemaDeColmena();
            _lista = _servicio.GetLista();
            MostrarEnGrilla();
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

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmProblemasDeColmenasAE frm = new FrmProblemasDeColmenasAE(this);
            frm.Text = "Nueva Problema";
            DialogResult dr = frm.ShowDialog(this);
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                ProblemaDeColmena problema = (ProblemaDeColmena)r.Tag;

                DialogResult dr = MessageBox.Show(this, $"¿Desea dar de baja el problema {problema.TipoDeProblema}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        _servicio.Borrar(problema.ProblemaID);
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
                ProblemaDeColmena problema = (ProblemaDeColmena)r.Tag;
                FrmProblemasDeColmenasAE frm = new FrmProblemasDeColmenasAE();
                frm.Text = "Editar Problema";
                frm.SetProblema(problema);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        problema = frm.GetProblema();
                        if (!_servicio.Existe(problema))
                        {
                            _servicio.Guardar(problema);
                            SetearFila(r, problema);
                            MessageBox.Show("Registro Editado");
                        }
                        else
                        {
                            MessageBox.Show("Problema Repetido");
                            Iniciar();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
