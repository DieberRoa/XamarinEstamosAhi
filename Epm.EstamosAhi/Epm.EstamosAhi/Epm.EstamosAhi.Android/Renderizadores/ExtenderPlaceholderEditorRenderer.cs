using System;
using Xamarin.Forms;
using Epm.EstamosAhi.Controles;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;

namespace Epm.EstamosAhi.Droid.Renderizadores
{
    public class ExtenderPlaceholderEditorRenderer :EditorRenderer
    {
        public ExtenderPlaceholderEditorRenderer()
        {
        }

		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				var element = e.NewElement as PlaceholderEditor;
				this.Control.Hint = element.Placeholder;
			}
		}

		protected override void OnElementPropertyChanged(object sender,PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == PlaceholderEditor.PlaceholderProperty.PropertyName)
			{
				var element = this.Element as PlaceholderEditor;
				this.Control.Hint = element.Placeholder;
			}
		}
    }
}
