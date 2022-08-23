using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caSoporte.Cache;
namespace cDatos
{
    public class dBitacora : ConnectionToSql
    {
        DataTable tabla = new DataTable();
        public DataTable MostrarRegBit(int folio, string user)
        {
             using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "[dbo].[pMuestraRegBit]";
                        cmd.Parameters.AddWithValue("@folio", folio);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                            tabla.Load(reader);

                            return tabla;
                        
                    }

                }
              

           

        }
        public DataTable MostrarRegNotas(int folio, string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "[dbo].[pMuestraRegNotas]";
                    cmd.Parameters.AddWithValue("@folio", folio);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        tabla.Load(reader);

                    return tabla;

                }

            }




        }
        

        public string insertaBit(int folio, DateTime fechareg, string atencion, int turno, string vigila1,
                                string vigila2, string vigila3, string vigila4,string patio,string enferme,
                                string admProd, string monitorista, string obserRecib, string matapoyo,
                                string matsalud, string objconsigna, string user)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "[dbo].[pRegistraBitVigila]";
                        cmd.Parameters.AddWithValue("@folio", folio);
                        cmd.Parameters.AddWithValue("@fechareg", fechareg);
                        cmd.Parameters.AddWithValue("@atencion", atencion);
                        cmd.Parameters.AddWithValue("@turno", turno);
                        cmd.Parameters.AddWithValue("@vigila1", vigila1);
                        cmd.Parameters.AddWithValue("@vigila2", vigila2);
                        cmd.Parameters.AddWithValue("@vigila3", vigila3);
                        cmd.Parameters.AddWithValue("@vigila4", vigila4);
                        cmd.Parameters.AddWithValue("@patio", patio);
                        cmd.Parameters.AddWithValue("@enferme", enferme);
                        cmd.Parameters.AddWithValue("@admprod", admProd);
                        cmd.Parameters.AddWithValue("@monitorista", monitorista);
                        cmd.Parameters.AddWithValue("@obserRecib", obserRecib);
                        cmd.Parameters.AddWithValue("@matapoyo", matapoyo);
                        cmd.Parameters.AddWithValue("@matsalud", matsalud);
                        cmd.Parameters.AddWithValue("@objconsigna", objconsigna);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       
                        int result = cmd.ExecuteNonQuery();
                        if (result != -1)
                        {
                            return "Succes";
                        }
                        else
                        return "Error";
                    }
                    connection.Close();
                    connection.Dispose();

                }
                //do something

            }
            catch (SqlException ex)
            {
                return "Error al registrar en la Bitacora";
            }

        }


        public void insertaNota(string nota, string user, int folio)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "[dbo].[pRegistraNotas]";
                    cmd.Parameters.AddWithValue("@nota", nota);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@folio", folio);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                connection.Dispose();
            }
        }


    }
}
