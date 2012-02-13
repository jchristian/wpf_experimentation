using System;
using System.Diagnostics;
using System.Windows.Input;

namespace UI
{
    public class CustomCommand : ICommand
    {
        public string MyCustomString { get { return "Custom Command!"; } }

        public void Execute(object parameter)
        {
            Debug.WriteLine("The custom command was executed!");
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}