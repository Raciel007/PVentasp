using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caSoporte.Cache;
using System.Data;
using System.Data.SqlClient;

namespace cDatos
{
    public class dConsultas : ConnectionToSql
    {
        DataTable tabla = new DataTable();

        public DataTable ConsultaBitFechas(DateTime fechaIni, DateTime fechaFin)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "[dbo].[pCosultaBitFechas]";
                    cmd.Parameters.AddWithValue("@INICIO", fechaIni);
                    cmd.Parameters.AddWithValue("@FIN", fechaFin);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        tabla.Load(reader);

                    return tabla;

                }

            }
        }

    }
}
