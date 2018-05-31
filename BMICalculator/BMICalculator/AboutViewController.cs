using Foundation;
using System;
using UIKit;

namespace BMICalculator
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}
		partial void HealthInfoButton_TouchUpInside(UIButton sender)
        {
            string cityName = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName;
            string url = "";

            if (cityName == "Eugene") { url = "http://www.peacehealth.org"; }
            else if (cityName == "Springfield") { url = "http://www.mckweb.com"; }
            else if (cityName == "Albany") { url = "https://www.samhealth.org/"; }
            else if (cityName == "Salem") { url = "http://www.salemhealth.org"; }
            else if (cityName == "Portland") { url = "http://www.ohsu.edu"; }
            else if (cityName == "Cottage Grove") { url = "https://www.peacehealth.org/phmg/cottage-grove/locations/cottage-grove"; }
            else if (cityName == "Cresswell") { url = "https://www.peacehealth.org/phmg/cottage-grove/locations/creswell"; }

            else
                url = "http://www.webmd.com";
                
            UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
        }
    }
}