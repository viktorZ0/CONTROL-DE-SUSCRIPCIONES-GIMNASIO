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
    public class PersonasM:ConexionSQL
    {
        public DataTable ObtienePersonas()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Personas";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        public void CrearPersonas(string ci, string name, int eda)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Personas values(@ci,@nam,@eda)";
                    comando.Parameters.AddWithValue("@ci", ci);
                    comando.Parameters.AddWithValue("@nam", name);
                    comando.Parameters.AddWithValue("@eda", eda);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Exitoso");

        }/****/

        public void EliminarPersonas(int id)
        {
            try
            {
                using (var conexion = GetConnection())
                {
                    conexion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "delete from Personas where id_per = @id";
                        comando.Parameters.AddWithValue("@id", id);
                        comando.CommandType = CommandType.Text;
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Registro Eliminado");
            }catch(Exception e)
            {
                //MessageBox.Show("")
            }
            
        }//fin 
        public void EditarPersonas(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Personas where id_per = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoportePersonas.id_per = reader.GetInt32(0);
                            SoportePersonas.ci_per = reader.GetString(1);
                            SoportePersonas.name_per = reader.GetString(2);
                            SoportePersonas.edad_per = reader.GetInt32(3);
                        }
                    }
                }
            }
        }//fin

        public void ActualizarPersonas(int Id, string ci, string name, int eda)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "UPDATE Personas SET ci_per = @ci, name_per = @nam, edad_per = @eda WHERE id_per = @id";
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@ci", ci);
                    comando.Parameters.AddWithValue("@nam", name);
                    comando.Parameters.AddWithValue("@eda", eda);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Actualizado");

        }/****/


        public void ObtieneUltimaPersona()
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT TOP 1 * FROM Personas ORDER BY id_per DESC";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoportePersonas.id_per = reader.GetInt32(0);
                        }

                    }
                    else
                        MessageBox.Show("Error al obtener datos del ultimo registro");
                }
            }
        }//fin 
    }
}
