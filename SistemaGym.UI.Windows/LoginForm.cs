using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class LoginForm : Form
    {

        UsuarioBLL UsuarioBLL = new UsuarioBLL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TxbUsuario.Text;
            string contrasena = TxbContraseña.Text;

            UsuarioEntity usuario = new UsuarioEntity(nombreUsuario, contrasena);
            int resultadoAutenticacion = UsuarioBLL.ConsultaLogin(usuario);

            if (resultadoAutenticacion > 0)
            {
                MessageBox.Show("Sesión Iniciada Con Éxito");

                
                principalForm formularioprincipal = new principalForm();

                Form1 formularioprincipal = new Form1();
                formularioprincipal.Show();


                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
