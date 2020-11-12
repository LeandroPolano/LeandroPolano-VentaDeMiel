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
    public class ServicioTipoDeProducto
    {
        private ConexionBD _conexion;
        private RepositorioTipoDeProducto _repositorio;

        public ServicioTipoDeProducto()
        {

        }
        public TipoDeProducto GetTipoDeProductoPorId(decimal id)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                var tipoDeProducto = _repositorio.GetTipoDeProductoPorId(id);
                _conexion.CerrarConexion();
                return tipoDeProducto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<TipoDeProducto> GetLista()
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(TipoDeProducto tipoDeProducto)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                _repositorio.Guardar(tipoDeProducto);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(decimal id)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                _repositorio.Borrar(id);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeProducto tipoDeProducto)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(tipoDeProducto);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeProducto tipoDeProducto)
        {
            try
            {
                _conexion = new ConexionBD();
                _repositorio = new RepositorioTipoDeProducto(_conexion.AbrirConexion());
                var existe = _repositorio.EstaRelacionado(tipoDeProducto);
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
