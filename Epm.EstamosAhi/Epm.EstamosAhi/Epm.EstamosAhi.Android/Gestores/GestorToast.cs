using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Android.Widget;
using Xamarin.Forms;

namespace Epm.EstamosAhi.Droid.Gestores
{
    public class GestorToast : IToast
    {
        public void MostrarToastLargo(string message)
		{
			Toast toast = Toast.MakeText(Forms.Context, message, ToastLength.Long);
			toast.Show();
		}
		public void MostratToastCorto(string message)
		{
			Toast toast = Toast.MakeText(Forms.Context, message, ToastLength.Short);
			toast.Show();
		}
    }
}
