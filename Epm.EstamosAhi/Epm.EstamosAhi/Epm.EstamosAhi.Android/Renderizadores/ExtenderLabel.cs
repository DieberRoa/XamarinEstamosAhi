using System;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Label), typeof(Epm.EstamosAhi.Droid.Renderizadores.ExtenderLabel))]
namespace Epm.EstamosAhi.Droid.Renderizadores
{
    public class ExtenderLabel : LabelRenderer
    {
        
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
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
