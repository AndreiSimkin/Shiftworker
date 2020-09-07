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
using Samokat.Models.Panels;

namespace Samokat.ViewModels.Panels
{
    public class CalendarPanelViewModel : ViewModelBase
    {
        private CalendarPanelModel Model;

        public CalendarPanelViewModel()
        {
            Model = new CalendarPanelModel();
            Model.PropertyChanged += (s, e) => RaisePropertyChanged(e.PropertyName);
        }

        public List<DayItemViewModel> Calendar => Model.Calendar;
        public ObservableCollection<Data.Models.Month> Months => Model.Months;
        public Data.Models.Month CurrentMonth { get { return Model.CurrentMonth; } set { Model.CurrentMonth = value; } }
        public bool IsMonthSelected => Model.IsMonthSelected;

        public ICommand AddMonthCommand => new DelegateCommand<MonthPickerModel.Date>((MonthPickerModel.Date args) => Model.AddMonth(new Data.Models.Month(new DateTime(args.Year, args.Month + 1, 1))));
        public ICommand DeleteCurrentMonthCommand => new DelegateCommand(() => Model.DeleteCurrentMonth());
        public ICommand AddDayCommand => new DelegateCommand<DateTime>((DateTime args) => Model.AddDay(new Data.Models.Day(args)));
    }
}
