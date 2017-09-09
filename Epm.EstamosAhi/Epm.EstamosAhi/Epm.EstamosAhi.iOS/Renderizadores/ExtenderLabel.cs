
using UIKit;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(Epm.EstamosAhi.iOS.Renderizadores.ExtenderLabel))]
namespace Epm.EstamosAhi.iOS.Renderizadores
{
    public class ExtenderLabel : LabelRenderer
    {
        
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
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
