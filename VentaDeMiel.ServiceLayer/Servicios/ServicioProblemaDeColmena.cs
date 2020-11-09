using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;
using VentaDeMiel.DataLayer;
using VentaDeMiel.DataLayer.Repositorios;

namespace VentaDeMiel.ServiceLayer.Servicios
{
    public class ServicioProblemaDeColmena
    {

        private ConexionBD _conexion;
        private RepositorioProblemaDeColmena _repositorio;

        public ServicioProblemaDeColmena()
        {

        }
        public ProblemaDeColmena GetProblemaDeColmenaPorId(int id)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                var problemaDeColmena = _repositorio.GetProblemaDeColmenaPorId(id);
                _conexion.CerrarConexion();
                return problemaDeColmena;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<ProblemaDeColmena> GetLista()
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(ProblemaDeColmena problemaDeColmena)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                _repositorio.Guardar(problemaDeColmena);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int id)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                _repositorio.Borrar(id);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(ProblemaDeColmena problemaDeColmena)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(problemaDeColmena);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(ProblemaDeColmena problemaDeColmena)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioProblemaDeColmena(_conexion.AbrirConexion());
                var existe = _repositorio.EstaRelacionado(problemaDeColmena);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
