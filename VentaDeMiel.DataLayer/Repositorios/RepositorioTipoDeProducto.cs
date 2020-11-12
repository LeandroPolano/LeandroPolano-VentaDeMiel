using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
   public class RepositorioTipoDeProducto
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioTipoDeProducto(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public TipoDeProducto GetTipoDeProductoPorId(decimal id)
        {
            try
            {
                TipoDeProducto tiposDeProductos = null;
                string cadenaComando = "SELECT TipoProductoID, TipoProducto FROM TiposDeProductos WHERE TipoProductoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    tiposDeProductos = ConstruirTipoDeProducto(reader);
                    reader.Close();
                }

                return tiposDeProductos;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<TipoDeProducto> GetLista()
        {
            List<TipoDeProducto> lista = new List<TipoDeProducto>();
            try
            {
                string cadenaComando = "SELECT TipoProductoID, TipoProducto FROM TiposDeProductos";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoDeProducto tiposDeProductos = ConstruirTipoDeProducto(reader);
                    lista.Add(tiposDeProductos);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TipoDeProducto ConstruirTipoDeProducto(SqlDataReader reader)
        {

            var producto = new TipoDeProducto();
            producto.TipoDeProductoID = reader.GetDecimal(0);
            producto.tipoDeProducto = reader.GetString(1);
            return producto;

        }

        public void Guardar(TipoDeProducto tiposDeProductos)
        {
            if (tiposDeProductos.TipoDeProductoID == 0)
            {

                try
                {
                    string cadenaComando = "INSERT INTO TiposDeProductos VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tiposDeProductos.tipoDeProducto);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    tiposDeProductos.TipoDeProductoID = (int)(decimal)comando.ExecuteScalar();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            else
            {

                try
                {
                    string cadenaComando = "UPDATE TiposDeProductos SET TipoProducto=@nombre WHERE TipoProductoID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tiposDeProductos.tipoDeProducto);
                    comando.Parameters.AddWithValue("@id", tiposDeProductos.TipoDeProductoID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public void Borrar(decimal id)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeProductos WHERE TipoProductoID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDeProducto tiposDeProductos)
        {
            try
            {
                SqlCommand comando;
                if (tiposDeProductos.TipoDeProductoID == 0)
                {
                    string cadenaComando = "SELECT TipoProductoID, TipoProducto FROM TiposDeProductos WHERE TipoProducto=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tiposDeProductos.tipoDeProducto);

                }
                else
                {
                    string cadenaComando = "SELECT TipoProductoID, TipoProducto FROM TiposDeProductos WHERE TipoProducto=@nombre AND TipoProductoID<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tiposDeProductos.tipoDeProducto);
                    comando.Parameters.AddWithValue("@id", tiposDeProductos.TipoDeProductoID);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDeProducto tiposDeProductos)
        {
            try
            {
                var CadenaDeComando = "select TipoProductoID from Productos where TipoProductoID = @Id";
                var Comando = new SqlCommand(CadenaDeComando, _sqlConnection);
                Comando.Parameters.AddWithValue("@Id", tiposDeProductos.TipoDeProductoID);
                var reader = Comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
