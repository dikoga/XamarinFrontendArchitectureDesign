using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StoryboardSplitView
{
	partial class SettingsSplit : UISplitViewController
	{
		public SettingsSplit (IntPtr handle) : base (handle)
		{
			((SettingsMenu)this.ViewControllers[0]).MenuSelected += HandleMenuSelected;
			this.ShowDetailViewController (AppDelegate.Storyboard.InstantiateViewController ("Store"), this);
		}


		void HandleMenuSelected (object sender, string e)
		{
			this.PerformSegue(e, this);
		}
	}
}
