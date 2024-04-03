using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class LoginForm : Form
    {
        private string SISTEMA = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
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

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            gestioUsuarioEntities.IDUserLogged = usuarioBLL.GetIDFromUser(nombreUsuario, contrasena);
            gestioUsuarioEntities.usernameLogged = usuarioBLL.GetNameFromUser(nombreUsuario, contrasena);
            gestioUsuarioEntities.rolUsuarioLogged = RolBLL.ObtenerRolUsuario(nombreUsuario, contrasena);

            try
            {
                if (resultadoAutenticacion > 0)
                {
                    MessageBox.Show("¡Sesión Iniciada Con Éxito!\n\nBienvenido al Sistema " + gestioUsuarioEntities.usernameLogged, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    principalForm formularioprincipal = new principalForm();


                    formularioprincipal.Show();


                    this.Hide();
                }
                else if (string.IsNullOrEmpty(TxbUsuario.Text) && string.IsNullOrEmpty(TxbContraseña.Text))
                { 
                    MessageBox.Show("Por favor llene los campos", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos, Intente Nuevamente", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Iniciar Sesion:\n" + ex.Message, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Iniciar Sesion:\n" + ex.Message, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
