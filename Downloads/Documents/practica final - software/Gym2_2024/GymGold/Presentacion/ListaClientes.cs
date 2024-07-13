using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class ListaClientes : UserControl
    {
        private int id_persona;
        private int id_cliente;
        public ListaClientes()
        {
            InitializeComponent();
        }
        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
     
        public string Nombre
        {
            get { return lbnom.Text; }
            set { lbnom.Text = value; }
        }
        public string Ci
        {
            get { return lbci.Text; }
            set { lbci.Text = value; }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            PersonasD objp = new PersonasD();
            ClientesD objc = new ClientesD();

            objp.EditarPersonas(Id_persona);

            objc.EditarClientes(Id_cliente);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            PersonasD objp = new PersonasD();
            ClientesD objc = new ClientesD();

            objc.EliminarClientes(Id_cliente);
            objp.EliminarPersonas(Id_persona);
        }
    }
}
