using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ui.Funds
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public new MainFundModel DataContext
        {
            get { return (MainFundModel)base.DataContext; }
            set { base.DataContext = value; }
        }

        public Main()
        {
            InitializeComponent();

            DataContext = new MainFundModel();

            foreach (var section in new ApplicationUriGenerator().GetAllFromFunds())
                DataContext.Sections.Add(section);

            DataContext.CurrentSection = DataContext.Sections.First();
        }

        void SectionClicked(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DataContext.CurrentSection = (Uri)((Label)sender).DataContext;
        }
    }

    public class ApplicationUriGenerator
    {
        public IEnumerable<Uri> GetAllFromFunds()
        {
            return new[] { "Benchmark", "Correlations", "Documents", "General", "Notes", "Performance", "Snapshot" }
                .Select(x => GetUri("ui", "Funds", x)).ToList();
        }

        Uri GetUri(string assemblyName, string @namespace, string fileName)
        {
            return new Uri(string.Format("/{0};component/{1}/{2}.xaml", assemblyName, @namespace, fileName), UriKind.Relative);
        }
    }

    public class MainFundModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ObservableCollection<Uri> Sections { get; private set; }
        
        Uri _currentSection;
        public Uri CurrentSection
        {
            get { return _currentSection; }
            set
            {
                if (_currentSection == value)
                    return;
                _currentSection = value;
                RaisePropertyChanged("CurrentSection");
            }
        }

        void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainFundModel()
        {
            Sections = new ObservableCollection<Uri>();
        }
    }
}
