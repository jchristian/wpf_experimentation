using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

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

            TheStackPanel.KeyDown += OnKeyDown;
            TheFirstTextBox.KeyDown += OnKeyDown;
            TheLabel.KeyDown += OnKeyDown;
            TheSecondTextBox.KeyDown += OnKeyDown;
        }

        public void OnKeyDown(object sender, KeyEventArgs args)
        {
            if (args.KeyboardDevice.IsKeyDown(Key.A) &&
                args.KeyboardDevice.IsKeyDown(Key.LeftAlt))
                Debug.WriteLine("");
        }
    }
}
