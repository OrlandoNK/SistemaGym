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
    public partial class nuevoCargoDebito : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasion (COMFORT GYM) dice";
        public nuevoCargoDebito()
        {
            InitializeComponent();
        }

        private void btnBuscarClienteCargoDebito_Click(object sender, EventArgs e)
        {
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesBLL.GetById((int)listaClientes.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDClienteCargoDebito.Text = oCliente.IDCliente.ToString();
                    this.TxbDocClienteCargoDebito.Text = oCliente.Documento.ToString();
                    this.TxbNombreClienteCargoDebito.Text = oCliente.Nombre.ToString();
                    this.TxbApellidoClienteCargoDebito.Text = oCliente.Apellido.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCamposCD()
        {
            TxbIDClienteCargoDebito.Clear();
            TxbNombreClienteCargoDebito.Clear();
            TxbApellidoClienteCargoDebito.Clear();
            TxbDocClienteCargoDebito.Clear();
            TxbCargoDebito.Clear();
            TxbMontoCargoDebito.Clear();
        }
        private void btnGuardarCargoDebito_Click(object sender, EventArgs e)
        {
            CargoDebitoEntity nuevoCargoDebito = new CargoDebitoEntity();

            nuevoCargoDebito.IDCliente = Convert.ToInt32(TxbIDClienteCargoDebito.Text);
            nuevoCargoDebito.Cargo = TxbCargoDebito.Text;
            nuevoCargoDebito.Monto = Convert.ToDecimal(TxbMontoCargoDebito.Text);
            nuevoCargoDebito.FechaCargo = DateTime.Now;
            nuevoCargoDebito.Estatus = "Activo";

            try
            {
                CargoDebitoBLL.Guardar(nuevoCargoDebito);
                MessageBox.Show("¡Cargo Debito del Cliente Guardado Satisfactoriamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCD();
            }
            catch (SqlException ext)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cargo Debito. \nDetalles A Continuación: \n" + ext.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cargo Debito.\n Detalles A Continuación: \n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
