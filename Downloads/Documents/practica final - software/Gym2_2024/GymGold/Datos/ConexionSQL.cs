using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class ConexionSQL
    {
        private readonly string conexionSrting;

        public ConexionSQL()
        {
            conexionSrting = @"Server=VIKTORZ\SQLEXPRESS; DataBase = GymGold; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionSrting);
        }
    }
}
