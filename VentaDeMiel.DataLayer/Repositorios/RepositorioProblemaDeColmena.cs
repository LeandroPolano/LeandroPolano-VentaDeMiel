using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
    public class RepositorioProblemaDeColmena
    {
         private readonly SqlConnection _sqlConnection;

        public RepositorioProblemaDeColmena(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public ProblemaDeColmena GetProblemaDeColmenaPorId(int id)
        {
            try
            {
                ProblemaDeColmena problemaDeColmena = null;
                string cadenaComando = "SELECT ProblemaID, TipoDeProblema FROM ProblemasDeColmenas WHERE ProblemaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    problemaDeColmena = ConstruirProblemaDeColmena(reader);
                    reader.Close();
                }

                return problemaDeColmena;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<ProblemaDeColmena> GetLista()
        {
            List<ProblemaDeColmena> lista = new List<ProblemaDeColmena>();
            try
            {
                string cadenaComando = "SELECT ProblemaID, TipoDeProblema FROM ProblemasDeColmenas";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    ProblemaDeColmena problemaDeColmena = ConstruirProblemaDeColmena(reader);
                    lista.Add(problemaDeColmena);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private ProblemaDeColmena ConstruirProblemaDeColmena(SqlDataReader reader)
        {

            var problema = new ProblemaDeColmena();
            problema.ProblemaID = reader.GetDecimal(0);
            problema.TipoDeProblema = reader.GetString(1);
            return problema;

        }

        public void Guardar(ProblemaDeColmena problemaDeColmena)
        {
            if (problemaDeColmena.ProblemaID == 0)
            {
                
                try
                {
                    string cadenaComando = "INSERT INTO ProblemasDeColmenas VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", problemaDeColmena.TipoDeProblema);

                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    problemaDeColmena.ProblemaID = (int)(decimal)comando.ExecuteScalar();

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
                    string cadenaComando = "UPDATE ProblemasDeColmenas SET TipoDeProblema=@nombre WHERE ProblemaID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", problemaDeColmena.TipoDeProblema);
                    comando.Parameters.AddWithValue("@id", problemaDeColmena.ProblemaID);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM ProblemasDeColmenas WHERE ProblemaID=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

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
                SqlCommand comando;
                if (problemaDeColmena.ProblemaID == 0)
                {
                    string cadenaComando = "SELECT ProblemaID, TipoDeProblema FROM ProblemasDeColmenas WHERE TipoDeProblema=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", problemaDeColmena.TipoDeProblema);

                }
                else
                {
                    string cadenaComando = "SELECT ProblemaID, TipoDeColmena FROM ProblemasDeColmenas WHERE TipoDeProblema=@nombre AND ProblemaID<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", problemaDeColmena.TipoDeProblema);
                    comando.Parameters.AddWithValue("@id", problemaDeColmena.ProblemaID);


                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
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
                var CadenaDeComando = "select ProblemaID from EstadosDeLasColmenas where ProblemaID = @Id";
                var Comando = new SqlCommand(CadenaDeComando, _sqlConnection);
                Comando.Parameters.AddWithValue("@Id", problemaDeColmena.ProblemaID);
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
