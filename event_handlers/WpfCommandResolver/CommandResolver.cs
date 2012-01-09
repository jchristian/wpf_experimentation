using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace WpfCommandResolver
{
    public class CommandResolver : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return (RoutedEventHandler)((sender, args) => new ClickCommandHandler().Handle());
        }
    }

    public class ClickCommandHandler
    {
        public void Handle()
        {
            Debug.WriteLine("Handled");
        }
    }
}