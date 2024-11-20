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

namespace KTPMUD.Views.CoSoChanNuoi
{
    /// <summary>
    /// Interaction logic for EditLayout.xaml
    /// </summary>
    public partial class EditLayout : UserControl
    {
        public EditLayout()
        {
            InitializeComponent();
        }
    }

    public class Edit : FormView<EditLayout>
    {
        
    }

    public class Insert : Edit { 
        
    }

    public class Delete : Edit { }
}
