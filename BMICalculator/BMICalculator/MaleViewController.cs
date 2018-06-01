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
            MaleExtraMessageOutputLabel.Text = "";
            base.ViewDidLoad();
        }

		public override void ViewDidAppear(bool animated)
		{
            Calculator calculator = new Calculator();
            MaleBMIOutputLabel.Text = calculator.GetBMIScore();
			base.ViewDidAppear(animated);
		}

        partial void MaleChartImageButton_TouchUpInside(UIButton sender)
        {
            string url = "https://www.weightlossresources.co.uk/img/i/ideal-weight-imperial-uk-men.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
    }
}