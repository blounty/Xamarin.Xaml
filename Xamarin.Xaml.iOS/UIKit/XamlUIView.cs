using System;
using System.ComponentModel;
using MonoTouch.UIKit;
using System.Drawing;
using System.Windows.Markup;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Xaml.iOS.TypeConverters;

namespace Xamarin.Xaml.iOS.UIKit
{
	[ContentProperty("XamlSubViews")]
	public class XamlUIView: UIView
	{

		public XamlUIView ()
		{
			this.xamlSubViews = new List<UIView> ();
		}


		[TypeConverter(typeof(UIColorTypeConverter))]
		public UIColor XamlBackgroundColor {
			get {
				return base.BackgroundColor;
			}
			set {
				base.BackgroundColor = value;
			}
		}

		[TypeConverter(typeof(FrameTypeConverter))]
		public RectangleF XamlFrame {
			get {
				return base.Frame;
			}
			set {
				base.Frame = value;
			}
		}

		private List<UIView> xamlSubViews;

		public List<UIView> XamlSubViews {
			get {
				return this.xamlSubViews;
			}
			set {
				this.xamlSubViews = value;
				foreach (var view in this.Subviews) {
					view.RemoveFromSuperview ();
				}
				foreach (var view in this.xamlSubViews) {
					this.AddSubview (view);
				}
			}
		}


	}
}

