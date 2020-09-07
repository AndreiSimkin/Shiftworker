using DevExpress.Mvvm;
using Samokat.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Samokat.Data.Models
{
    public class ShiftPreset : IShiftPreset, INotifyPropertyChanged
    {
        public string Name { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public int Count { get; set; } = 1;
        public TimeSpan Hours
        {
            get
            {
                return From.Hours <= To.Hours && From.Minutes <= To.Minutes ? new TimeSpan(To.Hours - From.Hours, To.Minutes - From.Minutes, 0) : new TimeSpan(23 - To.Hours - From.Hours, 60 - To.Minutes - From.Minutes, 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
