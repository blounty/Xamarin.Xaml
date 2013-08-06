using System;
using MonoTouch.UIKit;

namespace Xamarin.iOS.Xaml
{
	public class XamlUIViewController : UIViewController
	{
		public XamlUIViewController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var xaml = System.Xaml.XamlServices.Load(string.Format("{0}.xaml", this.GetType().Name));

			this.View = (UIView)xaml;
		}
	}
}

