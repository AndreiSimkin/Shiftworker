using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Samokat.Models.Elements
{
    public class DayPickerModel : BindableBase
    {

        public DateTime Current;

        public void SetDefaultDate(System.Windows.Controls.SelectionChangedEventArgs args)
        {
            if (args.AddedItems.Count > 0)
            {
                Data.Models.Month month = (Data.Models.Month)args.AddedItems[0];
                if (DateTime.Today.Year == month.Date.Year && DateTime.Today.Month == month.Date.Month)
                {
                    Current = DateTime.Today;
                }
                else
                {
                    Current = month.DateStart;
                }
                RaisePropertiesChanged("Current");
            }
        }

        public void ReleseMouseCapture() => Mouse.Capture(null);
    }
}
