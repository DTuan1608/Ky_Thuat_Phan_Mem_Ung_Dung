using System;
using System.Collections.Generic;
using System.Linq;
using System.Mvc;
using System.Text;
using System.Threading.Tasks;
using KTPMUD.Models;
using KTPMUD.Views.CoSoChanNuoi;
using Models;
using Record = Models.Record;

namespace KTPMUD.Controllers
{
    internal class CoSoChanNuoiController : BaseController
    {
        
        public virtual object CoSoChanNuoiLayout() => View();

        
        public virtual object Edit() => View();
        public virtual object Delete() => View();
        public virtual object Insert() => View();
    }
}
