using System;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Interfases;

namespace Epm.EstamosAhi.Gestores
{
    public class GestorDialogo : IDialogo
    {
        public async Task MostrarMensaje(string mensaje, string titulo)
        {
            await App.NavigationPage.DisplayAlert(titulo, mensaje, "Aceptar");
        }

        public async Task<bool> MostrarConfirmacion(string mensaje, string titulo)
        {
           return await App.NavigationPage.DisplayAlert(titulo, mensaje, "Sí", "No");
        }
    }
}