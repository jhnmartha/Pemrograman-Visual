using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P7.Models;

namespace P7.Controllers
{
    internal class LoginController
    {
        public static bool Login(string username, string password)
        {
            return LoginModel.CekLogin(username, password);
        }
    }
}
