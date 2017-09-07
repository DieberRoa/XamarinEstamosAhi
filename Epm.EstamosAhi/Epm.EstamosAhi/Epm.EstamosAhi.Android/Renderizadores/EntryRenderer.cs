using System;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(Epm.EstamosAhi.Droid.Renderizadores.ExtenderEntry))]
namespace Epm.EstamosAhi.Droid.Renderizadores
{
    public class ExtenderEntry : EntryRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (!string.IsNullOrEmpty(e.NewElement?.StyleId))
			{
				var font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, e.NewElement.StyleId + ".ttf");
				Control.Typeface = font;
			}
		}
    }
}
