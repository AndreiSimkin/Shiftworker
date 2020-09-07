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
    public class ShiftsEditorPanelModel : BindableBase
    {
        private readonly IBase Data;

        public ObservableCollection<ShiftPreset> ShiftPresets => Data.ShiftPresets;

        public ShiftsEditorPanelModel()
        {
            Data = new DefaultBase();
        }
    }
}
