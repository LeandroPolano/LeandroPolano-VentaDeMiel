using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
    public class RepositorioColmena
    {
        private readonly SqlConnection _sqlConnection;

        public RepositorioColmena(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public Colmena GetColmenaPorId(decimal id)
        {
            try
            {
                Colmena CantidadDeAlzas = null;
                string cadenaComando = "SELECT ColmenaID, CantidadDeAlzas FROM Colmenas WHERE ColmenaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    CantidadDeAlzas = ConstruirColmena(reader);
                    reader.Close();
                }

                return CantidadDeAlzas;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Colmena> GetLista()
        {
            List<Colmena> lista = new List<Colmena>();
            try
            {
                string cadenaComando = "SELECT ColmenaID, CantidadDeAlzas FROM Colmenas";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Colmena CantidadDeAlzas = ConstruirColmena(reader);
                    lista.Add(CantidadDeAlzas);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Colmena ConstruirColmena(SqlDataReader reader)
        {

            var CantidadDeAlzas = new Colmena();
            CantidadDeAlzas.ColmenaID = reader.GetDecimal(0);
            CantidadDeAlzas.CantidadDeAlzas = reader.GetString(1);
            return CantidadDeAlzas;

        }

        public void Guardar(Colmena CantidadDeAlzas)
        {
            if (CantidadDeAlzas.ColmenaID == 0)
            {

                try
                {
                    string cadenaComando = "INSERT INTO Colmenas VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", CantidadDeAlzas.CantidadDeAlzas);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    CantidadDeAlzas.ColmenaID = (int)(decimal)comando.ExecuteScalar();

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
                    string cadenaComando = "UPDATE Colmenas SET CantidadDeAlzas=@nombre WHERE ColmenaID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", CantidadDeAlzas.CantidadDeAlzas);
                    comando.Parameters.AddWithValue("@id", CantidadDeAlzas.ColmenaID);
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
                string cadenaComando = "DELETE FROM Colmenas WHERE ColmenaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Colmena CantidadDeAlzas)
        {
            try
            {
                SqlCommand comando;
                if (CantidadDeAlzas.ColmenaID == 0)
                {
                    string cadenaComando = "SELECT ColmenaID, CantidadDeAlzas FROM Colmenas WHERE CantidadDeAlzas=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", CantidadDeAlzas.CantidadDeAlzas);

                }
                else
                {
                    string cadenaComando = "SELECT ColmenaID, CantidadDeAlzas FROM Colmenas WHERE CantidadDeAlzas=@nombre AND ColmenaID<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", CantidadDeAlzas.CantidadDeAlzas);
                    comando.Parameters.AddWithValue("@id", CantidadDeAlzas.ColmenaID);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Colmena CantidadDeAlzas)
        {
            try
            {
                var CadenaDeComando = "select ColmenaID from ColmenaColmenares where ColmenaID = @Id";
                var Comando = new SqlCommand(CadenaDeComando, _sqlConnection);
                Comando.Parameters.AddWithValue("@Id", CantidadDeAlzas.ColmenaID);
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
