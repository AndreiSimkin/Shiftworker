using Samokat.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface ICourier
    {
        public bool Fired { get; set; }
        public CourierStatus Status { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}
