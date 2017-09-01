using System;
using System.Globalization;
using Xamarin.Forms;

namespace Epm.EstamosAhi.Convertidores
{
	public class BoolToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (System.Convert.ToBoolean(parameter))
			{
				return System.Convert.ToBoolean(value) ? false : true;
			}
			else
			{
				return System.Convert.ToBoolean(value) ? true : false;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
