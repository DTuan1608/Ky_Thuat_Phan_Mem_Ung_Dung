using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Controllers
{
    internal class CoSoKhaoNghiemSPXLCTController : BaseController
    {
        public virtual object Index() => View(Provider.Select("SP_XL_chat_thai"));
    }
}
