using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Android.Net;
using Xamarin.Forms;
using Android.Content;

namespace Epm.EstamosAhi.Droid.Gestores
{
    public class GestorNetwork : INetwork
    {
        public bool EstaLaRedDisponible { get { return RevisarConeccionARed(); }}

        private bool RevisarConeccionARed()
        {
			{
				try
				{
					var connectivityManager = (ConnectivityManager)Forms.Context.GetSystemService(Context.ConnectivityService);
					if (connectivityManager.ActiveNetworkInfo == null)
						return false;
					else
						return true;
				}
				catch (Exception)
				{
					return false;
				}
			}
        }
    }
}
