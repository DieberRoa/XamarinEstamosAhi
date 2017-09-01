using System;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Infraestructura.Interfases
{
    public interface IDialogo
    {
		Task MostrarMensaje(string mensaje, string titulo);
		Task<bool> MostrarConfirmacion(string mensaje, string titulo);
    }
}
