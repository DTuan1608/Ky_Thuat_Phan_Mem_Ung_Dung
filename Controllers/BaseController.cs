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
        static public Provider Provider { get; set; } = new Provider();
        public virtual object Index() => View(Provider.Select(this.ControllerName));

    }
}
