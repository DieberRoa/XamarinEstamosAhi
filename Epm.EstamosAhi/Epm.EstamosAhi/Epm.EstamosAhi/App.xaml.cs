using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epm.EstamosAhi.Convertidores;
using Epm.EstamosAhi.Infraestructura;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Epm.EstamosAhi.Core.VistaModelos;

using Xamarin.Forms;

namespace Epm.EstamosAhi
{
    public partial class App : Application
    {

		public static MasterDetailPage MasterDetailPage { get; set; }
		public static NavigationPage NavigationPage { get; set; }

		public App()
        {
            InitializeComponent();
            EstablecerSplash();
        }

		public static void EstablecerSplash()
		{
			var page = new Splash();
            //page.BindingContext = ContenedorDeDependencia.Localizador.ObtenerClase<LoginViewModel>();
			NavigationPage = new NavigationPage(page);
			NavigationPage.SetHasNavigationBar(page, false);
			Current.MainPage = NavigationPage;
		}

		public static void EstablecerLogin()
		{
			var page = new Login();
			page.BindingContext = ContenedorDeDependencia.Localizador.ObtenerClase<LoginViewModel>();
			NavigationPage = new NavigationPage(page);
			NavigationPage.SetHasNavigationBar(page, false);
			Current.MainPage = NavigationPage;
		}

		async public static void EstablecerPaginaConPush(Page page)
		{
			await NavigationPage.PushAsync(page);
		}
        async public static void EstablecerPaginaConPushAsincrono(Page page)
        {
            await NavigationPage.PushAsync(page);
        }

        public static void SetLocatorService(ILocalizador localizador)
		{
			ContenedorDeDependencia.Localizador = localizador;
		}

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
