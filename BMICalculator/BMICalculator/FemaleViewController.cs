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
            Calculator calculator = new Calculator();
            FemaleBMIOutputLabel.Text = calculator.GetBMIScore();
            base.ViewDidLoad();
        }

        public override void ViewDidAppear(bool animated)
        {
            Calculator calculator = new Calculator();
            FemaleBMIOutputLabel.Text = calculator.GetBMIScore();
            base.ViewDidAppear(animated);
        }

        partial void FemaleChartButton_TouchUpInside(UIButton sender)
        {
            string url = "http://i0.wp.com/dietdatabase.com/wp-content/uploads/2016/05/ideal-weight-women.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
    }
}