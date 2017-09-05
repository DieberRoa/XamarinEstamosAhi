using System;
using System.Collections.Generic;
using Epm.EstamosAhi.Core.VistaModelos;

using Xamarin.Forms;

namespace Epm.EstamosAhi
{
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
        }

        protected override void OnAppearing(){
			if (this.BindingContext != null)
			{
				VistaModeloLogin vistaModeloLogin = (VistaModeloLogin)this.BindingContext;
			}
        }
    }
}
