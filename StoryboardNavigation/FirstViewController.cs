using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Trewarren.CSMenu;

namespace StoryboardNavigation
{
	partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
//			LeftMenuButton.Clicked += delegate { this.ShowLeftMenu(); };							// Tell the navbar buttons to show the menus.
//			RightMenuButton.Clicked += delegate { this.ShowRightMenu(); };							// CSMenu uses extension methods so be sure to include 'using Trewarren.CSMenu;'
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.SetLeftMenuViewController ("ColorsViewController");								// Set the view controllers to appear as side menus using their storyboard ids
//			this.SetRightMenuViewController ("SettingsViewController");								

			this.AddShowLeftMenuEdgeGestureRecognizer ();											// As well as calling ShowLeftMenu or ShowRightMenu, you can add gesture recognizers to open the menus.
//			this.AddShowRightMenuEdgeGestureRecognizer ();

			this.GetLeftMenuViewController<ColorsViewController> ().ColorSelected += ColorSelected;	// Get a reference to the left menu using GetLeftMenuController and add a method to its ColorSelected event.
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);

			this.RemoveShowLeftMenuEdgeGestureRecognizer ();										// If we navigate to a different screen in the app without removing the gesture recognizers then the user would still be able to swipe open the menus.
//			this.RemoveShowRightMenuEdgeGestureRecognizer ();

			this.GetLeftMenuViewController<ColorsViewController> ().ColorSelected -= ColorSelected;
		}

		private void ColorSelected (object sender, ColorEventArgs e)
		{
			YourColor.BackgroundColor = e.Color;
			this.CloseLeftMenu();
		}
	}
}
