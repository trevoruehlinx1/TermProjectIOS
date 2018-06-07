using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class CityViewController : UIViewController
    {
        public CityViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
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
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).disableAllOrientation = false;
			base.ViewDidAppear(animated);
		}

		partial void CityValueChanged(UITextField sender)
        {
            string cityNametext = cityTextField.Text;
            ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName = cityNametext;
        }
    }
}