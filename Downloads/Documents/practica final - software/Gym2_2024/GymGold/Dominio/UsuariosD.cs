using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class UsuariosD
    {
        UsuariosM obj = new UsuariosM();
        public DataTable ListaUsers()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneUser();
            return tabla;
        }
        public void CrearUsers(string Nombre, string Cont, int rol, int persona)
        {
            obj.CrearUsers(Nombre, Cont, rol, persona);
        }
        public void EliminarUsers(int id)
        {
            obj.EliminarUsers(id);
        }
       /* public void EditarUsers(int id)
        {
            obj.EditarUsers(id);
        }*/
        public void ActualizarUsers(int Id, string Nombre, string Cont, int rol, int persona)
        {
            obj.ActualizarUsers(Id, Nombre, Cont, rol, persona);
        }
    }
}
