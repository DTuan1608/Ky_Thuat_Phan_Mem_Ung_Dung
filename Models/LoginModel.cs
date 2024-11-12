using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPMUD.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // Hàm xác minh tài khoản
        public bool ValidateLogin(string username, string password)
        {
            // Thêm logic kiểm tra với cơ sở dữ liệu tại đây nếu cần
            return username == "admin" && password == "123456";
        }
    }
}
