using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSoporte.Cache
{
    public static class sUserloginCache //publica y estatica, los valores son permanentes mientras exista la aplicacion 
    {                                   //los datos permanecen en memoria mientras la app este abierta, y se acceden a los datos cueando sea necesario
        public static int IdUser { get; set; }
        public static string Login { get; set; }
        public static string Nombre { get; set; }
        public static int Tipo { get; set; }


    }
}
