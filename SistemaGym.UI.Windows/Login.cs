using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGym.BLL;


namespace SistemaGym.UI.Windows
{
    public partial class Login : Form
    {
        UsuarioBLL UsuarioBLL = new UsuarioBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (UsuarioBLL.ConultaLogin(txtUsuario.Text, txtContrasena.Text) == 1)
            {
                MessageBox.Show("Sesion Iniciada Con Exito");

                Form1 formularioprincipal = new Form1();

                formularioprincipal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
