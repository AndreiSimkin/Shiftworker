using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samokat.Data.Interfaces
{
    public interface IMonth
    {
        public DateTime Date { get; set; }
        public List<Day> Days { get; set; }
    }
}
