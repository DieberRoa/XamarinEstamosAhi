using Epm.EstamosAhi.Infraestructura.Interfases;
using Epm.EstamosAhi.Infraestructura.Enumerados;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura;

using Epm.EstamosAhi.Core.VistaModelos;

namespace Epm.EstamosAhi.Gestores
{
    public class GestorNavegador : INavegador
    {
        async public Task Navegar(TiposDeVista vista)
        {
            switch (vista){
                case TiposDeVista.Dashboard:
                    App.EstablecerDashboard();
                    break;
                case TiposDeVista.Login:
                    App.EstablecerLogin();
                    break;
                case TiposDeVista.Splash:
                    App.EstablecerSplash();
                    break;
                case TiposDeVista.LineasDeAtencion:
                    App.EstablecerPaginaConPushAsincrono(App.CrearLineasDeAtencion());
                    break;
            }
        }

        async public void Regresar()
        {
            await App.NavigationPage.PopAsync();
        }
    }
}
