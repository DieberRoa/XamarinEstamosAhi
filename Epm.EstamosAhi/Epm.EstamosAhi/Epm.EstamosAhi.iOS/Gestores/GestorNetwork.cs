using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Xamarin.Forms;

namespace Epm.EstamosAhi.iOS.Gestores
{
    public class GestorNetwork : INetwork
    {
        public bool EstaLaRedDisponible { get { return RevisarConeccionARed(); }}

        private bool RevisarConeccionARed()
        {
			{
                // TODO : Validar  
                return true;
			}
        }
    }
}
