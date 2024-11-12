using KTPMUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Controllers
{
    public class LoginController : BaseController
    {
        private readonly LoginModel _userModel;

        public LoginController()
        {
            _userModel = new LoginModel();
        }

        public bool Login(string username, string password)
        {
            return _userModel.ValidateLogin(username, password);
        }
    }
}
