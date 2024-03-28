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
    public partial class nuevoCargoCredito : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasion (COMFORT GYM) dice";
        public nuevoCargoCredito()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarClienteCargoCredito_Click(object sender, EventArgs e)
        {
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesBLL.GetById((int)listaClientes.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDClienteCargoCredito.Text = oCliente.IDCliente.ToString();
                    this.TxbDocClienteCargoCredito.Text = oCliente.Documento.ToString();
                    this.TxbNombreClienteCargoCredito.Text = oCliente.Nombre.ToString();
                    this.TxbApellidoClienteCargoCredito.Text = oCliente.Apellido.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCamposCC()
        {
            TxbIDClienteCargoCredito.Clear();
            TxbNombreClienteCargoCredito.Clear();
            TxbApellidoClienteCargoCredito.Clear();
            TxbDocClienteCargoCredito.Clear();
            TxbCargoCredito.Clear();
            TxbMontoCargoCredito.Clear();
        }

        private void btnGuardarCargoCredito_Click(object sender, EventArgs e)
        {
            CargoCreditoEntity nuevoCargoCredito = new CargoCreditoEntity();

            nuevoCargoCredito.IDCliente = Convert.ToInt32(TxbIDClienteCargoCredito.Text);
            nuevoCargoCredito.Cargo = TxbCargoCredito.Text;
            nuevoCargoCredito.Monto = Convert.ToDecimal(TxbMontoCargoCredito.Text);
            nuevoCargoCredito.FechaCargo = DateTime.Now;
            nuevoCargoCredito.Estatus = "Activo";

            try
            {
                CargoCreditoBLL.Guardar(nuevoCargoCredito);
                MessageBox.Show("¡Cargo Credito del Cliente Guardado Satisfactoriamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCC();
            }
            catch (SqlException ext)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cargo Credito. \nDetalles A Continuación: \n" + ext.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cargo Credito.\n Detalles A Continuación: \n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
