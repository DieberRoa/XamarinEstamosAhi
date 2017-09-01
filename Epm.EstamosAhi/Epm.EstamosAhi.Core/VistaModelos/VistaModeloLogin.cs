using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epm.EstamosAhi.Infraestructura.Interfases;
using Epm.EstamosAhi.Infraestructura.Dto;
using Epm.EstamosAhi.Core.Repositorio;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace Epm.EstamosAhi.Core.VistaModelos
{
    public class VistaModeloLogin : BaseValidacion
    {

		public INetwork GestorNetwork { get; set; }
		public IDialogo GestorDialogo{ get; set; }
        public IRepositorioLogin GestorLogin { get; set; }
		public IToast GestorToast { get; set; }
        public INavegador GestorNavegador { get; set; }

		private bool isBusy;
		private bool holdSession;
		private string correoElectronico;
        private string contrasenia;

        public bool IsBusy
		{
			get { return isBusy; }
			set { Set(ref isBusy, value); }
		}
		
		public bool HoldSession
		{
			get { return holdSession; }
			set { Set(ref holdSession, value); }
		}

		public string CorreoElectronico
		{
			get { return correoElectronico; }
			set { Set(ref correoElectronico, value); }
		}
		
		public string Contrasenia
		{
			get { return contrasenia; }
			set { Set(ref contrasenia, value); }
		}

		public string Token { get; set; }


		public VistaModeloLogin(INetwork gestorNetwork, IDialogo gestorDialogo, IRepositorioLogin gestorLogin, IToast gestorToast, INavegador gestorNavegador)
		{
			GestorNetwork = gestorNetwork;
			GestorDialogo = gestorDialogo;
			GestorLogin = gestorLogin;
			GestorToast = gestorToast;
			GestorNavegador = gestorNavegador;
		}

        public ICommand ComandoAutenticar { get { return new RelayCommand(Autenticar); }}

        async private void Autenticar(){

            IsBusy = true;
            Validate();
            if (IsValid)
            {
                if (GestorNetwork.EstaLaRedDisponible)
                {
                    
                    SolicitudLogin solicitud = new SolicitudLogin();
                    solicitud.CorreoElectronico = CorreoElectronico;
                    solicitud.Contrasenia = Contrasenia;

                    RespuestaLogin respuestaLogin = GestorLogin.Autenticar(solicitud);
                    if (respuestaLogin.Respuesta.IsSuccessStatusCode){
                        if  (respuestaLogin.Respuesta.StatusCode == System.Net.HttpStatusCode.OK){
                            
                        }
                    }

                }
            }

        }

        protected override void Autovalidarse()
        {
            var IsValid = EstanLlenosLosCampos() && EstaCorrectoElFormatoDelCorreoElectronico();
        }

        private bool EstanLlenosLosCampos(){
            bool esVacio = false;
            string mensaje = "";
			if (string.IsNullOrEmpty(CorreoElectronico))
			{
                mensaje = "Debes ingresar tu correo electrónico.";
                esVacio = true;
			}
            if (!esVacio){
                if (string.IsNullOrEmpty(Contrasenia)){
                    mensaje = "Debes ingresar una contraseña.";
                    esVacio = true;
                }
            }
            if (esVacio){
                GestorDialogo.MostrarMensaje("Autenticar",mensaje);
            }
            return !esVacio;
        }

        private bool EstaCorrectoElFormatoDelCorreoElectronico(){
            bool esCorrecto = true;
			try
			{
				esCorrecto = 
                    Regex.IsMatch(CorreoElectronico,
                                  @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", 
                                  RegexOptions.IgnoreCase);
			}
			catch (Exception)
			{
                esCorrecto = false;
			}
            if (!esCorrecto){
                GestorDialogo.MostrarMensaje("Autenticar", "Debes ingresar una dirección válida de correo electrónico.");
            }
            return esCorrecto;
        }




    }
}
