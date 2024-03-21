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
    public partial class registrarRol : Form
    {
        const string sistema = "Sistema Gestión Gimnasio (COMFORT GYM) dice:";
        public registrarRol()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            string CampoObligatorio = "¡Este Campo es Obligatorio!";
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, CampoObligatorio);
                resultado = false;
                errorProvider.SetError(txtDescripcion, CampoObligatorio);
                resultado = false;
            }
            return resultado;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //pasar datos de controles a un objeto
            RolEntity Rol = new RolEntity();
            Rol.Nombre = txtNombre.Text;
            Rol.Descripcion = txtDescripcion.Text;

            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                RolBLL.Guardar(Rol);
                MessageBox.Show("¡El Rol ha sido Guardado de Manera Satisfactoria!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Rol.\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Rol.\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
