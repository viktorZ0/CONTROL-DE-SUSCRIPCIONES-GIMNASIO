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
    //Define la clase AsignacionMembresiasM, que hereda de ConexionSQL
    //sugiriendo que maneja la conexión a la base de datos.
    public class AsignacionMembresiasM : ConexionSQL
    {
        public DataTable ObtieneAsignacionMembresias()
        {
            //METODO PARA OBTENER TODAS LAS ASIGNACIONES DE MEMBRESÍAS
            SqlDataReader leer; 
            DataTable tabla = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "select * from Registros a " +
                        "inner join Menbresias b on a.men_id_reg like b.id_men " +
                        "inner join Areas c on b.are_id_men like c.id_are " +
                        "inner join TipoMenbresia d on b.time_id_men like d.id_time " +
                        "inner join Cliente e on a.cli_id_reg like e.id_cli " +
                        "inner join Personas f on e.per_id_cli like f.id_per ";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                    conexion.Close();
                    return tabla;
                }
            }

        }

        //METODO PARA CREAR UNA NUEVA ASIGNACIÓN DE MEMBRESÍA
        public void CrearAsignacionMembresias(int idmen, DateTime inicio, DateTime fin, int idcli, int est)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "insert into Registros values(@id,@in,@fi,@cl,@es)";
                    comando.Parameters.AddWithValue("@id", idmen);
                    comando.Parameters.AddWithValue("@in", inicio);
                    comando.Parameters.AddWithValue("@fi", fin);
                    comando.Parameters.AddWithValue("@cl", idcli);
                    comando.Parameters.AddWithValue("@es", est);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Exitoso");

        }/****/

        // MÉTODO PARA ALIMINAR UNA ASIGNACIÓN DE MEMBRESÍA
        public void EliminarAsignacionMembresiass(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "delete from Registros where id_reg = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registro Eliminado");
        }//fin 

        // MÉTODO PARA EDITAR UNA ASIGNACÍON DE MEMBRESÍA
        public void EditarAsignacionMembresias(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Registros where id_reg = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SoporteAsignados.id_reg = reader.GetInt32(0);
                            SoporteAsignados.id_men = reader.GetInt32(1);
                           
                            SoporteAsignados.ini = reader.GetDateTime(2);
                            SoporteAsignados.fin = reader.GetDateTime(3);
                            SoporteAsignados.id_cli = reader.GetInt32(4);
                            SoporteAsignados.estado = reader.GetBoolean(5);
                        }
                    }
                }
            }
        }//fin

        // MÉTODO PARA ACTUALIZAR UNA ASIGNACIÓN DE MEMBRESÍA
        public void ActualizarAsignacionMembresias(int idreg,int idmen, DateTime inicio, DateTime fin, int idcli, int est)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "UPDATE Registros SET men_id_reg=@idmen,inicio_reg=@in,vence_reg=@fi,cli_id_reg=@cl,estado_reg=@es WHERE id_reg = @id";
                    comando.Parameters.AddWithValue("@idmen", idmen);
                    comando.Parameters.AddWithValue("@in", inicio);
                    comando.Parameters.AddWithValue("@fi", fin);
                    comando.Parameters.AddWithValue("@cl", idcli);
                    comando.Parameters.AddWithValue("@es", est);
                    comando.Parameters.AddWithValue("@id", idreg);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Registro Actualizado");

        }/****/
    }
}
