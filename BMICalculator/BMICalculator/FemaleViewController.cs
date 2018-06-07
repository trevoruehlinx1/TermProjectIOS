using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class FemaleViewController : UIViewController
    {
        public FemaleViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            ShouldAutorotate();
            GetSupportedInterfaceOrientations();
            Calculator calculator = new Calculator();
            FemaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            base.ViewDidLoad();
        }

        public override void ViewDidAppear(bool animated)
        {
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
    }
}