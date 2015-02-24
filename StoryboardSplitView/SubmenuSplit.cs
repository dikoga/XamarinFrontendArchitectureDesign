using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace StoryboardSplitView
{
	partial class SubmenuSplit : UISplitViewController
	{
		public SubmenuSplit (IntPtr handle) : base (handle)
		{
			((Submenu)this.ViewControllers [0]).MenuSelected += HandleMenuSelected;
			this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("Submenu1"), this);

		}

		void HandleMenuSelected (object sender, string e)
		{
			this.PerformSegue(e, this);
		}

		public override void ViewDidLayoutSubviews ()
		{
			var master = ((Submenu)this.ViewControllers [0]);
			master.View.Frame = new CGRect (master.View.Frame.X, master.View.Frame.Y, master.View.Frame.Width * 2, master.View.Frame.Height);
		}
	}
}
