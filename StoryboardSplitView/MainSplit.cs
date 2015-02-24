using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StoryboardSplitView
{
	partial class MainSplit : UISplitViewController
	{
		public MainSplit (IntPtr handle) : base (handle)
		{
			Delegate = new SplitDelegate ();

			((Menu)this.ViewControllers[0]).MenuSelected += HandleMenuSelected;
			this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("Blue"), this);
		}

		void HandleMenuSelected (object sender, string e)
		{
			if (e == "SubmenuSplit") {
				this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("SubmenuSplit"), this);
				return;
			}

			this.PerformSegue(e, this);

		}


		class SplitDelegate : UISplitViewControllerDelegate
		{
			public override bool ShouldHideViewController (UISplitViewController svc,
				UIViewController viewController, UIInterfaceOrientation inOrientation)
			{
				return true;
			}

		}
	}
}
