using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caSoporte.Cache;
using cDatos;

namespace cNegocios
{
    public class nConsultas
    {
        dConsultas dconsul = new dConsultas();
        DataTable tabla = new DataTable();
        public DataTable ConsultaBitFechas(string fechaIni, string fechaFin)
        {
            
            tabla = dconsul.ConsultaBitFechas(Convert.ToDateTime(fechaIni), Convert.ToDateTime(fechaFin));
            return tabla;
        }

    }
}
