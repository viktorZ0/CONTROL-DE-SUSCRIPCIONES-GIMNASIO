using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class AsignacionD
    {
        AsignacionMembresiasM obj = new AsignacionMembresiasM();
        public DataTable ListaMembresiasAsignadas()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtieneAsignacionMembresias();
            return tabla;
        }
        public void CrearAsignacionMembresias(int idmen, DateTime inicio, DateTime fin, int idcli, int est)
        {
            obj.CrearAsignacionMembresias(idmen, inicio, fin,idcli,est);
        }
        public void EditarAsignacionMembresias(int id)
        {
            obj.EditarAsignacionMembresias(id);
        }
        public void EliminarAsignacionMembresiass(int id)
        {
            obj.EliminarAsignacionMembresiass(id);
        }
        public void ActualizarAsignacionMembresias(int idreg, int idmen, DateTime inicio, DateTime fin, int idcli, int est)
        {
            obj.ActualizarAsignacionMembresias(idreg, idmen, inicio, fin, idcli, est);
        }
    }
}
