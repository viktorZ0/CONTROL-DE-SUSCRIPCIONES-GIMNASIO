using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class MembresiasD
    {
        MembresiasM obj = new MembresiasM();
        public DataTable ListaMembresias()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneMembresias();
            return tabla;
        }
        public void CrearMembresias(int nit, int idper, decimal pre)
        {
            obj.CrearMembresias(nit, idper,pre);
        }
        public void EliminarMembresias(int id)
        {
            obj.EliminarMembresias(id);
        }
        public void EditarMembresias(int id)
        {
            obj.EditarMenbresias(id);
        }
        public void ActualizarMembresias(int Id, int nit, int idper,decimal pre)
        {
            obj.ActualizarMenbresias(Id, nit, idper,pre);
        }

        public DataTable ListaAreas()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneAreas();
            return tabla;
        }
        public DataTable ListaTipo()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneTipo();
            return tabla;
        }
        public DataTable ConcatenaMembresias()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ConcatenaMembresias();
            return tabla;
        }

    }
}
