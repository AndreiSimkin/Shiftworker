using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using Samokat.Models.Elements;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Samokat.ViewModels.Elements
{
    public class DayItemViewModel : ViewModelBase, IDay
    {
        private DayItemModel Model;

        public DayItemViewModel(IDay day)
        {
            Model = new DayItemModel(day);
            Model.PropertyChanged += (s, e) => RaisePropertiesChanged(e.PropertyName);
        }

        public string Date => Model.Date;
        public string[] Schedule => Model.Schedule;

        List<Shift> IDay.Shifts { get; set; }
        DateTime IDay.Date { get; set; }

        public bool Equals([AllowNull] Day other) => other.Date.Year == (this as IDay).Date.Year && other.Date.Month == (this as IDay).Date.Month && other.Date.Day == (this as IDay).Date.Day;

        public override string ToString() => (this as IDay).Date.ToShortDateString();
    }
}
