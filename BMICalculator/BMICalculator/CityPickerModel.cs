using System;
using UIKit;

namespace BMICalculator
{
    public class CityPickerModel: UIPickerViewModel
    {
        private string[] cityNames = { "Eugene", "Springfield", "Albany", "Salem", "Portland", "Cottage Grove", "Creswell" };

        private UITextField cityTextField;

        public CityPickerModel(UITextField cityLabel)
        {
            this.cityTextField = cityLabel;
        }

    // The number returned determines the number of rings in the picker
    public override nint GetComponentCount(UIPickerView pickerView)
    {
        return 1;
    }

    public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
    {
        return cityNames.Length;
    }

    public override string GetTitle(UIPickerView pickerView, nint row, nint component)
    {
        if (component == 0)
            return cityNames[row];
        else
            return row.ToString();
    }

    public override void Selected(UIPickerView pickerView, nint row, nint component)
    {
        cityTextField.Text = cityNames[pickerView.SelectedRowInComponent(0)];
        ((AppDelegate)(UIApplication.SharedApplication.Delegate)).cityName = cityTextField.Text;
    }

        public override nfloat GetComponentWidth(UIPickerView pickerView, nint component)
    {
        // there is only one component, this is it's width setting
        return 240f;
    }

        public override nfloat GetRowHeight(UIPickerView pickerView, nint component)
    {
        return 40f;
    }
    }
}
