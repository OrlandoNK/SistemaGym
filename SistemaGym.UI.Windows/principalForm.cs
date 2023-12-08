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

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            subFacturacion.Visible = true;
        }

        private void subbtnFacturacionProducto_Click(object sender, EventArgs e)
        {
            subFacturacion.Visible = false;
            frmFacturaProductos frmFacturaProductos = new frmFacturaProductos();
            frmFacturaProductos.Show();
        }

        private void subbtnFacturacionMembresia_Click(object sender, EventArgs e)
        {
            subFacturacion.Visible = false;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistClient_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            frmListaCliente listaClientes = new frmListaCliente();
            listaClientes.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelSubAdministrar.Visible = false;
            frmClientes clientes = new frmClientes();
            clientes.Show();
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }

            panelSubAdministrar.Visible = true;
        }

        private void btnTipoCliente_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            if (panelSubAdministrar.Visible = true)
            {
                panelSubAdministrar.Visible = false;
            }
            frmTipoCliente tipoclienteform = new frmTipoCliente();
            tipoclienteform.Show();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            if (panelSubAdministrar.Visible = true)
            {
                panelSubAdministrar.Visible = false;
            }
            subMantenimientos.Visible = true;

        }

        private void btnManteProveedores_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            if (panelSubAdministrar.Visible = true)
            {
                panelSubAdministrar.Visible = false;
            }

            subMantenimientos.Visible = false;
            MantenimientoProveedores mantenimientoProveedores = new MantenimientoProveedores();
            mantenimientoProveedores.Show();

        }

        private void btnManteMembresia_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            if (panelSubAdministrar.Visible = true)
            {
                panelSubAdministrar.Visible = false;
            }

            subMantenimientos.Visible = false;
            frmMembresia mantenimientoMembresia = new frmMembresia();
            mantenimientoMembresia.Show();

        }

        private void btnTipoMembresia_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (subbtnFacturacionMembresia.Visible = true)
            {
                subbtnFacturacionMembresia.Visible = false;
            }
            if (subMantenimientos.Visible = true)
            {
                subMantenimientos.Visible = false;
            }
            panelSubAdministrar.Visible = false;
            frmUsuario usuarios = new frmUsuario();
            usuarios.Show();
            
        }
    }
}
