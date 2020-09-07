using Samokat.Data.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Samokat.Data.Models
{
    public class Day : IDay, INotifyPropertyChanged
    {
        public DateTime Date { get; set; }
        public List<Shift> Shifts { get; set; }

        public Day(DateTime date)
        {
            Shifts = new List<Shift>();
            this.Date = date;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool Equals([AllowNull] Day other) => other.Date.Year == Date.Year && other.Date.Month == Date.Month && other.Date.Day == Date.Day;
    }
}
