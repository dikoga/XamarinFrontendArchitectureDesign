using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace ArchitectureDesignTest
{
	partial class MainMenuController  : CSMenuController
	{
		public MainMenuController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.SetMainViewController ("NavigationController");
		}
	}
}
