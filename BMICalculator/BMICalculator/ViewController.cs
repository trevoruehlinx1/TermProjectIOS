using System;
using Foundation;
using UIKit;

namespace BMICalculator
{
    public partial class ViewController : UIViewController
    {
        NSObject observer = null;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            RefreshFields();
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = false;
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
		public override void ViewDidAppear(bool animated)
		{
            RefreshFields();
            var app = UIApplication.SharedApplication;
            observer = NSNotificationCenter.DefaultCenter.AddObserver(aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = false;
			base.ViewDidAppear(animated);
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

        partial void SettingsButton_TouchUpInside(UIButton sender)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
        }
        public void RefreshFields()
        {
            NSUserDefaults defaults = NSUserDefaults.StandardUserDefaults;
            HeightSlider.Value = defaults.FloatForKey(Constants.HEIGHT_SLIDER);
            HeightSliderValueChanged(HeightSlider);
            WeightSlider.Value = defaults.FloatForKey(Constants.WEIGHT_SLIDER);
            WeightSliderValueChanged(WeightSlider);
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
