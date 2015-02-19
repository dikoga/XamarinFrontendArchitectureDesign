using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace Storyboard
{
	partial class MenuContainer : UIViewController
	{
		public MenuContainer (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			this.SetLeftMenuViewController ("Menu");	
			this.AddShowLeftMenuEdgeGestureRecognizer ();
			this.GetLeftMenuViewController<Menu> ().MenuSelected += MenuSelected;
		}

		private void MenuSelected (object sender, string controllerName)
		{
			this.PerformSegue (controllerName, new NSObject ());
			this.CloseLeftMenu ();
		}
	}
}
