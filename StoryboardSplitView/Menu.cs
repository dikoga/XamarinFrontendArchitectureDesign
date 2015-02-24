using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace StoryboardSplitView
{
	partial class Menu : DialogViewController
	{
		public event EventHandler<string> MenuSelected;

		public Menu (IntPtr handle) : base (handle)
		{
			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Blue", () => {
						MenuSelected (null, "Blue");
					}),
					new StringElement ("Brown", () => {
						MenuSelected (null, "Brown");
					}),
					new StringElement ("Navigation", () => {
						MenuSelected (null, "Navigation");
					}),
					new StringElement ("Submenu Split", () => {
						MenuSelected (null, "SubmenuSplit");
					})
				}
			};
		}
	}
}
