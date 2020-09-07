using DevExpress.Mvvm;
using Samokat.Data.Models;
using Samokat.Models.Panels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Samokat.ViewModels.Panels
{
    public class ShiftEditorPanelViewModel : ViewModelBase
    {
        private ShiftsEditorPanelModel Model;

        public ObservableCollection<ShiftPreset> ShiftPresets => Model.ShiftPresets;

        public ShiftEditorPanelViewModel()
        {
            Model = new ShiftsEditorPanelModel();
            Model.PropertyChanged += (s, e) => RaisePropertyChanged(e.PropertyName);
        }
    }
}
