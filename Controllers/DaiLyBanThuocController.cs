﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace KTPMUD.Controllers
{
    internal class DaiLyBanThuocController:BaseController
    {
        public virtual object DaiLyBanThuocLayout() => View(new dlbtmodel());
    }
}
