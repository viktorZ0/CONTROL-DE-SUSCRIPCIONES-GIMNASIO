using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Dominio
{
    public class ClientesD
    {
        ClientesM obj = new ClientesM();
        public DataTable ListaClientes()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneClientes();
            return tabla;
        }
        public void CrearClientes(int nit,int idper)
        {
            obj.CrearClientes(nit,idper);
        }
        public void EliminarClientes(int id)
        {
            obj.EliminarClientes(id);
        }
        public void EditarClientes(int id)
        {
            obj.EditarClientes(id);
        }
        public void ActualizarClientes(int Id, int nit, int idper)
        {
            obj.ActualizarClientes(Id, nit, idper);
        }


    }
}
