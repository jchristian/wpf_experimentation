using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;

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

            var list = MyTestCollection.List;
        }
    }

    public class FromCache : MarkupExtension
    {
        public static IDictionary<string, string> _cache = new Dictionary<string, string> { { "HelloMessage", "Welcome, that is a lovely tnetennba you are wearing." } };

        public string Name { get; set; }

        public FromCache() {}

        public FromCache(string name)
        {
            Name = name;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _cache[Name];
        }
    }
}