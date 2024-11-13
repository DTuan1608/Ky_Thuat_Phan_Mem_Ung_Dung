using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Controllers
{
    public class HomeController : BaseController
    {
        public virtual object IndexLayout() => View();

    }
}
