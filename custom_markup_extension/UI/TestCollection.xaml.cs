using System.Collections;
using System.Windows.Controls;
using System.Windows.Markup;

namespace UI
{
    /// <summary>
    /// Interaction logic for TestCollection.xaml
    /// </summary>
    [ContentProperty("List")]
    public partial class TestCollection : UserControl
    {
        public IList List { get; set; }

        public TestCollection()
        {
            InitializeComponent();
        }
    }
}
