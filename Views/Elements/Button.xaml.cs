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
    /// Логика взаимодействия для Button.xaml
    /// </summary>
    public partial class Button : UserControl
    {
        public Button()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty EnabledProperty =
            DependencyProperty.Register("Enabled", typeof(bool), typeof(Button), new PropertyMetadata(true));

        public static readonly DependencyProperty RoundMaskColorProperty =
DependencyProperty.Register(
"RoundMaskColor", typeof(Brush), typeof(Button), new PropertyMetadata(Brushes.Transparent));

        public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(
        "Command",
        typeof(ICommand),
        typeof(Button));


        public bool Enabled
        {
            get { return (bool)GetValue(EnabledProperty); }
            set { SetValue(EnabledProperty, value); }
        }

        public Brush RoundMaskColor
        {
            get { return (Brush)GetValue(RoundMaskColorProperty); }
            set { SetValue(RoundMaskColorProperty, value); }
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
    }
}
