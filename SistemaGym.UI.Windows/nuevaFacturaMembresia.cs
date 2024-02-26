using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class nuevaFacturaMembresia : Form
    {
        public nuevaFacturaMembresia()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarIDMembresia_Click(object sender, EventArgs e)
        {
            listaMembresias listaMembresias = new listaMembresias();

            if (listaMembresias.ShowDialog() == DialogResult.OK)
            {
                MembresiaEntity oMembresia = MembresiaBLL.GetById((int)listaMembresias.IdMembresia);

                if (oMembresia != null)
                {
                    this.TxbIDMembresia.Text = oMembresia.IDMembresia.ToString();
                    this.TxbNombreMembresia.Text = oMembresia.Nombre.ToString();
                    this.TxbDescrMembresia.Text = oMembresia.Descripcion.ToString();
                    this.TxbValorMembresia.Text = Convert.ToInt32(oMembresia.Valor).ToString();
                }
                else
                {
                    MessageBox.Show("Membresia No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesBLL.GetById((int)listaClientes.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDCliente.Text = oCliente.IDCliente.ToString();
                    this.TxbDocumentoCliente.Text = oCliente.Documento.ToString();
                    this.TxbNombreCliente.Text = oCliente.Nombre.ToString();
                    this.TxbApellidoCliente.Text = oCliente.Apellido.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nuevaFacturaMembresia_Load(object sender, EventArgs e)
        {
            TxbIDUsuario.Text = gestioUsuarioEntities.IDUserLogged;
            TxbNombreApellidoUsuario.Text = gestioUsuarioEntities.usernameLogged;
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
                    MessageBox.Show("Cliente No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM)";
        private void btnGuardarCargoCredito_Click(object sender, EventArgs e)
        {
            CargoCreditoEntity nuevoCargoCredito = new CargoCreditoEntity();

            nuevoCargoCredito.IDCliente = Convert.ToInt32(TxbIDClienteCargoCredito.Text);
            nuevoCargoCredito.Cargo = TxbCargoCredito.Text;
            nuevoCargoCredito.Monto = Convert.ToDecimal(TxbMontoCargoCredito.Text);
            nuevoCargoCredito.FechaCargo = Convert.ToDateTime(dtpFechaCargoCredito.Value.ToShortDateString());
            nuevoCargoCredito.Estatus = TxbEstatusCargoCredito.SelectedItem.ToString();

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

        private void LimpiarCamposCC()
        {
            TxbIDClienteCargoCredito.Clear();
            TxbNombreClienteCargoCredito.Clear();
            TxbApellidoClienteCargoCredito.Clear();
            TxbDocClienteCargoCredito.Clear();
            TxbCargoCredito.Clear();
            TxbMontoCargoCredito.Clear();
            dtpFechaCargoCredito.Value = DateTime.Now;
            TxbEstatusCargoCredito.SelectedIndex = -1;
        }
        private void LimpiarCamposCD()
        {
            TxbIDClienteCargoDebito.Clear();
            TxbNombreClienteCargoDebito.Clear();
            TxbApellidoClienteCargoDebito.Clear();
            TxbDocClienteCargoDebito.Clear();
            TxbCargoDebito.Clear();
            TxbMontoCargoDebito.Clear();
            dtpFechaCargoDebito.Value = DateTime.Now;
            TxbEstatusCargoDebito.SelectedIndex = -1;
        }

        private void btnGuardarCargoDebito_Click(object sender, EventArgs e)
        {
            CargoDebitoEntity nuevoCargoDebito = new CargoDebitoEntity();

            nuevoCargoDebito.IDCliente = Convert.ToInt32(TxbIDClienteCargoDebito.Text);
            nuevoCargoDebito.Cargo = TxbCargoDebito.Text;
            nuevoCargoDebito.Monto = Convert.ToDecimal(TxbMontoCargoDebito.Text);
            nuevoCargoDebito.FechaCargo = Convert.ToDateTime(dtpFechaCargoDebito.Value.ToShortDateString());
            nuevoCargoDebito.Estatus = TxbEstatusCargoDebito.SelectedItem.ToString();

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

        private void btnBuscarFacturaCargoCredito_Click(object sender, EventArgs e)
        {
            listaCargoCredito listaCargoCredito = new listaCargoCredito();

            if (listaCargoCredito.ShowDialog() == DialogResult.OK)
            {
                CargoCreditoEntity oCargoCredito = CargoCreditoBLL.GetById((int)listaCargoCredito.IdCargoCredito);

                if (oCargoCredito != null)
                {
                    this.TxbFacturaIDCargoCredito.Text = oCargoCredito.IDCargoCredito.ToString();
                    this.TxbFacturacionCargoCredito.Text = Convert.ToInt32(oCargoCredito.Cargo).ToString();
                    this.TxbFacturaMontoCargoCredito.Text = Convert.ToInt32(oCargoCredito.Monto).ToString();
                    this.dtpFechaFacturaCargoCredito.Text = oCargoCredito.FechaCargo.ToString();
                }
                else
                {
                    MessageBox.Show("Cargo Credito No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarFacturaCargoDebito_Click(object sender, EventArgs e)
        {
            listaCargoDebito listaCargoDebito = new listaCargoDebito();

            if (listaCargoDebito.ShowDialog() == DialogResult.OK)
            {
                CargoDebitoEntity oCargoDebito = CargoDebitoBLL.GetById((int)listaCargoDebito.IdCargoDebito);

                if (oCargoDebito != null)
                {
                    this.TxbFacturaIDCargoDebito.Text = oCargoDebito.IDCargoDebito.ToString();
                    this.TxbFacturaCargoDebito.Text = Convert.ToInt32(oCargoDebito.Cargo).ToString();
                    this.TxbFacturaMontoCargoDebito.Text = Convert.ToInt32(oCargoDebito.Monto).ToString();
                    this.dtpFechaFacturaCargoDebito.Text = oCargoDebito.FechaCargo.ToString();
                }
                else
                {
                    MessageBox.Show("Cargo Debito No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFacturarMembresia_Click(object sender, EventArgs e)
        {

            int ValorMembresia = int.Parse(TxbValorMembresia.Text);
            int FacturaCC = int.Parse(TxbFacturacionCargoCredito.Text);
            int FacturaCD = int.Parse(TxbFacturaCargoDebito.Text);

            TxbFacturaValor.Text = Convert.ToString(ValorMembresia + (FacturaCC + FacturaCD));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string SYSTEM_TITLE = "SISTEMA GESTION GIMNASIO (COMFORT GYM)";

            FacturaMembresiaEntity nuevaFacturaMembresia = new FacturaMembresiaEntity();
            FacturaMembresiaBLL facturaMembresiaBLL = new FacturaMembresiaBLL();

            nuevaFacturaMembresia.IDMembresia = Convert.ToInt32(TxbIDMembresia.Text);
            nuevaFacturaMembresia.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
            nuevaFacturaMembresia.IDUsuario = Convert.ToInt32(TxbIDUsuario.Text);
            nuevaFacturaMembresia.CargoCredito = Convert.ToInt32(TxbFacturaIDCargoCredito.Text);
            nuevaFacturaMembresia.CargoDebito = Convert.ToInt32(TxbFacturaIDCargoDebito.Text);
            nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
            nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
            nuevaFacturaMembresia.FechaEmision = Convert.ToDateTime(dtpFacturaFechaEmision.Value.ToShortDateString());
            nuevaFacturaMembresia.FechaVencimiento = Convert.ToDateTime(dtpFacturaFechaVencimiento.Value.ToShortDateString());
            if (chkbxEstatus.Checked)
            {
                nuevaFacturaMembresia.Estatus = "Activo";
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("¿Seguro que desea Guardar esta Factura como «Inactivo»", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    nuevaFacturaMembresia.Estatus = "Inactivo";
                }
                if (dialogResult == DialogResult.No)
                {

                }
            }

            try
            {
                facturaMembresiaBLL.Insertar(nuevaFacturaMembresia);
                MessageBox.Show("¡Factura de Membresia Guardada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTodosLosCampos();
            }
            catch (SqlException ex2)
            {
                MessageBox.Show("Se produjo un error al Intentar Guardar la Factura. \nDetalles a continuación: \n" + ex2.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Se produjo un error al Intentar Guardar la Factura. \nDetalles a continuación: \n" + ex1.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarTodosLosCampos()
        {
            TxbIDMembresia.Clear();
            TxbNombreMembresia.Clear();
            TxbDescrMembresia.Clear();
            TxbValorMembresia.Clear();

            TxbIDCliente.Clear();
            TxbNombreCliente.Clear();
            TxbApellidoCliente.Clear();
            TxbDocumentoCliente.Clear();

            TxbFacturacionCargoCredito.Clear();
            TxbFacturaIDCargoCredito.Clear();
            TxbFacturaMontoCargoCredito.Clear();
            dtpFechaCargoCredito.Value = DateTime.Now;

            TxbFacturaIDCargoDebito.Clear();
            TxbFacturaCargoDebito.Clear();
            TxbFacturaMontoCargoDebito.Clear();
            dtpFechaCargoDebito.Value = DateTime.Now;

            TxbFacturaNCF.Clear();
            dtpFacturaFechaEmision.Value = DateTime.Now;
            dtpFacturaFechaVencimiento.Value = DateTime.Now;
            TxbFacturaValor.Clear();
        }

    }
}