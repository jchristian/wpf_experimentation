using System.Windows.Controls;

namespace UI
{
    public class UserControl<T> : UserControl, IDisplayA<T>
    {
        public new T DataContext
        {
            get { return (T)base.DataContext; }
            set { base.DataContext = value; }
        }
    }
}