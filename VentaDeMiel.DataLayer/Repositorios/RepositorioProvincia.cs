using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
    public class RepositorioProvincia
    {
        private readonly SqlConnection _connection;
        private readonly RepositorioPais _repositorioPais;
        private readonly SqlTransaction _tran;

        public RepositorioProvincia(SqlConnection connection, RepositorioPais repositorioPais)
        {
            _connection = connection;
            _repositorioPais = repositorioPais;

        }

        public RepositorioProvincia(SqlConnection connection)
        {
            _connection = connection;
        }

        public RepositorioProvincia(SqlConnection cn, SqlTransaction tran)
        {
            _connection = cn;
            _tran = tran;
        }

        public Provincia GetProvinciaPorId(int id)
        {
            Provincia p = null;
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, Provincia, PaisId FROM Provincias WHERE ProvinciaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    p = ConstruirProvinciaTotal(reader);
                }
                reader.Close();
                return p;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        private Provincia ConstruirProvinciaTotal(SqlDataReader reader)
        {
            Provincia provincia = new Provincia();
            provincia.ProvinciaID = reader.GetInt32(0);
            provincia.provincia = reader.GetString(1);
            provincia.Pais = _repositorioPais.GetPaisPorId(reader.GetInt32(2));
           
            return provincia;

        }

        public List<Provincia> GetLista()
        {
            List<Provincia> lista = new List<Provincia>();
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, Provincia, PaisId " +
                    " FROM Provincias";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincia = ConstruirProvincia(reader);
                    lista.Add(provincia);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        private Provincia ConstruirProvincia(SqlDataReader reader)
        {
            Provincia provincia = new Provincia();
            provincia.ProvinciaID = reader.GetInt32(0);
            provincia.provincia = reader.GetString(1);
            provincia.Pais = _repositorioPais.GetPaisPorId(reader.GetInt32(2));
            
            return provincia;

        }
        public void Guardar(Provincia provincia)
        {
            try
            {
                string cadenaComando = "INSERT INTO Provincias (Provincia, PaisId ) VALUES (@desc, @pais, " +
                                       ")";
                var comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@desc", provincia.provincia);
                comando.Parameters.AddWithValue("@pais", provincia.Pais.PaisID);            
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _connection);
                int id = (int)(decimal)comando.ExecuteScalar();
                provincia.ProvinciaID = id;




            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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

        public void ActualizarStock(Provincia provincia, decimal cantidad)
        {
            try
            {
                string cadenaComando = "UPDATE Provincias SET Stock=Stock+@cant WHERE ProvinciaId=@id";
                var comando = new SqlCommand(cadenaComando, _connection, _tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", provincia.ProvinciaID);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al actualizar el stock de un provincia");
            }
        }

        

        public List<Provincia> GetLista(int paisId)
        {
            List<Provincia> lista = new List<Provincia>();
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, Provincia, PaisId " +
                    " FROM Provincias WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", paisId);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincia = ConstruirProvincia(reader);
                    lista.Add(provincia);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Provincia> GetLista(string provincia)
        {
            List<Provincia> lista = new List<Provincia>();
            try
            {
                string cadenaComando =
                    "SELECT ProvinciaId, Provincia, PaisId " +
                    " FROM Provincias WHERE Provincia LIKE @desc";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@desc", $"%{provincia}%");
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincias = ConstruirProvincia(reader);
                    lista.Add(provincias);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
