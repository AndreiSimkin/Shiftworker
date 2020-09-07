using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface IDay : IEquatable<Day>
    {
        public DateTime Date { get; set; }
        public List<Shift> Shifts { get; set; }
    }
}
