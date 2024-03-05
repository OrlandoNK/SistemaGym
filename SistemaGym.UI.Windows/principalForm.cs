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
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void chbxdesplegable_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxdesplegable.Checked)
            {
                panelDesplegable.Visible = true;
            }

            else
            {
                panelDesplegable.Visible = false;
            }
        }

        private void btncerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void principalForm_Load(object sender, EventArgs e)
        {
            lblusuario.Text = gestioUsuarioEntities.usernameLogged;
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            SubMantenimientos.Visible = true;

            if (subAdministracion.Visible = true)
            {
                subAdministracion.Visible = false;
            }
        }

        private void btnFacturaMembresia_Click(object sender, EventArgs e)
        {
            mantenimientoFacturacionMembresia facturacionMembresia = new mantenimientoFacturacionMembresia();
            facturacionMembresia.Show();
            SubMantenimientos.Visible = false;
        }

        private void btnFacturaProducto_Click(object sender, EventArgs e)
        {
            frmFacturaProductos mantenimientoFacturaProductos = new frmFacturaProductos();
            mantenimientoFacturaProductos.Show();
            SubMantenimientos.Visible = false;
        }

        private void btnManteProveedores_Click(object sender, EventArgs e)
        {
            MantenimientoProveedores mantenimientoProveedores = new MantenimientoProveedores();
            mantenimientoProveedores.Show();
            SubMantenimientos.Visible = false;
        }

        private void btnmembresia_Click(object sender, EventArgs e)
        {
            frmMembresia frmMembresia = new frmMembresia();
            frmMembresia.Show();
            SubMantenimientos.Visible = false;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {

            subAdministracion.Visible = true;

            if (SubMantenimientos.Visible = true)
            {
                SubMantenimientos.Visible = false;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientesForm = new frmClientes();
            clientesForm.Show();
            subAdministracion.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
            subAdministracion.Visible = false;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRol rolesForm = new frmRol();
            rolesForm.Show();
            subAdministracion.Visible = false;
        }

        private void btnMantenimientoProducto_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mantenimientoProductos = new MantenimientoProductos();
            mantenimientoProductos.Show();
            SubMantenimientos.Visible = false;
        }
    }
}
