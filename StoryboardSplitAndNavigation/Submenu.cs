using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace StoryboardSplitAndNavigation
{
	partial class Submenu : DialogViewController
	{
		public event EventHandler<string> MenuSelected;

		public Submenu (IntPtr handle) : base (handle)
		{
			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Magenta", () => {
						MenuSelected (null, "Magenta");
					}),
					new StringElement ("Orange", () => {
						MenuSelected (null, "Orange");
					})
				}
			};
		}

		public override void ViewDidLoad ()
		{
			this.NavigationItem.LeftBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Undo);
			//this.NavigationItem.BackBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Undo);
			//this.NavigationItem.SetHidesBackButton (false, true);
			//this.NavigationItem.
		}
	}
}
