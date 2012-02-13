using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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

            //AddHandler(MouseRightButtonDownEvent, new MouseButtonEventHandler(Window_MouseRightButtonDown), true);
            AddHandler(CustomButton.BubbledClickEvent, new RoutedEventHandler(AddBorder));

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

            TheCustomButton.DirectClick += (s, e) => Debug.WriteLine("Outer Direct Click");
            TheCustomButton.TunneledClick += (s, e) => Debug.WriteLine("Outer Tunneled Click");
            TheCustomButton.BubbledClick += (s, e) => Debug.WriteLine("Outer Bubbled Click");
            TheInnerCustomButton.DirectClick += (s, e) => Debug.WriteLine("Inner Direct Click");
            TheInnerCustomButton.TunneledClick += (s, e) => Debug.WriteLine("Inner Tunneled Click");
            TheInnerCustomButton.BubbledClick += (s, e) => Debug.WriteLine("Inner Bubbled Click");
        }

        void Window_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var source = e.Source as Control;

            source.BorderBrush = Brushes.Black;
            source.BorderThickness = new Thickness(5);
        }

        void AddBorder(object sender, RoutedEventArgs e)
        {
            var alternateColor = Brushes.Turquoise;

            TheWindow.BorderBrush = TheWindow.BorderBrush == alternateColor ? Brushes.Black : alternateColor;
            TheWindow.BorderThickness = new Thickness(5);
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            var alternateColor = Brushes.BurlyWood;

            TheMainStackPanel.Background = TheMainStackPanel.Background == alternateColor ? Brushes.White : alternateColor;
        }
    }
}
