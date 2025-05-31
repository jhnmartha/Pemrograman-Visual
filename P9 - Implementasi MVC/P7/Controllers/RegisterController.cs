using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P7.Models;

namespace P7.Controllers
{
    internal class RegisterController
    {
        private readonly RegisterModel model;

        public RegisterController()
        {
            model = new RegisterModel();
        }

        public bool DaftarAkun(string username, string password, out string message)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                message = "Username dan password tidak boleh kosong.";
                return false;
            }

            try
            {
                bool success = model.RegisterUser(username, password);
                message = success ? "Registrasi berhasil!" : "Registrasi gagal.";
                return success;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
