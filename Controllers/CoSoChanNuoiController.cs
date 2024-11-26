using System;
using System.Collections.Generic;
using System.Linq;
using System.Mvc;
using System.Text;
using System.Threading.Tasks;
using KTPMUD.Views.CoSoChanNuoi;
using Models;

namespace KTPMUD.Controllers
{
    internal class CoSoChanNuoiController : BaseController
    {
        

        public object Add() => View();
        public object Edit(Models.CoSoChanNuoi value) => View(value);
    }
}
