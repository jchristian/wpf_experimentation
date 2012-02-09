using System.Linq;
using System.Windows;
using System.Windows.Media;

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

            MouseDown += (s, e) =>
            {
                TheText.Background = Brushes.Beige;
            };

            TheText.MouseDown += (s, e) =>
            {
                TheText.Background = Brushes.Azure;
                //This keeps the MouseDown handler on the window from raising
                e.Handled = true;
            };

            //MouseEnter is registered with a Direct routing strategy
            MouseEnter += (s, e) =>
            {
                TheText.Foreground = Brushes.Blue;
            };

            TheText.MouseEnter += (s, e) =>
            {
                TheText.Foreground = Brushes.Red;
            };

            TheOuterButton.Click += (s, e) =>
            {
                TheOuterButton.BorderBrush = new SolidColorBrush(new Color { R = 120, G = 145, B = 135 });
            };

            TheInnerButton.Click += (s, e) =>
            {
                TheOuterButton.BorderBrush = new SolidColorBrush(new Color { R = 45, G = 20, B = 35 });
                e.Handled = true;
            };

            //Setting handled here keeps the TextInput event on the TextBox from firing
            TheTextBox.PreviewTextInput += (s, e) =>
            {
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                if (e.Text.ToCharArray().All(x => !numbers.Contains(x)))
                    e.Handled = true;
            };
        }
    }
}
