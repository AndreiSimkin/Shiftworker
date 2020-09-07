using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Samokat.Data;
using Samokat.Data.Interfaces;
using Samokat.ViewModels.Elements;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace Samokat.Models
{
    public class WindowModel : BindableBase
    {
        private readonly IBase Data;
        public event EventHandler OnNotify;

        public WindowModel()
        {
            Data = new DefaultBase();
        }

        public void ShowNotify(string text)
        {
            NotifyText = text;
            OnNotify.Invoke(this, new EventArgs());
        }

        public string NotifyText { get; protected set; }
        public void SaveData() => Data.AcceptСhanges(); 
    }
}
