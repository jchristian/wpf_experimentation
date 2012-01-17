using System.Windows;
using System.Windows.Controls;

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
            
            var button = new Button{Content = "This is a button"};
            var textBlock = new TextBlock{Text="Test"};

            button.SetValue(Grid.ColumnProperty, 0);
            button.SetValue(Grid.RowProperty, 0);
            textBlock.SetValue(Grid.ColumnProperty, 1);
            textBlock.SetValue(Grid.RowProperty, 0);

            TheGrid.Children.Add(button);
            TheGrid.Children.Add(textBlock);

            //TheOrderedStackPanel.Order();
        }
    }
}
