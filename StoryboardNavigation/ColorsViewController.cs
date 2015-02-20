using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StoryboardNavigation
{
	partial class ColorsViewController : UIViewController
	{
		public event EventHandler<ColorEventArgs> ColorSelected;

		public ColorsViewController (IntPtr handle) : base (handle)
		{
		}

		// Any ViewController can be used as a menu as long as it has a storyboard id.
		// This one just fires an event when a color is clicked.
		partial void ColorButtonClicked (ColorButton sender)
		{
			if (ColorSelected != null)
				ColorSelected.Invoke(this, new ColorEventArgs { Color = sender.BackgroundColor });
		}
	}

	public class ColorEventArgs : EventArgs
	{
		public UIColor Color { get; set; }
	}
}
