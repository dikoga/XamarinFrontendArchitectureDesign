using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace StoryboardSplitView
{
	partial class SettingsMenu : DialogViewController
	{

		public event EventHandler<string> MenuSelected;

		public SettingsMenu (IntPtr handle) : base (handle)
		{
			//this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("Store"), this);

			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Store Information", () => {
						MenuSelected (null, "Store");
						//this.PerformSegue("Store", this);
					}),
					new StringElement ("Invoice", () => {
						MenuSelected (null, "Invoice");
						//this.PerformSegue("Invoice", this);
					})
				}
			};
		}
	}
}
