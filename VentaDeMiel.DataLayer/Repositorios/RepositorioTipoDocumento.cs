using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel.BusinessLayer.Entities;

namespace VentaDeMiel.DataLayer.Repositorios
{
   public class RepositorioTipoDocumento
   {
       
            private readonly SqlConnection _sqlConnection;

            public RepositorioTipoDocumento(SqlConnection sqlConnection)
            {
                _sqlConnection = sqlConnection;
            }
            public tipoDocumento GetTipoDocumentoPorId(decimal id)
            {
                try
                {
                    tipoDocumento tipodocumento = null;
                    string cadenaComando = "SELECT TipoDocumentoID, TipoDocumento FROM TiposDocumentos WHERE TipoDocumentoID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipodocumento = ConstruirTipoDocumento(reader);
                        reader.Close();
                    }

                    return tipodocumento;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }

            public List<tipoDocumento> GetLista()
            {
                List<tipoDocumento> lista = new List<tipoDocumento>();
                try
                {
                    string cadenaComando = "SELECT TipoDocumentoID, TipoDocumento FROM TiposDocumentos";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        tipoDocumento tipodocumento = ConstruirTipoDocumento(reader);
                        lista.Add(tipodocumento);
                    }
                    reader.Close();
                    return lista;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            private tipoDocumento ConstruirTipoDocumento(SqlDataReader reader)
            {

                var tipodocumento = new tipoDocumento();
            tipodocumento.TipoDocumentoID = reader.GetDecimal(0);
            tipodocumento.TipoDocumento = reader.GetString(1);
                return tipodocumento;

            }

            public void Guardar(tipoDocumento tipodocumento)
            {
                if (tipodocumento.TipoDocumentoID == 0)
                {

                    try
                    {
                        string cadenaComando = "INSERT INTO TiposDocumentos VALUES(@nombre)";
                        SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                        comando.Parameters.AddWithValue("@nombre", tipodocumento.TipoDocumento);

                        comando.ExecuteNonQuery();
                        cadenaComando = "SELECT @@IDENTITY";
                        comando = new SqlCommand(cadenaComando, _sqlConnection);
                    tipodocumento.TipoDocumentoID = (int)(decimal)comando.ExecuteScalar();

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
                        string cadenaComando = "UPDATE TiposDocumentos SET TipoDocumento=@nombre WHERE TipoDocumentoID=@id";
                        SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                        comando.Parameters.AddWithValue("@nombre", tipodocumento.TipoDocumento);
                        comando.Parameters.AddWithValue("@id", tipodocumento.TipoDocumentoID);
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
                    string cadenaComando = "DELETE FROM TiposDocumentos WHERE TipoDocumentoID=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            public bool Existe(tipoDocumento tipodocumento)
            {
                try
                {
                    SqlCommand comando;
                    if (tipodocumento.TipoDocumentoID == 0)
                    {
                        string cadenaComando = "SELECT TipoDocumentoID, TipoDocumento FROM TiposDocumentos WHERE TipoDocumento=@nombre";
                        comando = new SqlCommand(cadenaComando, _sqlConnection);
                        comando.Parameters.AddWithValue("@nombre", tipodocumento.TipoDocumento);

                    }
                    else
                    {
                        string cadenaComando = "SELECT TipoDocumentoID, TipoDocumento FROM TiposDocumentos WHERE TipoDocumento=@nombre AND TipoDocumentoID<>@id";
                        comando = new SqlCommand(cadenaComando, _sqlConnection);
                        comando.Parameters.AddWithValue("@nombre", tipodocumento.TipoDocumento);
                        comando.Parameters.AddWithValue("@id", tipodocumento.TipoDocumentoID);


                    }
                    SqlDataReader reader = comando.ExecuteReader();
                    return reader.HasRows;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            public bool EstaRelacionado(tipoDocumento tipodocumento)
            {
                try
                {
                    var CadenaDeComando = "select TipoDocumentoID from ClientesDeMiel where TipoDocumentoID = @Id";
                    var Comando = new SqlCommand(CadenaDeComando, _sqlConnection);
                    Comando.Parameters.AddWithValue("@Id", tipodocumento.TipoDocumentoID);
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
