// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BMICalculator
{
    [Register ("FemaleViewController")]
    partial class FemaleViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FemaleBMIOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FemaleChartButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView FemaleImage { get; set; }

        [Action ("FemaleChartButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FemaleChartButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (FemaleBMIOutputLabel != null) {
                FemaleBMIOutputLabel.Dispose ();
                FemaleBMIOutputLabel = null;
            }

            if (FemaleChartButton != null) {
                FemaleChartButton.Dispose ();
                FemaleChartButton = null;
            }

            if (FemaleImage != null) {
                FemaleImage.Dispose ();
                FemaleImage = null;
            }
        }
    }
}