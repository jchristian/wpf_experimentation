using System;
using System.Diagnostics;
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

            Debug.WriteLine("Printing the Logical Tree");
            PrintLogicalTree(0, this);
        }

        protected override void OnContentRendered(EventArgs args)
        {
            Debug.WriteLine("");
            Debug.WriteLine("Printing the Visual Tree");
            PrintVisualTree(0, this);
        }

        void PrintLogicalTree(int depth, object obj)
        {
            Debug.WriteLine(string.Format("{0} : {1}", obj, depth));

            if (!(obj is DependencyObject))
                return;

            foreach (var child in LogicalTreeHelper.GetChildren(obj as DependencyObject))
                PrintLogicalTree(depth + 1, child);
        }

        void PrintVisualTree(int depth, object obj)
        {
            Debug.WriteLine(string.Format("{0} : {1}", obj, depth));

            if (!(obj is DependencyObject))
                return;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj as DependencyObject); i++)
            {
                PrintVisualTree(depth + 1, VisualTreeHelper.GetChild(obj as DependencyObject, i));
            }
        }
    }
}
