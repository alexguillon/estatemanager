using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
namespace EstateMgr
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        public SeriesCollection MySeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void Click_Statistic_Year(object sender, RoutedEventArgs e)
        {
            MySeriesCollection = null;
            MySeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2017",
                    Values = new ChartValues<double> { 5,2,3,4,5,8,12,7,1,8,11,4 }
                }
            };

            Labels = new[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }
        private void Click_Statistic_Month(object sender, RoutedEventArgs e)
        {
            MySeriesCollection = null;
            MySeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> {1,0,1,1,1,0,2,1,2,1,1,0,1,1,1,0,1,1,1,1,1,2,1,1,1,0,1,1,0,1},
                    Fill = Brushes.Transparent,
                    Title= "Ventes"
                }

            };
 

                Labels = new[]
                {
                DateTime.Now.AddDays(-30).ToString("dd MMM"),
                DateTime.Now.AddDays(-29).ToString("dd MMM"),
                DateTime.Now.AddDays(-28).ToString("dd MMM"),
                DateTime.Now.AddDays(-27).ToString("dd MMM"),
                DateTime.Now.AddDays(-26).ToString("dd MMM"),
                DateTime.Now.AddDays(-25).ToString("dd MMM"),
                DateTime.Now.AddDays(-24).ToString("dd MMM"),
                DateTime.Now.AddDays(-23).ToString("dd MMM"),
                DateTime.Now.AddDays(-22).ToString("dd MMM"),
                DateTime.Now.AddDays(-21).ToString("dd MMM"),
                DateTime.Now.AddDays(-20).ToString("dd MMM"),
                DateTime.Now.AddDays(-19).ToString("dd MMM"),
                DateTime.Now.AddDays(-18).ToString("dd MMM"),
                DateTime.Now.AddDays(-17).ToString("dd MMM"),
                DateTime.Now.AddDays(-16).ToString("dd MMM"),
                DateTime.Now.AddDays(-15).ToString("dd MMM"),
                DateTime.Now.AddDays(-14).ToString("dd MMM"),
                DateTime.Now.AddDays(-13).ToString("dd MMM"),
                DateTime.Now.AddDays(-12).ToString("dd MMM"),
                DateTime.Now.AddDays(-11).ToString("dd MMM"),
                DateTime.Now.AddDays(-10).ToString("dd MMM"),
                DateTime.Now.AddDays(-9).ToString("dd MMM"),
                DateTime.Now.AddDays(-8).ToString("dd MMM"),
                DateTime.Now.AddDays(-7).ToString("dd MMM"),
                DateTime.Now.AddDays(-6).ToString("dd MMM"),
                DateTime.Now.AddDays(-5).ToString("dd MMM"),
                DateTime.Now.AddDays(-4).ToString("dd MMM"),
                DateTime.Now.AddDays(-3).ToString("dd MMM"),
                DateTime.Now.AddDays(-2).ToString("dd MMM"),
                DateTime.Now.AddDays(-1).ToString("dd MMM"),
                DateTime.Now.ToString("dd MMM"),
                };         
            DataContext = this;
        }
    }
}