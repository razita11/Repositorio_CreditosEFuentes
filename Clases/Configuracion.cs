using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Creditos_EFuentes.Clases
{
    internal class Configuracion
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers helpers = new Clases.Helpers();

        public void checkInfoConfiguracion()
        {
            //Checamos si existe información en la tabla CONFIG_APP
            if (db.Exists("CONFIG_APP", "CLAVE", "'SERVER_FILES'") == false)
            {
                db.Save("CONFIG_APP", "CLAVE, VALOR, DETALLE", "'SERVER_FILES','','SERVIDOR DE ARCHIVOS'");
            }

            if (db.Exists("CONFIG_APP", "CLAVE", "'BACKUPS'") == false)
            {
                db.Save("CONFIG_APP", "CLAVE, VALOR, DETALLE", "'BACKUPS','','DIRECTORIO PARA LAS COPIAS DE SEGURIDAD'");
            }
        }


    }
}
