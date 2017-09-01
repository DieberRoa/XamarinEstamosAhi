using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Recursos
{
    public static class Recursos
    {
        public static string ObtenerValorConLlave(string llave)
        {
            return AppRecursos.ResourceManager.GetString(llave);
        }
    }
}
