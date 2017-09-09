using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Xamarin.Forms;
using ToastIOS;

namespace Epm.EstamosAhi.iOS.Gestores
{
    public class GestorToast : IToast
    {
        public void MostrarToastLargo(string message)
		{
            Toast.MakeText(message,Toast.LENGTH_LONG).Show();
		}
		public void MostratToastCorto(string message)
		{
			Toast.MakeText(message,Toast.LENGTH_SHORT).Show();
		}
    }
}
