using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using Samokat.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Samokat.ViewModels.Elements
{
    public class MonthPickerViewModel : ViewModelBase
    {
        public MonthPickerModel Model;

        public MonthPickerViewModel()
        {
            Model = new MonthPickerModel();
            Model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
        }

        public MonthPickerModel.Date Current => Model.Current;
        public int[] Years => MonthPickerModel.Years;
        public string[] Months => MonthPickerModel.Months;

        public ICommand ResetCommand => new DelegateCommand(() => Model.SetDefaultDate());
    }
}
