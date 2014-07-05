using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace StoryboardDemo2
{
	partial class AddressBookTableViewController : UITableViewController
	{
        AddressBook addressBook;

		public AddressBookTableViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            addressBook = new AddressBook();
            TableView.Source = new TableSource(addressBook);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "toContact")
            {
                var vc = (segue.DestinationViewController as ContactTableViewController);
                vc.Contact = addressBook.Contacts[TableView.IndexPathForSelectedRow.Row];
            }
            else
            {
                base.PrepareForSegue(segue, sender);
            }
        }

        public class TableSource : UITableViewSource
        {
            readonly AddressBook addressBook;
            NSString cellIdentifier = new NSString("cell");

            public Contact SelectedItem
            {
                get;
                set;
            }

            public TableSource(AddressBook addressBook)
            {
                this.addressBook = addressBook;
            }

            public override int RowsInSection(UITableView tableView, int section)
            {
                return addressBook.Contacts.Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(cellIdentifier, indexPath);
                var contact = addressBook.Contacts[indexPath.Row];

                cell.TextLabel.Text = contact.Name;

                return cell;
            }
        }
	}
}
