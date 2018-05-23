using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class MaleViewController : UIViewController
    {
        public MaleViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            infoLabel.Text = "view did load";
        }

		public override void ViewDidAppear(bool animated)
		{
            infoLabel.Text = "view did appear";
			base.ViewDidAppear(animated);
		}
	}
}