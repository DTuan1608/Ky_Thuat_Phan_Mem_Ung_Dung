using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Controllers
{
    public class BaseController : System.Mvc.Controller
    {
        public virtual object Index() => View();
    }
}
