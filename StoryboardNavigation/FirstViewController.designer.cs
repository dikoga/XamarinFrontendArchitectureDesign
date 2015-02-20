// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StoryboardNavigation
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton YourColor { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (YourColor != null) {
				YourColor.Dispose ();
				YourColor = null;
			}
		}
	}
}
