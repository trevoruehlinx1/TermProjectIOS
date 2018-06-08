using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class FemaleViewController : UIViewController
    {
        NSObject observer = null;
        public FemaleViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            RefreshFields();
            ShouldAutorotate();
            GetSupportedInterfaceOrientations();
            Calculator calculator = new Calculator();
            FemaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            base.ViewDidLoad();
        }

        public override void ViewDidAppear(bool animated)
        {
            RefreshFields();
            var app = UIApplication.SharedApplication;
            observer = NSNotificationCenter.DefaultCenter.AddObserver(aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = true;
            Calculator calculator = new Calculator();
            FemaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            base.ViewDidAppear(animated);
        }
		public override void ViewDidDisappear(bool animated)
		{
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = true;
			base.ViewDidDisappear(animated);
		}

		partial void FemaleChartButton_TouchUpInside(UIButton sender)
        {
            string url = "http://i0.wp.com/dietdatabase.com/wp-content/uploads/2016/05/ideal-weight-women.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }

        partial void Chart2BButton_TouchUpInside(UIButton sender)
        {
            string url = "http://realpropertyalpha.com/p/2018/04/bmi-chart-for-men-women-is-bmi-misleading-builtlean-regarding-bmi-male-chart.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
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