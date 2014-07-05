using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace StoryboardDemo2
{
	partial class ContactTableViewController : UITableViewController
	{
        public Contact Contact
        {
            get;
            set;
        }

		public ContactTableViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NameCell.DetailTextLabel.Text = Contact.Name;
            MailCell.DetailTextLabel.Text = Contact.Mail;
            TelephoneCell.DetailTextLabel.Text = Contact.Telephone;
        }
	}
}
