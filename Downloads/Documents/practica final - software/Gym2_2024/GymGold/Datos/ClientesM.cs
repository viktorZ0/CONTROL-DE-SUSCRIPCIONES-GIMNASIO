using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte;
namespace Datos
{
    public class ClientesM:ConexionSQL
    {
        // Método para obtener todos los clientes
        public DataTable ObtieneClientes()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Personas a inner join Cliente b on a.id_per like b.per_id_cli";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        // Método para crear un nuevo cliente
        public void CrearClientes(int Nit,int idper)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Cliente values(@nit,@idp)";
                    comando.Parameters.AddWithValue("@nit", Nit);
                    comando.Parameters.AddWithValue("@idp", idper);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Exitoso");

        }/****/

        // Método para eliminar un cliente
        public void EliminarClientes(int id)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    conexion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "delete from Cliente where id_cli = @id";
                        comando.Parameters.AddWithValue("@id", id);
                        comando.CommandType = CommandType.Text;
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registro Eliminado");
            }catch(Exception e)
            {
                MessageBox.Show("El cliente tiene membresias, no se puede eliminar");
            }
           
        }//fin 

        // Método para editar un cliente
        public void EditarClientes(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Cliente where id_cli = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoporteCliente.id_cli = reader.GetInt32(0);
                            SoporteCliente.nit_cli = reader.GetInt32(1);


                        }
                    }
                }
            }
        }//fin

        // Método para actualizar un cliente
        public void ActualizarClientes(int Id, int Nit, int idper)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "UPDATE Cliente SET nit_cli = @nit, per_id_cli = @idp WHERE id_cli = @id";
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nit", Nit);
                    comando.Parameters.AddWithValue("@idp", idper);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Actualizado");

        }/****/
    }
}
