using DevExpress.Mvvm;
using Samokat.Data.Models;
using Samokat.Models.Panels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Samokat.ViewModels.Panels
{
    public class CouriersEditorPanelViewModel : ViewModelBase
    {
        private CouriersEditorPanelModel Model;

        public ObservableCollection<Courier> Couriers => Model.Couriers;

        public CouriersEditorPanelViewModel()
        {
            Model = new CouriersEditorPanelModel();
            Model.PropertyChanged += (s, e) => RaisePropertyChanged(e.PropertyName);
        }
    }
}
