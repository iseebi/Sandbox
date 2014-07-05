// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace StoryboardDemo2
{
	[Register ("ContactTableViewController")]
	partial class ContactTableViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell MailCell { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell NameCell { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell TelephoneCell { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MailCell != null) {
				MailCell.Dispose ();
				MailCell = null;
			}
			if (NameCell != null) {
				NameCell.Dispose ();
				NameCell = null;
			}
			if (TelephoneCell != null) {
				TelephoneCell.Dispose ();
				TelephoneCell = null;
			}
		}
	}
}
