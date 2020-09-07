using DevExpress.Mvvm;
using Samokat.Data;
using Samokat.Data.Interfaces;
using Samokat.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Samokat.Models.Panels
{
    public class SchedulePanelModel : BindableBase
    {
        private readonly IBase Data;

        public IDay CurrentDay { get; protected set; }

        public void SetCurrentDay(IDay day)
        {
            this.CurrentDay = day;
        }

        public void ResetCurrentDay()
        {
            this.CurrentDay = null;
        }

        public SchedulePanelModel()
        {
            Data = new DefaultBase();
        }
    }
}
