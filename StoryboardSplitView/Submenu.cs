using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace StoryboardSplitView
{
	partial class Submenu  : DialogViewController
	{
		public event EventHandler<string> MenuSelected;

		public Submenu (IntPtr handle) : base (handle)
		{
			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Submenu 1", () => {
						MenuSelected (null, "Submenu1");
					}),
					new StringElement ("Submenu 2", () => {
						MenuSelected (null, "Submenu2");
					})
				}
			};


		}
	}
}
