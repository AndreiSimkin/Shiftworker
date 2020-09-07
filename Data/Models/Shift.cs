using Samokat.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Samokat.Data.Models
{
    public class Shift : IShift, INotifyPropertyChanged
    {
        public string Name { get; set; }
        public ICourier Courier { get; set; }
        public string Comment { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
