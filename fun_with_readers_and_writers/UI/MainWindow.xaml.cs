using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xaml;

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

            using (var reader = new XamlXmlReader("./Button.xaml"))
            using (var writer = new XamlXmlWriter(new FileStream("./Test.xaml", FileMode.Create), reader.SchemaContext))
            {
                while (reader.Read())
                {
                    writer.WriteNode(reader);
                }
            }

            using (var reader = new XamlObjectReader(new Button()))
            using (var writer = new XamlObjectWriter(reader.SchemaContext))
            {
                while (reader.Read())
                {
                    writer.WriteNode(reader);
                }

                var button = (Button)writer.Result;
            }

            using (var reader = new XamlXmlReader(new StringReader("<Button xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">This is a button</Button>")))
            using (var writer = new XamlObjectWriter(reader.SchemaContext))
            {
                while (reader.Read())
                {
                    writer.WriteNode(reader);
                }

                var button = (Button)writer.Result;
            }
        }
    }
}
