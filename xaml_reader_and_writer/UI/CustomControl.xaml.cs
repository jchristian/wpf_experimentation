using System;
using System.Windows;
using System.Windows.Controls;

namespace UI
{
    /// <summary>
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        public bool IWasClick { get; set; }

        public event Action Click = delegate { };

        public CustomControl()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            IWasClick = true;

            Click();
        }
    }

    public class UserControl<T> : UserControl, IDisplayA<T>
    {
        public new T DataContext
        {
            get { return (T)base.DataContext; }
            set { base.DataContext = value; }
        }
    }

    public interface IDisplayA<T>
    {
        T DataContext { get; set; }
    }
}