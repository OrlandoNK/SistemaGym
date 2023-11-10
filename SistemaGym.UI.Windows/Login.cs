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
using SistemaGym.DAL;
using SistemaGym.Entities;

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
            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            UsuarioEntity usuario = new UsuarioEntity(nombreUsuario, contrasena);
            int resultadoAutenticacion = UsuarioBLL.ConsultaLogin(usuario);

            if (resultadoAutenticacion > 0)
            {
                MessageBox.Show("Sesión Iniciada Con Éxito");

                
                principalForm formularioprincipal = new principalForm();
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
