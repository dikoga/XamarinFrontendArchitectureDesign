using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StoryboardSplitAndNavigation
{
	partial class MainSplit : UISplitViewController
	{
		public MainSplit (IntPtr handle) : base (handle)
		{


				}

		public override void ViewDidLoad ()
		{
			((Menu)((MenuNavigation)this.ViewControllers[0]).ViewControllers[0]).MenuSelected += HandleMenuSelected;
			this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("Blue"), this);

		}

		void HandleMenuSelected (object sender, string e)
		{
			if (e == "Magenta" || e == "Orange") {
				//Delegate = new SplitDelegate (false);
				//WeakDelegate=new SplitDelegate (false);
				this.ShouldHideViewController = (UISplitViewController svc,
					UIViewController viewController, UIInterfaceOrientation inOrientation) => {
					return false;
				};
			} else {
				//Delegate = new SplitDelegate (true);
				//WeakDelegate=new SplitDelegate (true);
				this.ShouldHideViewController = (UISplitViewController svc,
					UIViewController viewController, UIInterfaceOrientation inOrientation) => {
					return true;
				};
			}

			//this.ReloadInputViews ();

			this.PerformSegue(e, this);
		}

		class SplitDelegate : UISplitViewControllerDelegate
		{
			bool shouldHide;
			public SplitDelegate (bool shouldHide)
			{
				this.shouldHide = shouldHide;
			}

			public override bool ShouldHideViewController (UISplitViewController svc,
				UIViewController viewController, UIInterfaceOrientation inOrientation)
			{
				return shouldHide;
			}
		}
	}
}
