using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace Samokat.Data
{
    public class DefaultBase : IBase
    {
        static IBase Data;
        string Path { get => "Data/Base.json"; }

        public ObservableCollection<ShiftPreset> ShiftPresets => Data.ShiftPresets;
        public ObservableCollection<Courier> Couriers => Data.Couriers;
        public ObservableCollection<Month> Months => Data.Months;

        public DefaultBase()
        {
            if (Data == null)
                Data = new Base("Data/Base.json");
        }

        public void AcceptСhanges() => Data.AcceptСhanges();
        void IBase.AcceptСhanges() => Data.AcceptСhanges();
        public Month GetMonthByDate(int month, int year) => Data.GetMonthByDate(month, year);
    }
}
