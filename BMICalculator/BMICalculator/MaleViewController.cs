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
            Calculator calculator = new Calculator();
            MaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
            base.ViewDidLoad();
        }

		public override void ViewDidAppear(bool animated)
		{
            Calculator calculator = new Calculator();
            MaleBMIOutputLabel.Text = calculator.GetBMIScore();
            ExtraMessageOutputLabel.Text = calculator.GetExtraMessage();
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
    }
}