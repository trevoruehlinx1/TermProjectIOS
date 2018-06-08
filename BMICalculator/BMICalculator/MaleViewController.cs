using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class MaleViewController : UIViewController
    {
        NSObject observer = null;
        public MaleViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = true;
            Calculator calculator = new Calculator();
            MaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            RefreshFields();
            base.ViewDidLoad();
        }

		public override void ViewDidAppear(bool animated)
		{
            var app = UIApplication.SharedApplication;
            observer = NSNotificationCenter.DefaultCenter.AddObserver(aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = true;
            Calculator calculator = new Calculator();
            MaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            RefreshFields();
			base.ViewDidAppear(animated);
		}

        partial void MaleChartImageButton_TouchUpInside(UIButton sender)
        {
            string url = "https://www.weightlossresources.co.uk/img/i/ideal-weight-imperial-uk-men.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }

        partial void Chart2Button_TouchUpInside(UIButton sender)
        {
            string url = "http://realpropertyalpha.com/p/2018/04/bmi-chart-for-men-women-is-bmi-misleading-builtlean-regarding-bmi-male-chart.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
        public void RefreshFields()
        {
            NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;
            string color = defaults.StringForKey(Constants.BG_COLOR);
            bool commentStatus = defaults.BoolForKey(Constants.STATUS_COMMENT);

            if (commentStatus == false)
            {
                ExtraMessageOutputLabel.Text = "";
            }


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