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
    public partial class AsignacionMembresias : Form
    {
        private void llenarComboClienteCrear()
        {
            ClientesD obj = new ClientesD();
            cbclinu.DataSource = obj.ListaClientes();
            cbclinu.DisplayMember = "name_per";
            cbclinu.ValueMember = "id_cli";
        }
        private void llenarComboMenbresiaCrear()
        {
            MembresiasD obj = new MembresiasD();
            cbmennu.DataSource = obj.ConcatenaMembresias();
            cbmennu.DisplayMember = "name_menbresia";
            cbmennu.ValueMember = "id_men";

        }

        private void llenarComboClienteEditar()
        {
            ClientesD obj = new ClientesD();
            cbclied.DataSource = obj.ListaClientes();
            cbclied.DisplayMember = "name_per";
            cbclied.ValueMember = "id_cli";

            cbclied.SelectedValue = SoporteAsignados.id_cli;
        }
        private void llenarComboMenbresiaEditar()
        {
            MembresiasD obj = new MembresiasD();
            cbmened.DataSource = obj.ConcatenaMembresias();
            cbmened.DisplayMember = "name_menbresia";
            cbmened.ValueMember = "id_men";

            cbmened.SelectedValue = SoporteAsignados.id_men;
        }

        private void ListarMembresiasAsignadas()
        {
            AsignacionD obj = new AsignacionD();
            flpMembresia.Controls.Clear();
            DataTable ListaP = obj.ListaMembresiasAsignadas();

            foreach (DataRow row in ListaP.Rows)
            {
                AsignacionLista btn = new AsignacionLista();


                btn.Id = int.Parse(row["id_reg"].ToString());
                btn.Nombre = row["name_per"].ToString();
                btn.Area = row["name_are"].ToString();
                btn.Tipo = row["name_time"].ToString();
                bool estadoReg = Convert.ToBoolean(row["estado_reg"]);

                // Convertir el valor booleano a int (1 para true, 0 para false)
                int aux = estadoReg ? 1 : 0;
                if  (aux == 0)
                {
                    btn.Estado = "Sin Cancelar";
                }
                else
                {
                    btn.Estado = "Pagado";
                }
               

                flpMembresia.Controls.Add(btn);
                btn.BtnEliminar.Click += new EventHandler(this.UserControlDeleteMembresiaA_Click);
                btn.BtnEditar.Click += new EventHandler(this.UserControlEditMembresiaA_Click);

            }

        }
        private void UserControlDeleteMembresiaA_Click(Object e, EventArgs ver)
        {
            ListarMembresiasAsignadas();
        }
        private void UserControlEditMembresiaA_Click(Object e, EventArgs ver)
        {
            llenarComboClienteEditar();
            llenarComboMenbresiaEditar();
            FechaInicioed.Value = SoporteAsignados.ini;
            FechaFined.Value = SoporteAsignados.fin;
            int aux = SoporteAsignados.estado ? 1 : 0;
            if (aux == 0)
            {
                checkpagoed.Checked = false;
            }
            else
            {
                checkpagoed.Checked = true;
            }
            tabMembresia.SelectedIndex = 2;
        }
        public AsignacionMembresias()
        {
            InitializeComponent();
        }

        private void BtnNuevaMembresia_Click(object sender, EventArgs e)
        {
            llenarComboClienteCrear();
            llenarComboMenbresiaCrear();
            tabMembresia.SelectedIndex = 1;
        }

        private void BtnGuardarNuevoMembresia_Click(object sender, EventArgs e)
        {
            AsignacionD obj = new AsignacionD();
            if (checkpagonu.Checked == true)
            {
                obj.CrearAsignacionMembresias(int.Parse(cbmennu.SelectedValue.ToString()), FechaInicionu.Value, FechaFinnu.Value, int.Parse(cbclinu.SelectedValue.ToString()), 1);

            }
            else
            {
                obj.CrearAsignacionMembresias(int.Parse(cbmennu.SelectedValue.ToString()), FechaInicionu.Value, FechaFinnu.Value, int.Parse(cbclinu.SelectedValue.ToString()), 0);

            }


            ListarMembresiasAsignadas();
            tabMembresia.SelectedIndex = 0;
        }

        private void BtnCancelarNuevoMembresia_Click(object sender, EventArgs e)
        {
            tabMembresia.SelectedIndex = 0;
        }

        private void AsignacionMembresias_Load(object sender, EventArgs e)
        {
            ListarMembresiasAsignadas();
            tabMembresia.TabMenuVisible = false;
        }

        private void BtnCancelarEditMembresia_Click(object sender, EventArgs e)
        {
            tabMembresia.SelectedIndex = 0;
        }

        private void BtnActualizarMembresia_Click(object sender, EventArgs e)
        {
            AsignacionD obj = new AsignacionD();
            if (checkpagoed.Checked == true)
            {
                obj.ActualizarAsignacionMembresias(SoporteAsignados.id_reg,int.Parse(cbmened.SelectedValue.ToString()), FechaInicioed.Value, FechaFined.Value, int.Parse(cbclied.SelectedValue.ToString()), 1);

            }
            else
            {
                obj.ActualizarAsignacionMembresias(SoporteAsignados.id_reg, int.Parse(cbmened.SelectedValue.ToString()), FechaInicioed.Value, FechaFined.Value, int.Parse(cbclied.SelectedValue.ToString()), 0);

            }

            ListarMembresiasAsignadas();
            tabMembresia.SelectedIndex = 0;
        }
    }
}
