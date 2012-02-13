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

            var a = ApplicationCommands.Help;

            CommandBindings.Add(new CommandBinding(ApplicationCommands.Help, HelpExecuted, HelpCanExecute));
            InputBindings.Add(new KeyBinding(ApplicationCommands.Help, new KeyGesture(Key.D, ModifierKeys.Alt)));
        }

        void HelpCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Help me!");
        }
    }
}
