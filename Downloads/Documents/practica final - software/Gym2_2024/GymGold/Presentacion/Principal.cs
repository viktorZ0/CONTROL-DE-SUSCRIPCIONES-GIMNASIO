using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte;

namespace Presentacion
{
    public partial class Principal : Form
    {
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormularios(object FormAbrir)
        {
            if (this.FormulariosPn.Controls.Count > 0)
                this.FormulariosPn.Controls.RemoveAt(0);

            Form formulario = FormAbrir as Form;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;//acopla al panel y quita los bordes
            formulario.Dock = DockStyle.Fill;//para acoplar al panel
            FormulariosPn.Controls.Add(formulario);
            FormulariosPn.Tag = formulario;
            formulario.Show();
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new UsuariosForm());
            BtnClientes.FillColor = Color.FromArgb(176, 136, 22);
            BtnMembresias.FillColor = Color.FromArgb(176, 136, 22);
            BtnRegistros.FillColor = Color.FromArgb(176, 136, 22);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new ClientesForm());
            BtnClientes.FillColor = Color.FromArgb(6, 4, 3);
            BtnMembresias.FillColor = Color.FromArgb(176, 136, 22);
            BtnRegistros.FillColor = Color.FromArgb(176, 136, 22);
        }

        private void BtnMembresias_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new MembresiaForms());
            BtnClientes.FillColor = Color.FromArgb(176, 136, 22);
            BtnMembresias.FillColor = Color.FromArgb(6, 4, 3);
            BtnRegistros.FillColor = Color.FromArgb(176, 136, 22);
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new AsignacionMembresias());
            BtnClientes.FillColor = Color.FromArgb(176, 136, 22);
            BtnMembresias.FillColor = Color.FromArgb(176, 136, 22);
            BtnRegistros.FillColor = Color.FromArgb(6, 4, 3);

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lbNamePer.Text = SoporteLogin.Name_per;
        }
    }
}
