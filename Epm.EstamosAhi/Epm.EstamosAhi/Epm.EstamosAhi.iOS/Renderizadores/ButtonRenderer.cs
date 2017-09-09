
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(Epm.EstamosAhi.iOS.Renderizadores.ExtenderButton))]
namespace Epm.EstamosAhi.iOS.Renderizadores
{
    public class ExtenderButton : ButtonRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (!string.IsNullOrEmpty(e.NewElement?.StyleId))
			{
               var font = UIFont.FromName(e.NewElement.StyleId, nfloat.Parse(e.NewElement.FontSize.ToString()));
				Control.Font = font;
			}
		}
    }
}
