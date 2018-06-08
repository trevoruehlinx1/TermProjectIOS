using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class AboutViewController : UIViewController
    {
        NSObject observer = null;
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
            RefreshFields();
			base.ViewDidLoad();
		}
		public override void ViewDidAppear(bool animated)
		{
            RefreshFields();
            var app = UIApplication.SharedApplication;
            observer = NSNotificationCenter.DefaultCenter.AddObserver(aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
			base.ViewDidAppear(animated);
		}
		partial void HealthInfoButton_TouchUpInside(UIButton sender)
        {
            HealthInfo hI = new HealthInfo();
            UIApplication.SharedApplication.OpenUrl(new NSUrl(hI.GetURL()));
        }
        public void RefreshFields()
        {
            NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;
            string color = defaults.StringForKey(Constants.BG_COLOR);

            if (color == "lightGrey")
                View.BackgroundColor = UIColor.LightGray;
            if (color == "white")
                View.BackgroundColor = UIColor.White;
            if (color == "blue")
                View.BackgroundColor = UIColor.Blue;

        }
        private void ApplicationWillEnterForeground(NSNotification notification)
        {
            var defaults = NSUserDefaults.StandardUserDefaults;
            defaults.Synchronize();
            RefreshFields();
        }
    }
}