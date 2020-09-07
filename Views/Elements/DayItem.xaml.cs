using Samokat.Models;
using Samokat.ViewModels;
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
    /// Логика взаимодействия для ListItem.xaml
    /// </summary>
    public partial class DayItem : UserControl
    {
        public DayItem()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CommandProperty =
DependencyProperty.Register(
"Command",
typeof(ICommand),
typeof(DayItem));

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
    }
}
