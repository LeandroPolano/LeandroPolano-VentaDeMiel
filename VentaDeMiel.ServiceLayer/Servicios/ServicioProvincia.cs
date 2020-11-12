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
    public class ServicioProvincia
    {

        private RepositorioProvincia _repositorioProvincia;
        private RepositorioPais _repositorioPais;
       
        private ConexionBD _conexion;
        public Provincia GetProvinciaPorId(int id)
        {
            _conexion = new ConexionBD();
            _repositorioPais = new RepositorioPais(_conexion.AbrirConexion());
            _repositorioProvincia = new RepositorioProvincia(_conexion.AbrirConexion(), _repositorioPais);
            var p = _repositorioProvincia.GetProvinciaPorId(id);
            _conexion.CerrarConexion();
            return p;

        }

        public List<Provincia> GetLista()
        {
            _conexion = new ConexionBD();
            _repositorioPais = new RepositorioPais(_conexion.AbrirConexion());
            _repositorioProvincia = new RepositorioProvincia(_conexion.AbrirConexion(), _repositorioPais);
            var lista = _repositorioProvincia.GetLista();
            _conexion.CerrarConexion();
            return lista;

        }

        public void Guardar(Provincia provincia)
        {
            _conexion = new ConexionBD();
            _repositorioProvincia = new RepositorioProvincia(_conexion.AbrirConexion());
            _repositorioProvincia.Guardar(provincia);
            _conexion.CerrarConexion();
        }

        public void Borrar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            throw new System.NotImplementedException();
        }

        

        public List<Provincia> GetLista(int paisId)
        {
            _conexion = new ConexionBD();
            _repositorioPais = new RepositorioPais(_conexion.AbrirConexion());
            _repositorioProvincia = new RepositorioProvincia(_conexion.AbrirConexion(), _repositorioPais);
            var lista = _repositorioProvincia.GetLista(paisId);
            _conexion.CerrarConexion();
            return lista;

        }

        public List<Provincia> GetLista(string provincia)
        {
            _conexion = new ConexionBD();
            _repositorioPais = new RepositorioPais(_conexion.AbrirConexion());
            _repositorioProvincia = new RepositorioProvincia(_conexion.AbrirConexion(), _repositorioPais);
            var lista = _repositorioProvincia.GetLista(provincia);
            _conexion.CerrarConexion();
            return lista;
        }
    }
}
