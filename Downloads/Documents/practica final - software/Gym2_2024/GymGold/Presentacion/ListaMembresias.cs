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
    public partial class ListaMembresias : UserControl
    {

        private int id;
        public ListaMembresias()
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
        public string Tipo
        {
            get { return lbtip.Text; }
            set { lbtip.Text = value; }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            MembresiasD obj = new MembresiasD();
            obj.EditarMembresias(Id);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MembresiasD obj = new MembresiasD();
            obj.EliminarMembresias(Id);
        }
    }
}
