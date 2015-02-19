using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace Storyboard
{
	partial class Menu : DialogViewController
	{
		public event EventHandler<string> MenuSelected;

		public Menu (IntPtr handle) : base (handle)
		{
			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Single", () => {
						MenuSelected (null, "FirstSingleSegue");
					}),
					new StringElement ("Navigation", () => {
						MenuSelected (null, "NavigationSegue");
					}),
					new StringElement ("Split", () => {
						MenuSelected (null, "SplitSegue");
					})
				}
			};
		}
	}
}
