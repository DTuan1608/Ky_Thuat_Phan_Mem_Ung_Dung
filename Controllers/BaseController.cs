using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KTPMUD.Controllers
{
    public class BaseController : System.Mvc.Controller
    {
       
        public virtual object Index() => View();

    }
}
