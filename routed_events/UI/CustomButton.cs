using System.Windows;
using System.Windows.Controls;

namespace UI
{
    public class CustomButton : Button
    {
        public static RoutedEvent DirectClickEvent;
        public static RoutedEvent TunneledClickEvent;
        public static RoutedEvent BubbledClickEvent;

        public event RoutedEventHandler DirectClick
        {
            add { AddHandler(DirectClickEvent, value); }
            remove { RemoveHandler(DirectClickEvent, value); }
        }

        public event RoutedEventHandler TunneledClick
        {
            add { AddHandler(TunneledClickEvent, value); }
            remove { RemoveHandler(TunneledClickEvent, value); }
        }

        public event RoutedEventHandler BubbledClick
        {
            add { AddHandler(BubbledClickEvent, value); }
            remove { RemoveHandler(BubbledClickEvent, value); }
        }

        static CustomButton()
        {
            DirectClickEvent = EventManager.RegisterRoutedEvent("DirectClick", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(CustomButton));
            TunneledClickEvent = EventManager.RegisterRoutedEvent("TunneledClick", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(CustomButton));
            BubbledClickEvent = EventManager.RegisterRoutedEvent("BubbledClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomButton));
        }

        public CustomButton()
        {
            Click += (s, e) =>
            {
                RaiseEvent(new RoutedEventArgs(DirectClickEvent, this));
                RaiseEvent(new RoutedEventArgs(TunneledClickEvent, this));
                RaiseEvent(new RoutedEventArgs(BubbledClickEvent, this));
            };
        }
    }
}