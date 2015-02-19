using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace Storyboard
{
	partial class MainView : CSMenuController
	{
		public MainView (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.SetMainViewController ("MenuContainer");
		}
	}
}
