using Samokat.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Samokat.Views.Elements
{
    /// <summary>
    /// Логика взаимодействия для DatePicker.xaml
    /// </summary>
    public partial class DayPicker : UserControl
    {
        public DayPicker()
        {
            InitializeComponent();
        }

        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }

            set
            {
                SetValue(CommandProperty, value);
            }
        }

        public bool Enabled
        {
            get { return (bool)GetValue(EnabledProperty); }
            set { SetValue(EnabledProperty, value); }
        }

        public Data.Models.Month Month
        {
            get { return (Data.Models.Month)GetValue(MonthProperty); }
            set { SetValue(MonthProperty, value); }
        }

        public static readonly DependencyProperty MonthProperty =
    DependencyProperty.Register("Month", typeof(Data.Models.Month), typeof(DayPicker), new PropertyMetadata(null));

        public static readonly DependencyProperty EnabledProperty =
            DependencyProperty.Register("Enabled", typeof(bool), typeof(DayPicker), new PropertyMetadata(true));

        public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(
        "Command",
        typeof(ICommand),
        typeof(DayPicker));
    }
}
