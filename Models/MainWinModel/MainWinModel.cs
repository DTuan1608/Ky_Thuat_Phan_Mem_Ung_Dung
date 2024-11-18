using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Input;
using System.Windows.Controls;

namespace KTPMUD.Models.MainWinModel
{

    public class MainWinModel : BaseModel
    {
        public SeriesCollection SeriesCollection1 { get; set; }
        public List<string> Labels1 { get; set; }
        public Func<double, string> Values1 { get; set; }

        public MainWinModel()
        {
            SeriesCollection1 = new SeriesCollection
            { 
                new LineSeries
                {
                    Title = "Sample Data",
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                }
            };
            Labels1 = new List<string> { "A", "B", "C", "D" };
            Values1 = value => value.ToString("N");
        }
    }
}
