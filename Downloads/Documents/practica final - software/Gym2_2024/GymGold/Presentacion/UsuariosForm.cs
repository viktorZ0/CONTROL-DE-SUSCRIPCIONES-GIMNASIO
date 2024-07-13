using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Soporte;

namespace Presentacion
{
    public partial class UsuariosForm : Form
    {
     
        private void ListarUsers()
        {
            UsuariosD obj = new UsuariosD();
            flpuser.Controls.Clear();
            DataTable ListaP = obj.ListaUsers();

            foreach (DataRow row in ListaP.Rows)
            {
                ListaUsuarios btn = new ListaUsuarios();


                btn.Id_persona = int.Parse(row["id_per"].ToString());
                btn.Id_user = int.Parse(row["id_use"].ToString());
                btn.Id_rol = int.Parse(row["id_rol"].ToString());
                btn.Nombre = row["name_per"].ToString();
                btn.User = row["name_use"].ToString();
                btn.Rol = row["name_rol"].ToString();


                flpuser.Controls.Add(btn);
                btn.BtnEliminar.Click += new EventHandler(this.UserControlDeleteUsuario_Click);
                btn.BtnEditar.Click += new EventHandler(this.UserControlEditUsuario_Click);

            }

        }
        private void UserControlDeleteUsuario_Click(Object e, EventArgs ver)
        {
            ListarUsers();
        }
        private void UserControlEditUsuario_Click(Object e, EventArgs ver)
        {
            /*PermisoSoporte.PermisosAsignados.Clear();
            MarcaPermisosAsignados();
            txtNoRoEd.Text = RolSoporte.Nombre;
            txtDeRoEd.Text = RolSoporte.Descripcion;*/



            tabuser.SelectedIndex = 2;
        }

        public UsuariosForm()
        {
            InitializeComponent();
        }

     
        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            ListarUsers();
           // ListarRoles();
            //ListarPermisos();
            tabuser.TabMenuVisible = false;
            tabrol.TabMenuVisible = false;
            tabper.TabMenuVisible = false;
        }

        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            
            tabuser.SelectedIndex = 1;
        }

        private void BtnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            UsuariosD obj = new UsuariosD();
            PersonasD Persona = new PersonasD();

            Persona.CrearPersonas(txtcinu.Text, txtnonu.Text, int.Parse(txtednu.Text));

            Persona.UltimaPersona();

            obj.CrearUsers(txtnonu.Text, txtpanu.Text, int.Parse(cbrolnu.SelectedValue.ToString()), SoportePersonas.id_per);

            txtednu.Clear();
            txtnonu.Clear();
            txtpanu.Clear();
            txtusnu.Clear();
            txtcinu.Clear();

            ListarUsers();
            tabuser.SelectedIndex = 0;

        }
        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancelarNuevoUser_Click(object sender, EventArgs e)
        {
            tabuser.SelectedIndex = 0;
        }

        private void BtnCancelarEdituser_Click(object sender, EventArgs e)
        {
            tabuser.SelectedIndex = 0;
        }
    }
}
