using Samokat.Data.Interfaces;
using Samokat.Models;
using Samokat.Models.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Samokat.Data.Models
{
    public class Month : IMonth, IEquatable<Month>, INotifyPropertyChanged
    {
        public DateTime Date { get; set; }
        public DateTime DateStart => Date;
        public DateTime DateEnd => DateStart.AddMonths(1).AddDays(-1);
        public List<Day> Days { get; set; } 

        public Month(DateTime date)
        {
            Date = date;
            Days = new List<Day>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"{MonthPickerModel.Months[Date.Month - 1]} {Date.Year}";
        }

        public bool Equals([AllowNull] Month other) => other.Date.Year == Date.Year && other.Date.Month == Date.Month;
    }
}
