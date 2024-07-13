using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ListaUsuarios : UserControl
    {
        private int id_persona;
        private int id_user;
        private int id_rol;

        public ListaUsuarios()
        {
            InitializeComponent();
        }
        public int Id_persona
        {
            get { return id_persona; }
            set { id_persona = value; }
        }
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public int Id_rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
        public string Nombre
        {
            get { return lbnom.Text; }
            set { lbnom.Text = value; }
        }

        public string User
        {
            get { return lbuse.Text; }
            set { lbuse.Text = value; }
        }
        public string Rol
        {
            get { return lbrol.Text; }
            set { lbrol.Text = value; }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
