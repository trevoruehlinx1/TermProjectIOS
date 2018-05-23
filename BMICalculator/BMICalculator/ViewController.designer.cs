// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BMICalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider HeightSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HeightSliderOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider WeightSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel weightSliderOutputLabel { get; set; }

        [Action ("HeightSliderValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HeightSliderValueChanged (UIKit.UISlider sender);

        [Action ("WeightSliderValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WeightSliderValueChanged (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (HeightSlider != null) {
                HeightSlider.Dispose ();
                HeightSlider = null;
            }

            if (HeightSliderOutputLabel != null) {
                HeightSliderOutputLabel.Dispose ();
                HeightSliderOutputLabel = null;
            }

            if (WeightSlider != null) {
                WeightSlider.Dispose ();
                WeightSlider = null;
            }

            if (weightSliderOutputLabel != null) {
                weightSliderOutputLabel.Dispose ();
                weightSliderOutputLabel = null;
            }
        }
    }
}