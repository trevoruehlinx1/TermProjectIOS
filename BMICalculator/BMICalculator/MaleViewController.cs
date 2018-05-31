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
            decimal weight = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).weight;
            decimal height = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).height;

            if (weight > 0)
            {
                decimal BMIScore = (weight / (height * height)) * 703;
                BMIScore = decimal.Round(BMIScore, 2);
                MaleBMIOutputLabel.Text = "Your BMI Score is " + BMIScore.ToString();
            }
            else
                MaleBMIOutputLabel.Text = "You must enter your height and weight";
                

            base.ViewDidLoad();
        }

		public override void ViewDidAppear(bool animated)
		{
            decimal weight = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).weight;
            decimal height = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).height;
            if (weight > 0)
            {
                decimal BMIScore = (weight / (height * height)) * 703;
                BMIScore = decimal.Round(BMIScore, 2);
                MaleBMIOutputLabel.Text = "Your BMI Score is " + BMIScore.ToString();
            }
            else
                MaleBMIOutputLabel.Text = "You must enter your height and weight";

			base.ViewDidAppear(animated);
		}

        partial void MaleChartImageButton_TouchUpInside(UIButton sender)
        {
            string url = "https://www.weightlossresources.co.uk/img/i/ideal-weight-imperial-uk-men.jpg";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
    }
}