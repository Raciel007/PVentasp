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
    public class nBitacora
    {
        dBitacora dbita = new dBitacora();
        DataTable tabla = new DataTable();
        public string insertaBit()
        {
            return dbita.insertaBit(sRegBitacora.Folio, sRegBitacora.Fechareg, sRegBitacora.Atencion, sRegBitacora.Turno,
                sRegBitacora.Vigila1, sRegBitacora.Vigila2, sRegBitacora.Vigila3, sRegBitacora.Vigila4, sRegBitacora.Patio,
                sRegBitacora.Enferme, sRegBitacora.AdmProd,sRegBitacora.Monitorista, sRegBitacora.OberserRecib, sRegBitacora.Matpoyo,
                sRegBitacora.Matsalud, sRegBitacora.Objconsigna,sRegBitacora.User);
        }
        public void insertNota()
        {
            dbita.insertaNota(sRegBitacora.Notas, sRegBitacora.User, sRegBitacora.Folio );

        }

        public DataTable MostrarRegBit(int folio, string user)
        {
            
            tabla = dbita.MostrarRegBit(folio, user);
            return tabla;
        }
        
        public DataTable MostrarRegNotas(int folio, string user)
        {

            tabla = dbita.MostrarRegNotas(folio, user);
            return tabla;
        }
    }
}
