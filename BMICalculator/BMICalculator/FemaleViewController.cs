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
            decimal weight = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).weight;
            decimal height = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).height;
            if (weight > 0)
            {
                decimal BMIScore = (weight / (height * height)) * 703;
                BMIScore = decimal.Round(BMIScore, 2);
                FemaleBMIOutputLabel.Text = "Your BMI Score is " + BMIScore.ToString();
            }
            else
                FemaleBMIOutputLabel.Text = "You must enter your height and weight";


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
                FemaleBMIOutputLabel.Text = "Your BMI Score is " + BMIScore.ToString();
            }
            else
                FemaleBMIOutputLabel.Text = "You must enter your height and weight";

            base.ViewDidAppear(animated);
        }
    }
}