using DeviceConfig.Views;
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

namespace KTPMUD.Views.CoSoCheBien
{
    /// <summary>
    /// Interaction logic for CoSoCheBien.xaml
    /// </summary>
    public partial class CoSoCheBienLayout : UserControl
    {
        public CoSoCheBienLayout()
        {
            InitializeComponent();
        }
    }
    public class Index : BaseView<CoSoCheBienLayout, object> { }
}
