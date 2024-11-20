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

namespace KTPMUD.Views
{
    /// <summary>
    /// Interaction logic for FormView.xaml
    /// </summary>
    public partial class FormViewLayout : UserControl
    {
        public FormViewLayout()
        {
            InitializeComponent();
        }
    }

    public class FormView<TView> : BaseView<FormViewLayout, object> 
        where TView : FrameworkElement, new()
    {
        public TView EditBox { get; set; }
        protected override void RenderCore()
        {
            EditBox = new TView();
            MainContent.Body.Child = EditBox;
        }
    }
}
