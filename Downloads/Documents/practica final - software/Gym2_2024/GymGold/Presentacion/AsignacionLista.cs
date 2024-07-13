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
    public partial class AsignacionLista : UserControl
    {
        private int id;
        public AsignacionLista()
        {
            InitializeComponent();
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return lbnom.Text; }
            set { lbnom.Text = value; }
        }
        public string Area
        {
            get { return lbare.Text; }
            set { lbare.Text = value; }
        }

        public string Tipo
        {
            get { return lbtip.Text; }
            set { lbtip.Text = value; }
        }
        public string Estado
        {
            get { return lbest.Text; }
            set { lbest.Text = value; }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            AsignacionD obj = new AsignacionD();
            obj.EliminarAsignacionMembresiass(Id);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            AsignacionD obj = new AsignacionD();
            obj.EditarAsignacionMembresias(Id);
        }
    }
}
