using Samokat.Data.Enums;
using Samokat.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Samokat.Data.Models
{
    public class Courier : ICourier, INotifyPropertyChanged
    {
        public bool Fired { get; set; }
        public CourierStatus Status { get; set; }
        public string FullName { get; set; } 
        public string Phone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
