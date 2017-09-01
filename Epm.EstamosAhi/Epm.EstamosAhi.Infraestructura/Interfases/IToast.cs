using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface IToast
    {
        void MostrarToastLargo(string message);
        void MostratToastCorto(string message);
    }
}
