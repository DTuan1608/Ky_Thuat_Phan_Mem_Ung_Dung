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

namespace KTPMUD.Views.Home
{
    /// <summary>
    /// Interaction logic for LoginLayout.xaml
    /// </summary>
    public partial class LoginLayout : UserControl
    {
        public LoginLayout()
        {
            InitializeComponent();
        }
    }

    public class Login : BaseView<LoginLayout, object> { }

}
