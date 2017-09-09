using System;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(Epm.EstamosAhi.Droid.Renderizadores.ExtenderButton))]
namespace Epm.EstamosAhi.Droid.Renderizadores
{
	public class ExtenderButton : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
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
