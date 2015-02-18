using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MonoTouch.Dialog;

namespace ArchitectureDesignTest
{
	partial class MenuController : DialogViewController
	{
		public event EventHandler<string> MenuSelected;

		public MenuController (IntPtr handle) : base (handle)
		{
			Root = new RootElement ("Root Caption") {
				new Section () {
					new StringElement ("Root", () => {
						MenuSelected (null, null);
					}),
					new StringElement ("Single", () => {
						MenuSelected (null, "SingleController");
					}),
					new StringElement ("Split", () => {
						MenuSelected (null, "SplitController");
					})
				}
			};
		}
	}
}
