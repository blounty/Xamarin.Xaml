using System;
using System.ComponentModel;
using System.Drawing;

namespace Xamarin.Xaml.iOS.TypeConverters
{
	public class FrameTypeConverter : TypeConverter
	{
		public FrameTypeConverter ()
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

				return new RectangleF(float.Parse(split [0]), float.Parse(split [1]), float.Parse(split [2]), float.Parse(split [3]));
			}

			return null;
		}
	}
}

