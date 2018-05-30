using System;

using UIKit;

namespace BMICalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void WeightSliderValueChanged(UISlider sender)
        {
            int WSValue = (int)sender.Value;
            weightSliderOutputLabel.Text = WSValue.ToString()+" lbs.";
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).weight = WSValue;
        }

        partial void HeightSliderValueChanged(UISlider sender)
        {
            int ft = (int)sender.Value / 12;
            int inchs = (int)sender.Value % 12;
            HeightSliderOutputLabel.Text = ft.ToString() + " ft. " + inchs.ToString() + " in.";
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).height = (int)sender.Value;
        }
    }
}
