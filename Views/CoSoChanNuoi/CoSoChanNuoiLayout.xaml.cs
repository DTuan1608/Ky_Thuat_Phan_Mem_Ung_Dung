using DeviceConfig.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.ModelConfiguration.Configuration;
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

namespace KTPMUD.Views.CoSoChanNuoi
{
    /// <summary>
    /// Interaction logic for CoSoChanNuoiLayout.xaml
    /// </summary>
    public partial class CoSoChanNuoiLayout : UserControl
    {
        public CoSoChanNuoiLayout()
        {
            InitializeComponent();
        }
    }
    public class Index : BaseView<CoSoChanNuoiLayout, System.Data.DataTable> 
    {
        protected override void RenderCore()
        {
            base.RenderCore();
           
        }
    }



}
