
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(Epm.EstamosAhi.iOS.Renderizadores.ExtenderEntry))]
namespace Epm.EstamosAhi.iOS.Renderizadores
{
    public class ExtenderEntry : EntryRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (!string.IsNullOrEmpty(e.NewElement?.StyleId))
			{
               var font = UIFont.FromName(e.NewElement.StyleId, nfloat.Parse(e.NewElement.FontSize.ToString()));
				Control.Font = font;
                Control.BorderStyle = UITextBorderStyle.None;
			}
		}
    }
}
