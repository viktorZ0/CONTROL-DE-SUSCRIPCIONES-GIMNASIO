using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace Datos
{
    public class UsuariosM:ConexionSQL
    {
       
        public DataTable ObtieneUser()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Personas a " +
                        "inner join Usuarios b on a.id_per like b.per_id_use " +
                        "inner join Roles c on b.rol_id_use like c.id_rol";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        public void CrearUsers(string Nombre, string Cont, int rol, int persona)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Usuarios values(@nom,@con,@per,@rol)";
                    comando.Parameters.AddWithValue("@nom", Nombre);
                    comando.Parameters.AddWithValue("@con", Cont);
                    comando.Parameters.AddWithValue("@rol", rol);
                    comando.Parameters.AddWithValue("@per", persona);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Exitoso");

        }/****/

        public void EliminarUsers(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "delete from Usuarios where Id = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registro Eliminado");
        }//fin 
       /* public void EditarUsers(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuarios where Id = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserSoporte.Id_user = reader.GetInt32(0);
                            UserSoporte.Nombre = reader.GetString(1);
                            UserSoporte.Contraseña = reader.GetString(2);
                            UserSoporte.Id_persona = reader.GetInt32(4);
                            UserSoporte.Id_rol = reader.GetInt32(3);
                        }
                    }
                }
            }
        }//fin*/
        public void ActualizarUsers(int Id, string Nombre, string Cont, int rol, int persona)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "UPDATE Usuarios SET Name_User = @nom, Contraseña = @con, Rol_id=@rol,Persona_id=@per WHERE Id = @id";
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nom", Nombre);
                    comando.Parameters.AddWithValue("@con", Cont);
                    comando.Parameters.AddWithValue("@rol", rol);
                    comando.Parameters.AddWithValue("@per", persona);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Actualizado");

        }/****/
    }
}
