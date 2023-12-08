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
            frmFacturaProductos.MdiParent = this;
            frmFacturaProductos.Show();
        }

        private void subbtnFacturacionMembresia_Click(object sender, EventArgs e)
        {
            subFacturacion.Visible = false;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MantenimientoProveedores mantenimientoProveedores = new MantenimientoProveedores();
            mantenimientoProveedores.MdiParent = this;
            mantenimientoProveedores.Show();
        }

        private void btnAssistClient_Click(object sender, EventArgs e)
        {
           
        }
    }
}
