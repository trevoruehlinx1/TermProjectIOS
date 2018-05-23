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
        UIKit.UIImageView MaleBMIChart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MaleBMIOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView MaleImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MaleBMIChart != null) {
                MaleBMIChart.Dispose ();
                MaleBMIChart = null;
            }

            if (MaleBMIOutputLabel != null) {
                MaleBMIOutputLabel.Dispose ();
                MaleBMIOutputLabel = null;
            }

            if (MaleImage != null) {
                MaleImage.Dispose ();
                MaleImage = null;
            }
        }
    }
}