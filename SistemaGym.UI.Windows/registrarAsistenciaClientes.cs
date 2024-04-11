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
    public partial class registrarAsistenciaClientes : Form
    {
        public registrarAsistenciaClientes()
        {
            InitializeComponent();
        }
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice:";
        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesBLL.GetById((int)listaClientes.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDCliente.Text = oCliente.IDCliente.ToString();
                    this.TxbNombreCliente.Text = oCliente.Nombre.ToString();
                    this.TxbApellidoCliente.Text = oCliente.Apellido.ToString();
                    this.TxbTipoDocumento.Text = oCliente.TipoDocumento.ToString();
                    this.TxbDocumentoCliente.Text = oCliente.Documento.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
