using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace UI
{
    public class OrderedStackPanel : StackPanel
    {
        public static DependencyProperty OrderProperty = DependencyProperty.RegisterAttached("Order", typeof(int), typeof(OrderedStackPanel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetOrder(DependencyObject element, int value)
        {
            element.SetValue(OrderProperty, value);
        }

        public static int GetOrder(DependencyObject element)
        {
            return (int)element.GetValue(OrderProperty);
        }

        public OrderedStackPanel()
        {
            LayoutUpdated += (s, e) => Order();
        }

        public void Order()
        {
            var orderDictionary = new Dictionary<int, UIElement>();

            foreach (var child in Children.OfType<UIElement>().ToList())
            {
                orderDictionary.Add(GetOrder(child), child);
                Children.Remove(child);
            }

            foreach (var child in orderDictionary.OrderBy(x => x.Key))
                Children.Add(child.Value);
        }
    }
}