using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Enumerados;

namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface INavegador
    {
        Task Navegar(TiposDeVista vista);
        void Regresar();
    }
}
