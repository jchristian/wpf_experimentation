#define TESTING
#undef TESTING
#define TESTING
using System;
using System.Windows;
using System.Windows.Markup;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs routedEventArgs)
        {
            var button = Application.LoadComponent(new Uri("/UI;component/customcontrol.xaml", UriKind.Relative));
            var xaml = XamlWriter.Save(button);

#if TESTING
#warning This code is testing shit
#error This code is testing shit
#endif
#line 3 "./CustomControl.xaml.cs"
            var @goto = 1;
#line hidden
            var a = (int)(object)"Hello";
#line default
        }
    }
}
