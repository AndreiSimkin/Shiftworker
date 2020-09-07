using DevExpress.Mvvm;
using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Samokat.Models.Elements
{
    public class DayItemModel : BindableBase, IDay
    {
        public DayItemModel(IDay day)
        {
            (this as IDay).Date = day.Date;
            (this as IDay).Shifts = day.Shifts;
        }

        public string Date { get => (this as IDay).Date.ToShortDateString(); }

        public string[] Schedule
        {
            get
            {
                if ((this as IDay).Shifts.Count == 0)
                    return new string[] { "Добавьте расписание!" };
                else
                {
                    string[] schedule = new string[(this as IDay).Shifts.Count];
                    for (int i = 0; i < schedule.Length; i++)
                        schedule[i] = $"{(this as IDay).Shifts[i].Courier.FullName}: c {(this as IDay).Shifts[i].From} по {(this as IDay).Shifts[i].To}";
                    return schedule;
                }
            }
        }

        List<Shift> IDay.Shifts { get; set; }
        DateTime IDay.Date { get; set; }

        public bool Equals([AllowNull] Day other) => other.Date.Year == (this as IDay).Date.Year && other.Date.Month == (this as IDay).Date.Month && other.Date.Day == (this as IDay).Date.Day;
    }
}
