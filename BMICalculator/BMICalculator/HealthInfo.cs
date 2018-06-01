using System;
using UIKit;

namespace BMICalculator
{
    public class HealthInfo
    {
        public string URL { get; set;}
        public HealthInfo()
        {
        }
        public string GetURL()
        {
            string cityName = ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName;

            if (cityName == "Eugene") { URL = "http://www.peacehealth.org"; }
            else if (cityName == "Springfield") { URL = "http://www.mckweb.com"; }
            else if (cityName == "Albany") { URL = "https://www.samhealth.org/"; }
            else if (cityName == "Salem") { URL = "http://www.salemhealth.org"; }
            else if (cityName == "Portland") { URL = "http://www.ohsu.edu"; }
            else if (cityName == "Cottage Grove") { URL = "https://www.peacehealth.org/phmg/cottage-grove/locations/cottage-grove"; }
            else if (cityName == "Cresswell") { URL = "https://www.peacehealth.org/phmg/cottage-grove/locations/creswell"; }

            else
                URL = "http://www.webmd.com";

            return URL;
        }

    }
}
