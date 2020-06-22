using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiBindingExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Add some data
            SomeDataSource = new ObservableCollection<SomeDataSource>()
            {
                new SomeDataSource()
                {
                    SimpleBinding = "First Simple 1",
                    JoinBinding1 = "First Join 1",
                    JoinBinding2 = "Second Join 1"
                },
                new SomeDataSource()
                {
                    SimpleBinding = "First Simple 2",
                    JoinBinding1 = "First Join 2",
                    JoinBinding2 = "Second Join 2"
                },
                new SomeDataSource()
                {
                    SimpleBinding = "First Simple 3",
                    JoinBinding1 = "First Join 3",
                    JoinBinding2 = "Second Join 3"
                }
            };
            this.SampleCollectionView.ItemsSource = SomeDataSource;
        }


        public ObservableCollection<SomeDataSource> SomeDataSource { get; set; } = new ObservableCollection<SomeDataSource>();

    }

    public class SomeDataSource
    {
        public string SimpleBinding { get; set; }
        public string JoinBinding1 { get; set; }
        public string JoinBinding2 { get; set; }
        public string Url { get; set; } =
            "i/1000x1000/88/55/sample-rubber-stamp-vector-11858855.jpg";
        public string Host { get; set; } =
            "https://cdn1.vectorstock.com/";
    }
}
