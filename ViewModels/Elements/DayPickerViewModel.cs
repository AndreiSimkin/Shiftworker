using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using Samokat.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Samokat.ViewModels.Elements
{
    public class DayPickerViewModel : ViewModelBase
    {
        public DayPickerModel Model;

        public DayPickerViewModel()
        {
            Model = new DayPickerModel();
            Model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
        }

        public DateTime Current { get { return Model.Current; } set { Model.Current = value; } }

        public ICommand ReleaseMouseCaptureCommand => new DelegateCommand(() => Model.ReleseMouseCapture());
        public ICommand ResetCommand => new DelegateCommand<System.Windows.Controls.SelectionChangedEventArgs>((System.Windows.Controls.SelectionChangedEventArgs args) => Model.SetDefaultDate(args));
    }
}
