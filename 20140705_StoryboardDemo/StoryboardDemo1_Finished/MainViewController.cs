using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace StoryboardDemo1_Finished
{
	partial class MainViewController : UIViewController
	{
		public MainViewController (IntPtr handle) : base (handle)
		{
		}

        [Action ("UnwindToMainViewController:")]
        public void UnwindToMainViewController(UIStoryboardSegue segue)
        {
        }
	}
}
