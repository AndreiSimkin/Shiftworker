using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface IBase
    {
        public ObservableCollection<Models.ShiftPreset> ShiftPresets { get; }
        public ObservableCollection<Models.Courier> Couriers { get; }
        public ObservableCollection<Models.Month> Months { get;  }

        public Models.Month GetMonthByDate(int month, int year);
        public void AcceptСhanges();
    }
}
