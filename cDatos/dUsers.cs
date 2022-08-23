using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using caSoporte.Cache;

namespace cDatos
{
  public class dUsers: ConnectionToSql
    {
    public bool login(string user, string pass)
    {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "[dbo].[pValidarUsuario]";
                    command.Parameters.AddWithValue("@slogin", user);
                    command.Parameters.AddWithValue("@spass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //mietras exista lectura de las filas, se agregan valor de columna a la clase estatica donde estan las variables 
                        {
                            sUserloginCache.IdUser = reader.GetInt32(0);// 0 es el numero de la columna en BD donde se encuentra el ID
                            sUserloginCache.Login = reader.GetString(1);// 0 es el numero de la columna en BD donde se encuentra el NOMBRE
                            sUserloginCache.Nombre = reader.GetString(2);// 0 es el numero de la columna en BD donde se encuentra el LOGIN
                            sUserloginCache.Tipo = reader.GetInt32(3);// 0 es el numero de la columna en BD donde se encuentra el TIPO
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
    }
        //seguridad y permisos
        public  void AnyMethod()
        {
            if (sUserloginCache.Tipo == 1)
            {
                //Codes
            }
            if (sUserloginCache.Tipo == 2)
            {
                //Codes
            }
        }
  }
}
