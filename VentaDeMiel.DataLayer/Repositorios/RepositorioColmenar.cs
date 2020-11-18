using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
    public class RepositorioColmenar
    {
        private readonly SqlConnection _connection;
        private readonly RepositorioCiudad _repositorioCiudad;
        private readonly SqlTransaction _tran;

        public RepositorioColmenar(SqlConnection connection, RepositorioCiudad repositorioCiudad)
        {
            _connection = connection;
            _repositorioCiudad = repositorioCiudad;

        }

        public RepositorioColmenar(SqlConnection connection)
        {
            _connection = connection;
        }

        public RepositorioColmenar(SqlConnection cn, SqlTransaction tran)
        {
            _connection = cn;
            _tran = tran;
        }

        public Colmenar GetColmenarPorId(decimal id)
        {
            Colmenar p = null;
            try
            {
                string cadenaComando =
                    "SELECT ColmenarId, NombreColmenar, CiudadId FROM Colmenares WHERE ColmenarId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    p = ConstruirColmenar(reader);
                }
                reader.Close();
                return p;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }



        public List<Colmenar> GetLista()
        {
            List<Colmenar> lista = new List<Colmenar>();
            try
            {
                string cadenaComando =
                    "SELECT ColmenarId, NombreColmenar, CiudadId " +
                    " FROM Colmenares";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Colmenar colmenar = ConstruirColmenar(reader);
                    lista.Add(colmenar);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Colmenar ConstruirColmenar(SqlDataReader reader)
        {
            Colmenar colmenar = new Colmenar();
            colmenar.ColmenarID = reader.GetDecimal(0);
            colmenar.NombreColmenar = reader.GetString(1);
            colmenar.Ciudad = _repositorioCiudad.GetCiudadPorId(reader.GetDecimal(2));

            return colmenar;

        }
        public void Guardar(Colmenar colmenar)
        {
            if (colmenar.ColmenarID == 0)
            {
                try
                {
                    string cadenaComando = "INSERT INTO Colmenares (NombreColmenar, CiudadId ) VALUES (@desc, @ciudad)";
                    var comando = new SqlCommand(cadenaComando, _connection);
                    comando.Parameters.AddWithValue("@desc", colmenar.NombreColmenar);
                    comando.Parameters.AddWithValue("@ciudad", colmenar.Ciudad.CiudadID);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _connection);
                    int id = (int)(decimal)comando.ExecuteScalar();
                    colmenar.ColmenarID = id;




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
                    string cadenaComando = "UPDATE Colmenares SET NombreColmenar=@nombre,CiudadId=@ciudadId WHERE ColmenarId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                    comando.Parameters.AddWithValue("@nombre", colmenar.NombreColmenar);
                    comando.Parameters.AddWithValue("@ciudadId", colmenar.Ciudad.CiudadID);
                    comando.Parameters.AddWithValue("@id", colmenar.ColmenarID);
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
                string cadenaComando = "DELETE FROM Colmenares WHERE ColmenarID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Colmenar colmenar)
        {
            try
            {
                SqlCommand comando;
                if (colmenar.ColmenarID == 0)
                {
                    string cadenaComando = "SELECT ColmenarID, NombreColmenar,CiudadID FROM Colmenares WHERE CiudadID=@ciudad AND NombreColmenar=@nombre";
                    comando = new SqlCommand(cadenaComando, _connection);
                    comando.Parameters.AddWithValue("@nombre", colmenar.NombreColmenar);
                    comando.Parameters.AddWithValue("@ciudad", colmenar.Ciudad.CiudadID);

                }
                else
                {
                    string cadenaComando = "SELECT ColmenarID, NombreColmenar,CiudadID FROM Colmenares WHERE CiudadID=@ciudad AND NombreColmenar=@nombre AND ColmenarID<>@id";
                    comando = new SqlCommand(cadenaComando, _connection);
                    comando.Parameters.AddWithValue("@nombre", colmenar.NombreColmenar);
                    comando.Parameters.AddWithValue("@id", colmenar.ColmenarID);
                    comando.Parameters.AddWithValue("@ciudad", colmenar.Ciudad.CiudadID);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Colmenar colmenar)
        {
            throw new System.NotImplementedException();
        }

        public void ActualizarStock(Colmenar colmenar, decimal cantidad)
        {
            try
            {
                string cadenaComando = "UPDATE Colmenares SET Stock=Stock+@cant WHERE ColmenarId=@id";
                var comando = new SqlCommand(cadenaComando, _connection, _tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", colmenar.ColmenarID);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al actualizar el stock de un colmenar");
            }
        }



        public List<Colmenar> GetLista(int ciudadId)
        {
            List<Colmenar> lista = new List<Colmenar>();
            try
            {
                string cadenaComando =
                    "SELECT ColmenarId, NombreColmenar, CiudadId " +
                    " FROM Colmenares WHERE CiudadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@id", ciudadId);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Colmenar colmenar = ConstruirColmenar(reader);
                    lista.Add(colmenar);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Colmenar> GetLista(string colmenar)
        {
            List<Colmenar> lista = new List<Colmenar>();
            try
            {
                string cadenaComando =
                    "SELECT ColmenarId, NombreColmenar, CiudadId " +
                    " FROM Colmenares WHERE NombreColmenar LIKE @desc";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                comando.Parameters.AddWithValue("@desc", $"%{colmenar}%");
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Colmenar colmenars = ConstruirColmenar(reader);
                    lista.Add(colmenars);
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
