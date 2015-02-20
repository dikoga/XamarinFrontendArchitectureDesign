using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace StoryboardNavigation
{
	partial class MainMenuController : CSMenuController
	{
		public MainMenuController (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SetMainViewController ("MainNavigationController");
		}
	}
}
