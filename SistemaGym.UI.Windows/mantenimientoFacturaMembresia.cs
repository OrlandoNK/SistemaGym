using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class mantenimientoFacturaMembresia : Form
    {
        public mantenimientoFacturaMembresia()
        {
            InitializeComponent();
        }

        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {
            listaMembresias buscarMembresia = new listaMembresias();

            if (buscarMembresia.ShowDialog() == DialogResult.OK)
            {
                MembresiaEntity oMembresia = MembresiaDAL.GetById(buscarMembresia.IdMembresia);

                if (oMembresia != null)
                {
                    this.TxbIDMembresia.Text = oMembresia.IDMembresia.ToString();
                    this.TxbMembresia.Text = oMembresia.Nombre;
                }
                else
                {
                    MessageBox.Show("Membresia No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            listaClientes clientesList = new listaClientes();

            if (clientesList.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesDAL.GetById(clientesList.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDCliente.Text = oCliente.IDCliente.ToString();
                    this.TxbCliente.Text = oCliente.Nombre;
                    this.TxbTipoDoc.Text = oCliente.TipoDocumento.ToString();
                    this.TxbDoc.Text = oCliente.Documento.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            TxbIDFactura.Text = "0";
            TxbUsuario.Text = " ";
            TxbNCF.Text = " ";
            TxbCargoCredito.SelectedIndex = -1;
            TxbCargoDebito.SelectedIndex = -1;
            dtpFechaEmision.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now;
            TxbValorFactura.Text = " ";
            TxbEstatus.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
