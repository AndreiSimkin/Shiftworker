using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Models.Elements
{
    public class MonthPickerModel : BindableBase
    {
        public class Date
        {
            public int Year { get; set; }
            public int Month { get; set; }
        }

        public Date Current;

        public MonthPickerModel()
        {
            SetDefaultDate();
        }

        public void SetDefaultDate()
        {
            if (Current == null)
                Current = new Date() { Month = DateTime.Now.Month - 1, Year = DateTime.Now.Year };
            else
            {
                Current.Month = DateTime.Now.Month - 1;
                Current.Year = DateTime.Now.Year;
                RaisePropertiesChanged("Current");
            }
        }

        public static string[] Months
        {
            get
            {
                return new string[] {
                    "Январь",
                    "Февраль",
                    "Март",
                    "Апрель",
                    "Май",
                    "Июнь",
                    "Июль",
                    "Август",
                    "Сентябрь",
                    "Октябрь",
                    "Ноябрь",
                    "Декабрь"
                };
            }
        }
        public static int[] Years { get
            {
                int Count = 12;
                int[] years = new int[Count];
                int StartYear = DateTime.Now.Year - 1;
                for (int i = 0; i < Count; i++)
                    years[i] = StartYear + i;
                return years;
            }
        }
    }
}
