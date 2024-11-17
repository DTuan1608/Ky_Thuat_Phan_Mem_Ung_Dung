using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KTPMUD.Controllers
{
    public class ControlBarController : BaseController
    {
        public ICommand CloseWindowCommand { get; set; }
        public ControlBarController() 
        {
            
        }
        
    }
}
