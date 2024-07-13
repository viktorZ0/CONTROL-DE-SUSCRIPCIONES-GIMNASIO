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
    public class MembresiasM:ConexionSQL
    {
        public DataTable ObtieneMembresias()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Menbresias a " +
                        "inner join Areas b on a.are_id_men like b.id_are " +
                        "inner join TipoMenbresia c on a.time_id_men like c.id_time";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        public void CrearMembresias(int idtip, int idare,decimal pre)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Menbresias values(@ti,@ar,@pr)";
                    comando.Parameters.AddWithValue("@ti", idtip);
                    comando.Parameters.AddWithValue("@ar", idare);
                    comando.Parameters.AddWithValue("@pr", pre);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Exitoso");

        }/****/

        public void EliminarMembresias(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "delete from Menbresias where id_men = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registro Eliminado");
        }//fin 
        public void EditarMenbresias(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Menbresias where id_men = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoporteMenbresias.id_men = reader.GetInt32(0);
                            SoporteMenbresias.id_tip = reader.GetInt32(1);
                            SoporteMenbresias.id_are = reader.GetInt32(2);
                            SoporteMenbresias.pre = reader.GetDecimal(3);

                        }
                    }
                }
            }
        }//fin

        public void ActualizarMenbresias(int Id, int idtip, int idare, decimal pre)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "UPDATE Menbresias SET time_id_men = @ti, are_id_men = @ar, precio_men = @pr WHERE id_men = @id";
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@ti", idtip);
                    comando.Parameters.AddWithValue("@ar", idare);
                    comando.Parameters.AddWithValue("@pr", pre);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Actualizado");

        }/****/

        public DataTable ObtieneAreas()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from areas";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }
        public DataTable ObtieneTipo()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from TipoMenbresia";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        public DataTable ConcatenaMembresias()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select a.id_men,Concat (b.name_are,' ', c.name_time) AS name_menbresia from Menbresias a " +
                        "inner join Areas b on a.are_id_men like b.id_are " +
                        "inner join TipoMenbresia c on a.time_id_men like c.id_time ";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }
    }
}
