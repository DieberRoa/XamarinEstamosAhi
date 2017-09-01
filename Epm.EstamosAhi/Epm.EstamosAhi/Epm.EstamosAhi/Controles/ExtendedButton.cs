﻿using System;
using Xamarin.Forms;

namespace Epm.EstamosAhi.Controles
{
	public class ExtendedButton : Button
	{
		public static readonly BindableProperty PaddingProperty =
			BindableProperty.Create<ExtendedButton, Thickness>(o => o.Padding, default(Thickness));

		public Thickness Padding
		{
			get { return (Thickness)GetValue(PaddingProperty); }
			set { SetValue(PaddingProperty, value); }
		}
	}
}
