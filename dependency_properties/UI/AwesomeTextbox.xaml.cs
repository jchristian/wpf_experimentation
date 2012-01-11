using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UI
{
    /// <summary>
    /// Interaction logic for AwesomeTextbox.xaml
    /// </summary>
    public partial class AwesomeTextbox : UserControl
    {
        public static DependencyProperty SquareColorProperty = DependencyProperty.Register("SquareColor", typeof(Brush), typeof(AwesomeTextbox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None, propertyCallback, coerceValueCallback), validateValueCallback);

        public Brush SquareColor
        {
            get { return (Brush)GetValue(SquareColorProperty); }
            set { SetValue(SquareColorProperty, value); }
        }

        public string BrushName { get; set; }

        static void propertyCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((AwesomeTextbox)d).TheRectangle.Fill = ((AwesomeTextbox)d).SquareColor;
            DependencyPropertyHelper.GetValueSource(d, SquareColorProperty);
        }

        static object coerceValueCallback(DependencyObject d, object basevalue)
        {
            if (basevalue == new BrushConverter().ConvertFrom("Blue"))
                return new BrushConverter().ConvertFrom("Red");
            return basevalue;
        }

        static bool validateValueCallback(object value)
        {
            return value != new BrushConverter().ConvertFrom("Yellow");
        }

        public AwesomeTextbox()
        {
            InitializeComponent();
        }

        private void TheTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (new BrushConverter().IsValid(TheTextBox.Text))
                SquareColor = (Brush)new BrushConverter().ConvertFromInvariantString(TheTextBox.Text);
            else
                SquareColor = (Brush)new BrushConverter().ConvertFromInvariantString("LightGray");
        }
    }
}
