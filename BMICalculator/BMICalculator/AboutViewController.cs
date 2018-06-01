using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}
		partial void HealthInfoButton_TouchUpInside(UIButton sender)
        {
            HealthInfo hI = new HealthInfo();
            UIApplication.SharedApplication.OpenUrl(new NSUrl(hI.GetURL()));
        }
    }
}