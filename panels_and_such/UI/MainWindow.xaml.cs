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

        void StackPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            new stackpanel.StackPanel().ShowDialog();
        }

        void WrapPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            new wrappanel.WrapPanel().ShowDialog();
        }

        void DockPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            new dockpanel.DockPanel().ShowDialog();
        }

        void GridPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            new grid.Grid().ShowDialog();
        }

        void ClippingButton_OnClick(object sender, RoutedEventArgs e)
        {
            new clipping.Clipping().ShowDialog();
        }
    }
}
