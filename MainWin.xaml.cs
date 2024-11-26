using DeviceConfig.Views;
using KTPMUD.Views.Home;
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
using System.Windows.Shapes;

namespace KTPMUD.Views.Main
{
    /// <summary>
    /// Interaction logic for MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
           
            System.Mvc.Engine.Register(this, r => {
                var view = r.View;
                var uie = view.Content as UIElement;
                this.MainContent.Child = uie;
            });

            System.Mvc.Engine.Execute("CoSoChanNuoi/Add");
        }

    }
}
