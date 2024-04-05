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
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
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
                    this.TxbTipoDocumento.Text = oCliente.TipoDocumento.ToString();
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

            TxbFacturaNCF.Text = "B0100000005";
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
            if (!ValidateToFacturate())
            {

                return;
            }

            try
            {
                int ValorMembresia = int.Parse(TxbValorMembresia.Text);
                int FacturaCC = int.Parse(TxbFacturaMontoCargoCredito.Text);
                int FacturaCD = int.Parse(TxbFacturaMontoCargoDebito.Text);

                TxbFacturaValor.Text = Convert.ToString(ValorMembresia + (FacturaCC + FacturaCD));
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se produjo un error al Intentar Facturar. \nDetalles a continuación: \n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al Intentar Facturar. \nDetalles a continuación: \n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarCampos()
        {
            bool validacion = true;

            errorProvider.Clear();
            string MembresiaObligatoria = "¡Debes de Agregar la Membresia!";
            string ClienteObligatorio = "¡Debes de Agregar el Cliente!";
            string ValidaDatosFactura = "¡Este Campo es Obligatorio!";

            /* Validar si se agregó la Membresia */
            int IDMembresia;
            if (string.IsNullOrEmpty(TxbIDMembresia.Text))
            {
                errorProvider.SetError(TxbIDMembresia, MembresiaObligatoria);
                validacion = false;
            }
            else if (!int.TryParse(TxbIDMembresia.Text, out IDMembresia))
            {
                errorProvider.SetError(TxbIDMembresia, MembresiaObligatoria);
            }
            if (string.IsNullOrEmpty(TxbNombreMembresia.Text))
            {
                errorProvider.SetError(TxbNombreMembresia, MembresiaObligatoria);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbDescrMembresia.Text))
            {
                errorProvider.SetError(TxbDescrMembresia, MembresiaObligatoria);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbValorMembresia.Text))
            {
                errorProvider.SetError(TxbValorMembresia, MembresiaObligatoria);
                validacion = false;
            }
            /* Validar si se agregó el Cliente */
            int IDCliente;
            if (string.IsNullOrEmpty(TxbIDCliente.Text))
            {
                errorProvider.SetError(TxbIDCliente, ClienteObligatorio);
                validacion = false;
            }
            else if (!int.TryParse(TxbIDCliente.Text, out IDCliente))
            {
                errorProvider.SetError(TxbIDCliente, ClienteObligatorio);
            }
            if (string.IsNullOrEmpty(TxbNombreCliente.Text))
            {
                errorProvider.SetError(TxbNombreCliente, ClienteObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbDocumentoCliente.Text))
            {
                errorProvider.SetError(TxbDocumentoCliente, ClienteObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbApellidoCliente.Text))
            {
                errorProvider.SetError(TxbApellidoCliente, ClienteObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbTipoDocumento.Text))
            {
                errorProvider.SetError(TxbTipoDocumento, ClienteObligatorio);
                validacion = false;
            }

            /* Validar Datos de la Factura */
            int IDFactCC;
            if (string.IsNullOrEmpty(TxbFacturaIDCargoCredito.Text))
            {
                errorProvider.SetError(TxbFacturaIDCargoCredito, ValidaDatosFactura);
                validacion = false;
            }
            else if (!int.TryParse(TxbFacturaIDCargoCredito.Text, out IDFactCC))
            {
                errorProvider.SetError(TxbFacturaIDCargoCredito, ValidaDatosFactura);
            }
            if (string.IsNullOrEmpty(TxbFacturacionCargoCredito.Text))
            {
                errorProvider.SetError(TxbFacturacionCargoCredito, ValidaDatosFactura);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbFacturaMontoCargoCredito.Text))
            {
                errorProvider.SetError(TxbFacturaMontoCargoCredito, ValidaDatosFactura);
                validacion = false;
            }
            int IDFactCD;
            if (string.IsNullOrEmpty(TxbFacturaIDCargoDebito.Text))
            {
                errorProvider.SetError(TxbFacturaIDCargoDebito, ValidaDatosFactura);
                validacion = false;
            }
            else if (!int.TryParse(TxbFacturaIDCargoDebito.Text, out IDFactCD))
            {
                errorProvider.SetError(TxbFacturaIDCargoDebito, ValidaDatosFactura);
            }
            if (string.IsNullOrEmpty(TxbFacturaCargoDebito.Text))
            {
                errorProvider.SetError(TxbFacturaCargoDebito, ValidaDatosFactura);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbFacturaMontoCargoDebito.Text))
            {
                errorProvider.SetError(TxbFacturaMontoCargoDebito, ValidaDatosFactura);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbFacturaValor.Text))
            {
                errorProvider.SetError(TxbFacturaValor, ValidaDatosFactura);
                validacion = false;
            }

            return validacion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {

                return;
            }

            FacturaMembresiaEntity nuevaFacturaMembresia = new FacturaMembresiaEntity();
            FacturaMembresiaBLL facturaMembresiaBLL = new FacturaMembresiaBLL();

            nuevaFacturaMembresia.IDMembresia = Convert.ToInt32(TxbIDMembresia.Text);
            nuevaFacturaMembresia.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
            nuevaFacturaMembresia.IDUsuario = Convert.ToInt32(TxbIDUsuario.Text);
            nuevaFacturaMembresia.CargoCredito = Convert.ToInt32(TxbFacturaIDCargoCredito.Text);
            nuevaFacturaMembresia.CargoDebito = Convert.ToInt32(TxbFacturaIDCargoDebito.Text);
            nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
            nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
            nuevaFacturaMembresia.FechaEmision = DateTime.Now;
            nuevaFacturaMembresia.FechaVencimiento = DateTime.Now.AddDays(30);
            if (chkbxEstatus.Checked)
            {
                nuevaFacturaMembresia.Estatus = "Pagado";
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("¿Seguro que desea Guardar esta Factura como «No Pagado»", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    nuevaFacturaMembresia.Estatus = "No Pagado";
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

        private bool ValidateToFacturate()
        {
            errorProvider.Clear();
            bool facturarValidar = true;
            string ObligatorioParaFacturar = "¡Debe Llenar este Campo para Facturar!";

            if (string.IsNullOrEmpty(TxbValorMembresia.Text))
            {
                errorProvider.SetError(TxbValorMembresia, ObligatorioParaFacturar);
                facturarValidar = false;
            }
            int ValorMembresia;
            if (!int.TryParse(TxbValorMembresia.Text, out ValorMembresia))
            {
                errorProvider.SetError(TxbValorMembresia, ObligatorioParaFacturar);
                facturarValidar = false;
            }
            if (string.IsNullOrEmpty(TxbFacturaMontoCargoCredito.Text))
            {
                errorProvider.SetError(TxbFacturaMontoCargoCredito, ObligatorioParaFacturar);
                facturarValidar = false;
            }
            int CargoCredito;
            if (!int.TryParse(TxbFacturaMontoCargoCredito.Text, out CargoCredito))
            {
                errorProvider.SetError(TxbFacturaMontoCargoCredito, ObligatorioParaFacturar);
                facturarValidar = false;
            }
            if (string.IsNullOrEmpty(TxbFacturaMontoCargoDebito.Text))
            {
                errorProvider.SetError(TxbFacturaMontoCargoDebito, ObligatorioParaFacturar);
                facturarValidar = false;
            }
            int CargoDebito;
            if (!int.TryParse(TxbFacturaMontoCargoDebito.Text, out CargoDebito))
            {
                errorProvider.SetError(TxbFacturaMontoCargoDebito, ObligatorioParaFacturar);
                facturarValidar = false;
            }

            return facturarValidar;
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
            TxbTipoDocumento.Clear();
            TxbDocumentoCliente.Clear();

            TxbFacturacionCargoCredito.Clear();
            TxbFacturaIDCargoCredito.Clear();
            TxbFacturaMontoCargoCredito.Clear();
            dtpFechaFacturaCargoCredito.Value = DateTime.Now;

            TxbFacturaIDCargoDebito.Clear();
            TxbFacturaCargoDebito.Clear();
            TxbFacturaMontoCargoDebito.Clear();
            dtpFechaFacturaCargoDebito.Value = DateTime.Now;

            TxbFacturaNCF.Clear();
            TxbFacturaValor.Clear();
        }

        private void btnNuevoCargoCredito_Click(object sender, EventArgs e)
        {
            nuevoCargoCredito nuevoCargoCredito = new nuevoCargoCredito();
            nuevoCargoCredito.Show();
        }

        private void btnNuevoCargoDebito_Click(object sender, EventArgs e)
        {
            nuevoCargoDebito nuevoCargoDebito = new nuevoCargoDebito();
            nuevoCargoDebito.Show();
        }
    }
}