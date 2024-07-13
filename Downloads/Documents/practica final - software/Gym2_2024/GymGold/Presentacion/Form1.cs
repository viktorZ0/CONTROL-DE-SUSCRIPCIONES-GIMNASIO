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

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicLogo.Image = Image.FromFile("gif.gif");
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            txtuser.Focus();
            this.Show();
        }

        private void BtnIniciaSesion_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "")
            {
                if (txtpass.Text != "")
                {
                    LoginD user = new LoginD();
                    var valido = user.Login(txtuser.Text, txtpass.Text);
                    if (valido == true)
                    {
                        Principal obj = new Principal();
                        MessageBox.Show("Bienvenido "  /*+ InicioSesion.Nombre*/);
                        obj.Show();
                        obj.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecta.");
                        txtpass.Clear();
                        txtuser.Clear();
                        txtuser.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor Ingrese su Contraseña");
                }
            }
            else
            {
                MessageBox.Show("Por favor Ingrese su Usuario");
            }
        }
    }
}
