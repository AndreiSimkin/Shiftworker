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
    class CouriersEditorPanelModel : BindableBase
    {
        private readonly IBase Data;

        public ObservableCollection<Courier> Couriers => Data.Couriers;

        public CouriersEditorPanelModel()
        {
            Data = new DefaultBase();
        }
    }
}
