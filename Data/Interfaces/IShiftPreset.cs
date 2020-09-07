using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface IShiftPreset : IShift
    {
        public int Count { get; set; }
        public TimeSpan Hours { get; }
    }
}
