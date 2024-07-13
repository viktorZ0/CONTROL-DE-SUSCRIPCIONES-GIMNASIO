using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class LoginD
    {
        LoginM obj = new LoginM();
        public bool Login(string use, string pass)
        {
            return obj.Login(use, pass);
        }
    }
}
