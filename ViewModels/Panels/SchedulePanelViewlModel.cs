using DevExpress.Mvvm;
using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using Samokat.Models.Panels;
using Samokat.ViewModels.Elements;
using Samokat.Views.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Samokat.ViewModels.Panels
{
    public class SchedulePanelViewlModel : ViewModelBase
    {
        private SchedulePanelModel Model;

        public SchedulePanelViewlModel()
        {
            Model = new SchedulePanelModel();
            Model.PropertyChanged += (s, e) => RaisePropertyChanged(e.PropertyName);
        }

        public IDay CurrentDay => Model.CurrentDay;

        public ICommand SelectDayCommand => new DelegateCommand<DayItem>((DayItem day) => Model.SetCurrentDay(day.DataContext as IDay));
        public ICommand UnselectDayCommand => new DelegateCommand(() => Model.ResetCurrentDay());
    }
}
