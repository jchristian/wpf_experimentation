using System.Windows;
using ui.Funds;

namespace ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new Main().ShowDialog();
        }
    }
}
