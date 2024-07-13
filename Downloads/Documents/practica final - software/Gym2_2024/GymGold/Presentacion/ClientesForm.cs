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
    public partial class ClientesForm : Form
    {
        private void ListarClientes()
        {
            ClientesD obj = new ClientesD();
            flpcliente.Controls.Clear();
            DataTable ListaP = obj.ListaClientes();

            foreach (DataRow row in ListaP.Rows)
            {
                ListaClientes btn = new ListaClientes();


                btn.Id_persona = int.Parse(row["id_per"].ToString());
                btn.Id_cliente = int.Parse(row["id_cli"].ToString());
                btn.Nombre = row["name_per"].ToString();
                btn.Ci = row["ci_per"].ToString();


                flpcliente.Controls.Add(btn);
                btn.BtnEliminar.Click += new EventHandler(this.UserControlDeleteClientes_Click);
                btn.BtnEditar.Click += new EventHandler(this.UserControlEditClientes_Click);

            }

        }
        private void UserControlDeleteClientes_Click(Object e, EventArgs ver)
        {
            ListarClientes();
        }
        private void UserControlEditClientes_Click(Object e, EventArgs ver)
        {
            txtnoed.Text = SoportePersonas.name_per;
            txtcied.Text = SoportePersonas.ci_per;
            txteded.Text = SoportePersonas.edad_per.ToString();
            txtnied.Text = SoporteCliente.nit_cli.ToString();

            tabcliente.SelectedIndex = 2;
        }
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            tabcliente.SelectedIndex = 1;
        }

        private void BtnGuardarNuevocliente_Click(object sender, EventArgs e)
        {
            ClientesD obj = new ClientesD();
            PersonasD Persona = new PersonasD();

            Persona.CrearPersonas(txtcinu.Text, txtnonu.Text, int.Parse(txtednu.Text));

            Persona.UltimaPersona();

            obj.CrearClientes(int.Parse(txtninu.Text), SoportePersonas.id_per);

            txtednu.Clear();
            txtnonu.Clear();
            txtcinu.Clear();
            txtninu.Clear();

            ListarClientes();
            tabcliente.SelectedIndex = 0;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
            tabcliente.TabMenuVisible = false;
        }

        private void BtnActualizarcliente_Click(object sender, EventArgs e)
        {
            ClientesD Cliente = new ClientesD();
            PersonasD Persona = new PersonasD();

            Cliente.ActualizarClientes(SoporteCliente.id_cli, int.Parse(txtnied.Text), SoportePersonas.id_per);
            Persona.ActualizarPersonas(SoportePersonas.id_per, txtcied.Text, txtnoed.Text, int.Parse(txteded.Text));
            ListarClientes();
            tabcliente.SelectedIndex = 0;
        }

        private void BtnCancelarNuevocliente_Click(object sender, EventArgs e)
        {

        }

        private void txtcinu_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpcliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
