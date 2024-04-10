﻿using SistemaGym.BLL;
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

        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            ClientesBLL clientesBLL = new ClientesBLL();
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int idCliente = listaClientes.IdCliente;
                    DataTable DT = clientesBLL.GetClientMembreship(idCliente);

                    if (DT.Rows.Count > 0)
                    {
                        TxbIDCliente.Text = DT.Rows[0]["IDCliente"].ToString();
                        TxbNombreCliente.Text = DT.Rows[0]["Nombre"].ToString();
                        TxbApellidoCliente.Text = DT.Rows[0]["Apellido"].ToString();
                        TxbTipoDocumento.Text = DT.Rows[0]["TipoDocumento"].ToString();
                        TxbDocumentoCliente.Text = DT.Rows[0]["Documento"].ToString();

                        TxbIDMembresia.Text = DT.Rows[0]["IDMembresia"].ToString();
                        TxbNombreMembresia.Text = DT.Rows[0]["NombreMembresia"].ToString();
                        TxbDescrMembresia.Text = DT.Rows[0]["Descripcion"].ToString();
                        TxbValorMembresia.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

                    }
                    else
                    {
                        MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se Produjo un Error al Intentar Obtener el Cliente:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se Produjo un Error al Intentar Obtener el Cliente:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nuevaFacturaMembresia_Load(object sender, EventArgs e)
        {
            TxbIDUsuario.Text = gestioUsuarioEntities.IDUserLogged;
            TxbNombreApellidoUsuario.Text = gestioUsuarioEntities.usernameLogged;

            TxbFacturaNCF.Text = "B0100000005";
        }

        private void btnFacturarMembresia_Click(object sender, EventArgs e)
        {
            if (!ValidateToFacturate())
            {

                return;
            }

            try
            {
                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);
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
            nuevaFacturaMembresia.Estatus = "Pagado";

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
            decimal ValorMembresia;
            if (!decimal.TryParse(TxbValorMembresia.Text, out ValorMembresia))
            {
                errorProvider.SetError(TxbValorMembresia, ObligatorioParaFacturar);
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

            TxbFacturaNCF.Clear();
            TxbFacturaValor.Clear();
        }

    }
}