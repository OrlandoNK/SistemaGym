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
            CustomDesignForm();
        }

        public void CustomDesignForm()
        {
            subPanelAdministracion.Visible = false;
            subPanelMantenimientos.Visible = false;
            subPanelFacturacion.Visible = false;
        }

        private void HideSubMenu()
        {
            if (subPanelAdministracion.Visible == true)
                subPanelAdministracion.Visible = false;
            if (subPanelMantenimientos.Visible == true)
                subPanelMantenimientos.Visible = false;
            if (subPanelFacturacion.Visible == true)
                subPanelFacturacion.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            lblRolUsuario.Text = "[" + gestioUsuarioEntities.rolUsuarioLogged + "]";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mantenimientoUsuarios mantenimientoUsuarios = new mantenimientoUsuarios();
            mantenimientoUsuarios.Show();
            HideSubMenu();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRol rolesForm = new frmRol();
            rolesForm.Show();
            HideSubMenu();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanelAdministracion);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mantenimientoEmpleados mantenimientoEmpleados = new mantenimientoEmpleados();
            mantenimientoEmpleados.Show();

            HideSubMenu();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanelMantenimientos);
        }

        private void btnMembresiasMantenimiento_Click(object sender, EventArgs e)
        {
            frmMembresia mantenimientoMembresias = new frmMembresia();
            mantenimientoMembresias.Show();

            HideSubMenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MantenimientoProveedores mantenimientoProveedores = new MantenimientoProveedores();
            mantenimientoProveedores.Show();

            HideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes mantenimientoClientes = new frmClientes();
            mantenimientoClientes.Show();

            HideSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {

            mantenimientoCategorias categorias = new mantenimientoCategorias();
            categorias.Show();
            HideSubMenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mantenimientoProductos = new MantenimientoProductos();
            mantenimientoProductos.Show();

            HideSubMenu();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanelFacturacion);
        }

        private void btnFacturaMembresia_Click(object sender, EventArgs e)
        {
            mantenimientoFacturacionMembresia facturacionMembresia = new mantenimientoFacturacionMembresia();
            facturacionMembresia.Show();

            HideSubMenu();
        }

        private void btnFacturaProducto_Click(object sender, EventArgs e)
        {
            frmFacturaProductos mantenimientoFacturaProductos = new frmFacturaProductos();
            mantenimientoFacturaProductos.Show();

            HideSubMenu();
        }
    }
}
