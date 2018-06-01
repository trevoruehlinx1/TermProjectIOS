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
    [Register ("MaleViewController")]
    partial class MaleViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView Chart2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Chart2Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MaleBMIChart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MaleBMIOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MaleChartImageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MaleExtraMessageOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MaleImage { get; set; }

        [Action ("MaleChartImageButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MaleChartImageButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Chart2 != null) {
                Chart2.Dispose ();
                Chart2 = null;
            }

            if (Chart2Button != null) {
                Chart2Button.Dispose ();
                Chart2Button = null;
            }

            if (MaleBMIChart != null) {
                MaleBMIChart.Dispose ();
                MaleBMIChart = null;
            }

            if (MaleBMIOutputLabel != null) {
                MaleBMIOutputLabel.Dispose ();
                MaleBMIOutputLabel = null;
            }

            if (MaleChartImageButton != null) {
                MaleChartImageButton.Dispose ();
                MaleChartImageButton = null;
            }

            if (MaleExtraMessageOutputLabel != null) {
                MaleExtraMessageOutputLabel.Dispose ();
                MaleExtraMessageOutputLabel = null;
            }

            if (MaleImage != null) {
                MaleImage.Dispose ();
                MaleImage = null;
            }
        }
    }
}