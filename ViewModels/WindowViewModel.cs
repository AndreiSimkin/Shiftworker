using DevExpress.Mvvm;
using Samokat.Models.Elements;
using Samokat.Models;
using Samokat.ViewModels.Elements;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Samokat.ViewModels
{
    class WindowViewModel : ViewModelBase
    {
        private WindowModel Model;

        public WindowViewModel()
        {
            Model = new WindowModel();
            Model.PropertyChanged += (s, e) => RaisePropertyChanged(e.PropertyName);
            Model.OnNotify += (s, e) => OnNotify?.Invoke(s, e);
        }

        public string NotifyText => Model.NotifyText;
        public event EventHandler OnNotify;
        public ICommand SaveDataCommand => new DelegateCommand(() => Model.SaveData());
        public ICommand ShowNotifyCommand => new DelegateCommand<string>((string text) => Model.ShowNotify(text));
    }
}
