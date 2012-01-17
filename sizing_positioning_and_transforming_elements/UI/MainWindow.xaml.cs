using System.Windows;
using UI.sizing;

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

            Sizing.Click += (s, e) => new Sizing().ShowDialog();
            Visibility.Click += (s, e) => new visibility.Visibility().ShowDialog();
            Alignment.Click += (s, e) => new alignment.Alignment().ShowDialog();
        }
    }
}
