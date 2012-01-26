using System.Windows;
using UI.canvas;

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

        void CanvasButton_OnClick(object sender, RoutedEventArgs e)
        {
            new Canvas().ShowDialog();
        }
    }
}
