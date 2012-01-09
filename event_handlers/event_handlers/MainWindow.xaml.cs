using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace event_handlers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var button = (Button)XamlReader.Load(new FileInfo("CommandButton.xaml").OpenRead());
            ((Grid) FindName("TheGrid")).Children.Add(button);
        }
    }
}
