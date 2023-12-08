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
    public partial class frmFacturaProductos : Form
    {
        public frmFacturaProductos()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            if (frmBuscarCliente.ShowDialog() == DialogResult.OK)
            {

                ClientesEntity cliente = ClientesBLL.BuscarPorID(frmBuscarCliente.id);
                txtIDCliente.Text = cliente.IDCliente.ToString();
                txtCliente.Text = cliente.Nombre;
                txtDocumento.Text = cliente.Documento;
                txtTipoCliente.Text = cliente.TipoCliente.ToString();
               



            }
        }
    }
}
