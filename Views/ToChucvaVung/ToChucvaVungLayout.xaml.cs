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

namespace KTPMUD.Views.ToChucvaVung
{
    /// <summary>
    /// Interaction logic for ToChucvaVungLayout.xaml
    /// </summary>
    public partial class ToChucvaVungLayout : UserControl
    {
        public ToChucvaVungLayout()
        {
            InitializeComponent();
        }
    }
    public class Index : BaseView <ToChucvaVungLayout, object> { }
}
