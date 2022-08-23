using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDatos;
using caSoporte.Cache;

namespace cNegocios
{
    public class nUsers
    {
        dUsers duser = new dUsers();
        public bool LoginUser(string user, string pass)
        {
            return duser.login(user, pass);
        }

        //seguridad y permisos
        public void AnyMethod()
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
