using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface IShift
    {
        public string Name { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
    }
}
