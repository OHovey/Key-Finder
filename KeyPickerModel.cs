using System;
using System.Collections.Generic;
using UIKit;

namespace KeyFinder
{
    public class KeyPickerModel : UIPickerViewModel
    {
        List <string> Key;
        public EventHandler ValueChanged;
        public string SelectedValue;
        public KeyPickerModel(List<string> Key) {
            this.Key = Key;
        }
        public override nint GetRowsInComponent(UIPickerView pickerView, nint component) {
            return Key.Count;
        }
        public override nint GetComponentCount(UIPickerView pickerview) {
            return 1;
        }
        public override string GetTitle(UIPickerView pickerView, nint row, nint component) {
            return Key[(int)row];
        }
        public override void Selected(UIPickerView pickerView, nint row, nint component) {
           
            var key = Key[(int)row];

            SelectedValue = key;
            ValueChanged?.Invoke(null, null);

        }
    }
    public class InstrumentPickerModel : UIPickerViewModel
    {
        List<string> Instrument;
        public EventHandler valueChanged;
        public string SelectedValue;
        public InstrumentPickerModel(List<string> Instrument) {
            this.Instrument = Instrument;
        }
        public override nint GetRowsInComponent(UIPickerView pickerView, nint componant) {
            return Instrument.Count;
        }
        public override nint GetComponentCount(UIPickerView pickerView) {
            return 1;
        }
        public override string GetTitle(UIPickerView pickerView, nint row, nint componant) {
            return Instrument[(int)row];
        }
        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {

            var instrument = Instrument[(int)row];

            SelectedValue = instrument;
            valueChanged?.Invoke(null, null);

        }
    }
}
