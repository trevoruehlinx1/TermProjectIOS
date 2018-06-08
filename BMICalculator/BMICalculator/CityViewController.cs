using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class CityViewController : UIViewController
    {
        NSObject observer = null;
        public CityViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            RefreshFields();
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = false;

            if (CityPicker != null)
            {
                CityPicker.Model = new CityPickerModel(cityTextField);
            }
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

		partial void CityValueChanged(UITextField sender)
        {
            string cityNametext = cityTextField.Text;
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName = cityNametext;
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