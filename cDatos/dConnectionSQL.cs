using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace cDatos
{
    public abstract class ConnectionToSql
    {
        private readonly string cadenaConexion;

        public ConnectionToSql()
        {
            cadenaConexion = (ConfigurationManager.ConnectionStrings["ctsSqlCon"]).ToString(); 
        }
         protected SqlConnection GetConnection()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}


