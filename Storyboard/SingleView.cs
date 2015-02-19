using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace Storyboard
{
	partial class SingleView : UIViewController
	{
		public SingleView (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			this.SetLeftMenuViewController ("Menu");	
			this.AddShowLeftMenuEdgeGestureRecognizer ();
			//this.GetLeftMenuViewController<Menu> ().MenuSelected += MenuSelected;
		}
	}
}
