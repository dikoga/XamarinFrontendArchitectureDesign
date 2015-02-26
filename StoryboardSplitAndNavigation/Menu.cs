using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace StoryboardSplitAndNavigation
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
						//this.PerformSegue("Brown", this);
					}),
					new StringElement ("Brown", () => {
						MenuSelected (null, "Brown");
					}),
					new StringElement ("Navigation", () => {
						MenuSelected (null, "Navigation");
					}),
					new StringElement ("Submenu", () => {
						//MenuSelected (null, "SubmenuSplit");
						var x = (Submenu)AppDelegate.Storyboard.InstantiateViewController("Submenu");
						x.MenuSelected += MenuSelected;
						this.NavigationController.PushViewController(x, true);
						//PerformSegue("Submenu", this);
					})
				}
			};
		}
	}
}
