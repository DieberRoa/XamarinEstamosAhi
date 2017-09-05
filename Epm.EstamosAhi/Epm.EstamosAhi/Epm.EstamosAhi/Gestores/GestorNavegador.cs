using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Epm.EstamosAhi.Infraestructura.Enumerados;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Gestores
{
    public class GestorNavegador : INavegador
    {
        async public Task Navegar(TiposDeVista vista)
        {
            switch (vista){
                case TiposDeVista.Dashboard:
                    App.EstablecerPaginaConPush(new Dashboard());
                    break;
                case TiposDeVista.Login:
                    App.EstablecerLogin();
                    break;
                case TiposDeVista.Splash:
                    App.EstablecerSplash();
                    break;
                case TiposDeVista.LineasDeAtencion:
                    App.EstablecerPaginaConPush(new LineasDeAtencion());
                    break;
            }
        }

        async public void Regresar()
        {
            await App.NavigationPage.PopAsync();
        }
    }
}
