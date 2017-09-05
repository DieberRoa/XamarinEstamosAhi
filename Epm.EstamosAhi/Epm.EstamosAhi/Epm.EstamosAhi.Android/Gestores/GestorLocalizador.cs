using System;
using Epm.EstamosAhi.Infraestructura.Interfases;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Epm.EstamosAhi.Core.VistaModelos;
using Epm.EstamosAhi.Core.Repositorio;
using Epm.EstamosAhi.Gestores;
using Epm.EstamosAhi.Core.Repositorio.Local;


namespace Epm.EstamosAhi.Droid.Gestores
{
    public class GestorLocalizador : ILocalizador
    {
        static GestorLocalizador(){
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<INetwork, GestorNetwork>();
			SimpleIoc.Default.Register<IDialogo, GestorDialogo>();
			SimpleIoc.Default.Register<IRepositorioLogin, RepositorioLogin>();
			SimpleIoc.Default.Register<IToast, GestorToast>();
            SimpleIoc.Default.Register<INavegador, GestorNavegador>();
        }

        public T ObtenerClase<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }
    }
}
