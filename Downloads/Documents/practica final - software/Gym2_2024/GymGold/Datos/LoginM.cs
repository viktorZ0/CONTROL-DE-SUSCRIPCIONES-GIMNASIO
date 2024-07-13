using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soporte;

namespace Datos
{
    public class LoginM : ConexionSQL//herencia
    {

        public bool Login(string usuario, string contraseña)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Personas a " +
                        "inner join Usuarios b on a.id_per like b.per_id_use " +
                        "where b.name_use = @name and b.pass_use = @pass";
                    comando.Parameters.AddWithValue("@name", usuario);
                    comando.Parameters.AddWithValue("@pass", contraseña);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoporteLogin.Name_per = reader.GetString(2);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }//fin login
    }
}
