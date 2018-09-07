// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace KeyFinder
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FinalKeyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView instrumentPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton KeyFinderButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView keyPickerLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FinalKeyLabel != null) {
                FinalKeyLabel.Dispose ();
                FinalKeyLabel = null;
            }

            if (instrumentPicker != null) {
                instrumentPicker.Dispose ();
                instrumentPicker = null;
            }

            if (KeyFinderButton != null) {
                KeyFinderButton.Dispose ();
                KeyFinderButton = null;
            }

            if (keyPickerLabel != null) {
                keyPickerLabel.Dispose ();
                keyPickerLabel = null;
            }
        }
    }
}