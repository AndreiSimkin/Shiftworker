using DevExpress.Mvvm;
using Samokat.Data;
using Samokat.Data.Interfaces;
using Samokat.ViewModels.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;

namespace Samokat.Models.Panels
{
    public class CalendarPanelModel : BindableBase
    {
        private readonly IBase Data;

        public bool IsMonthSelected => CurrentMonth != null;
        public List<DayItemViewModel> Calendar => IsMonthSelected ? CurrentMonth.Days.ConvertAll((day) => new DayItemViewModel(day)) : null;
        public ObservableCollection<Data.Models.Month> Months => Data.Months;
        public Data.Models.Month CurrentMonth { get; set; }

        public CalendarPanelModel()
        {
            Data = new DefaultBase();
            ResetCurrentMonth();
        }

        public void ResetCurrentMonth()
        {
            if (Data.Months.Count > 0)
            {
                int index = Data.Months.IndexOf(new Data.Models.Month(DateTime.Today));
                if (index < 0)
                    index = 0;
                CurrentMonth = Data.Months[index];
            }    
        }

        public void AddDay(Data.Models.Day day)
        {
            if (!CurrentMonth.Days.Contains(day))
            {
                CurrentMonth.Days.Insert(0, day);
                RaisePropertiesChanged("Calendar");
            }
            else
                MessageBox.Show("Такой день уже существует!", "Ошибка добавления", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void AddMonth(Data.Models.Month month)
        {
            if (!Data.Months.Contains(month))
            {
                Data.Months.Insert(0, month);
                CurrentMonth = month;
                RaisePropertiesChanged("Months", "CurrentMonth", "CanDeleteMonth");
            }
            else
                MessageBox.Show("Такой месяц уже существует!", "Ошибка добавления", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void DeleteCurrentMonth()
        {
            if (MessageBox.Show($"Вы точно хотите удалить график за {CurrentMonth}?", "Удалить?", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                int Index = Data.Months.IndexOf(CurrentMonth) - 1;
                if (Index < 0) Index = 0;
                Data.Months.Remove(CurrentMonth);
                if (Data.Months.Count > 0)
                    CurrentMonth = Data.Months[Index];
                else
                    CurrentMonth = null;
                RaisePropertiesChanged("Months", "CurrentMonth", "CanDeleteMonth");
            }
        }
    }
}
