using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class PersonasD
    {
        PersonasM obj = new PersonasM();
        public DataTable ListaPersonas()
        {
            DataTable tabla = new DataTable();
            tabla = obj.ObtienePersonas();
            return tabla;
        }
        public void CrearPersonas(string ci, string name, int eda)
        {
            obj.CrearPersonas(ci, name, eda);
        }
        public void EliminarPersonas(int id)
        {
            obj.EliminarPersonas(id);
        }
         public void EditarPersonas(int id)
         {
             obj.EditarPersonas(id);
         }
        public void ActualizarPersonas(int Id, string ci, string name, int eda)
        {
            obj.ActualizarPersonas(Id, ci, name, eda);
        }


        public void UltimaPersona()
        {
            obj.ObtieneUltimaPersona();

        }
    }
}
