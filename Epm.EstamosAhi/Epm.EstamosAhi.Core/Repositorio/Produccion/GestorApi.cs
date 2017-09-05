using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Epm.EstamosAhi.Infraestructura.Servicios;

namespace Epm.EstamosAhi.Core.Repositorio.Produccion
{
    public class GestorApi
    {
        private IClienteRest clienteRest;
        private IJotason gestorJson;
        private Uri urlApi;

        public GestorApi(Uri urlApi)
        {
            clienteRest = new ClienteRest();
            gestorJson = new Jotason();
            this.urlApi = urlApi;
        }
    }
}
