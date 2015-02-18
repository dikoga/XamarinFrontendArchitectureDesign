using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace ArchitectureDesignTest
{
	partial class NavigationController : UINavigationController
	{
		public NavigationController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			this.SetLeftMenuViewController ("MenuController");	
			this.AddShowLeftMenuEdgeGestureRecognizer ();
			this.GetLeftMenuViewController<MenuController> ().MenuSelected += MenuSelected;
		}

		private void MenuSelected (object sender, string controllerName)
		{
			if (string.IsNullOrEmpty (controllerName)) {
				this.PopToRootViewController (true);
				this.CloseLeftMenu ();
				return;
			}

			var controllerToPush = AppDelegate.Storyboard.InstantiateViewController (controllerName);

			this.PushViewController (controllerToPush, true);
			this.CloseLeftMenu ();
		}
	}
}
