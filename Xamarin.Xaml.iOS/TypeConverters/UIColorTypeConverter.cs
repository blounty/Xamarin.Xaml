using System;
using System.ComponentModel;
using MonoTouch.UIKit;

namespace Xamarin.Xaml.iOS.TypeConverters
{
	public class UIColorTypeConverter : TypeConverter
	{
		public UIColorTypeConverter ()
		{
		}

		public override bool CanConvertFrom (ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
				return true;

			return base.CanConvertFrom (context, sourceType);
		}

		public override object ConvertFrom (ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (value.GetType () == typeof(string)) {
				var split = ((string)value).Split(new string[] {","}, StringSplitOptions.None);

				return UIColor.FromRGBA (int.Parse(split [1]), int.Parse(split [2]), int.Parse(split [3]), int.Parse(split [0]));
			}

			return null;
		}
	}
}

