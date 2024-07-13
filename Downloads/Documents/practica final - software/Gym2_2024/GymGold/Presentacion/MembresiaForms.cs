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
    public partial class MembresiaForms : Form
    {
        private void llenarComboAreaCrear()
        {
            MembresiasD obj = new MembresiasD();
            cbarenu.DataSource = obj.ListaAreas();
            cbarenu.DisplayMember = "name_are";
            cbarenu.ValueMember = "id_are";
        }
        private void llenarComboTipoCrear()
        {
            MembresiasD obj = new MembresiasD();
            cbtiponu.DataSource = obj.ListaTipo();
            cbtiponu.DisplayMember = "name_time";
            cbtiponu.ValueMember = "id_time";

        }

        private void llenarComboAreaEditar()
        {
            MembresiasD obj = new MembresiasD();
            cbareed.DataSource = obj.ListaAreas();
            cbareed.DisplayMember = "name_are";
            cbareed.ValueMember = "id_are";

            cbareed.SelectedValue = SoporteMenbresias.id_are;
        }
        private void llenarComboTipoEditar()
        {
            MembresiasD obj = new MembresiasD();
            cbtiped.DataSource = obj.ListaTipo();
            cbtiped.DisplayMember = "name_time";
            cbtiped.ValueMember = "id_time";

            cbtiped.SelectedValue = SoporteMenbresias.id_tip;
        }

        private void ListarMembresias()
        {
            MembresiasD obj = new MembresiasD();
            flpMembresia.Controls.Clear();
            DataTable ListaP = obj.ListaMembresias();

            foreach (DataRow row in ListaP.Rows)
            {
                ListaMembresias btn = new ListaMembresias();


                btn.Id = int.Parse(row["id_men"].ToString());
                btn.Nombre = row["name_are"].ToString();
                btn.Tipo = row["name_time"].ToString();

                flpMembresia.Controls.Add(btn);
                btn.BtnEliminar.Click += new EventHandler(this.UserControlDeleteMembresia_Click);
                btn.BtnEditar.Click += new EventHandler(this.UserControlEditMembresia_Click);

            }

        }
        private void UserControlDeleteMembresia_Click(Object e, EventArgs ver)
        {
            ListarMembresias();
        }
        private void UserControlEditMembresia_Click(Object e, EventArgs ver)
        {
            llenarComboAreaEditar();
            llenarComboTipoEditar();
            ndpreed.Value = SoporteMenbresias.pre;
            tabMembresia.SelectedIndex = 2;
        }
        public MembresiaForms()
        {
            InitializeComponent();
        }

        private void MembresiaForms_Load(object sender, EventArgs e)
        {
           
            ListarMembresias();
            tabMembresia.TabMenuVisible = false;
        }

        private void BtnNuevaMembresia_Click(object sender, EventArgs e)
        {
            llenarComboTipoCrear();
            llenarComboAreaCrear();
            tabMembresia.SelectedIndex = 1;
        }

        private void BtnCancelarNuevoMembresia_Click(object sender, EventArgs e)
        {
            tabMembresia.SelectedIndex = 0;
        }

        private void BtnCancelarEditMembresia_Click(object sender, EventArgs e)
        {
            tabMembresia.SelectedIndex = 0;
        }

        private void BtnActualizarMembresia_Click(object sender, EventArgs e)
        {
            MembresiasD obj = new MembresiasD();
            obj.ActualizarMembresias(SoporteMenbresias.id_men,int.Parse(cbtiped.SelectedValue.ToString()), int.Parse(cbareed.SelectedValue.ToString()), ndpreed.Value);


            ListarMembresias();
            tabMembresia.SelectedIndex = 0;
        }

        private void BtnGuardarNuevoMembresia_Click(object sender, EventArgs e)
        {
            MembresiasD obj = new MembresiasD();
            obj.CrearMembresias(int.Parse(cbtiponu.SelectedValue.ToString()), int.Parse(cbarenu.SelectedValue.ToString()), ndprenu.Value);


            ListarMembresias();
            tabMembresia.SelectedIndex = 0;
        }

        private void cbtiped_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
