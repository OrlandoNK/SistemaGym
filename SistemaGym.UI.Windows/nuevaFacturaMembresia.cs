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


        private bool ValidarDecision()
        {
            bool validacion = true;

            if (!rbtnSiTieneCargoCredito.Checked &&
                !rbtnNoTieneCargoCredito.Checked &&
                !rbtnSiTieneCargoDebito.Checked &&
                !rbtnNoTieneCargoDebito.Checked)
            {
                MessageBox.Show("¡Es Necesario decir si Tiene o No Cargos! \nPor Favor, Escoja una Opcion", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }


            return validacion;
        }

        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            ClientesBLL clientesBLL = new ClientesBLL();
            listaClientes listaClientes = new listaClientes();

            if (!ValidarDecision())
            {
                return;
            }

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int idCliente = listaClientes.IdCliente;
                    DataTable DT = clientesBLL.ObtenerClienteCargosMembresiaAndGruposMejorado(idCliente);

                    if (rbtnSiPerteneceGrupoCliente.Checked)
                    {
                        if (rbtnSiTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoCredito */
                                TxbIDCargoCredito.Text = DT.Rows[0]["IDCargoCredito"].ToString();
                                TxbCargoCredito.Text = DT.Rows[0]["CargoCredito"].ToString();
                                TxbMontoCredito.Text = Convert.ToDecimal(DT.Rows[0]["MontoCredito"]).ToString("0.00");
                                TxbFechaCargoCredito.Text = DT.Rows[0]["FechaCargoCredito"].ToString();
                                TxbEstatusCredito.Text = DT.Rows[0]["EstatusCredito"].ToString();

                                /* Llenar Campos de CargoDebito */
                                TxbIDCargoDebito.Text = DT.Rows[0]["IDCargoDebito"].ToString();
                                TxbCargoDebito.Text = DT.Rows[0]["CargoDebito"].ToString();
                                TxbMontoDebito.Text = Convert.ToDecimal(DT.Rows[0]["MontoDebito"]).ToString("0.00");
                                TxbFechaCargoDebito.Text = DT.Rows[0]["FechaCargoDebito"].ToString();
                                TxbEstatusDebito.Text = DT.Rows[0]["EstatusDebito"].ToString();

                                TxbIDGrupoCliente.Text = DT.Rows[0]["IDGrupoCliente"].ToString();
                                TxbNombreGrupoMembresia.Text = DT.Rows[0]["NombreGrupoMembresia"].ToString();
                                TxbMontoGrupoCliente.Text = Convert.ToDecimal(DT.Rows[0]["MontoGrupoCliente"]).ToString("0.00");
                                TxbFechaRegistroGrupo.Text = DT.Rows[0]["FechaRegistroGrupo"].ToString();
                                TxbEstatus.Text = DT.Rows[0]["EstatusGrupo"].ToString();
                                TxbClientesActivos.Text = Convert.ToDecimal(DT.Rows[0]["ClientesActivos"]).ToString("0.00");

                                decimal MontoCredito = decimal.Parse(TxbMontoCredito.Text);
                                decimal MontoDebito = decimal.Parse(TxbMontoDebito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                decimal CantidadActivos = decimal.Parse(TxbClientesActivos.Text);
                                decimal MontoTotalGrupo = decimal.Parse(TxbMontoTotalGrupo.Text);
                                decimal MontoGrupoCliente = decimal.Parse(TxbMontoGrupoCliente.Text);

                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(MontoGrupoCliente * CantidadActivos).ToString("0.00");
                                TxbFacturaValor.Text = Convert.ToDecimal(MontoGrupoCliente + (MontoCredito + MontoDebito)).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnNoTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

                                TxbIDGrupoCliente.Text = DT.Rows[0]["IDGrupoCliente"].ToString();
                                TxbNombreGrupoMembresia.Text = DT.Rows[0]["NombreGrupoMembresia"].ToString();
                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(DT.Rows[0]["MontoTotalGrupo"]).ToString("0.00");
                                TxbMontoGrupoCliente.Text = Convert.ToDecimal(DT.Rows[0]["MontoGrupoCliente"]).ToString("0.00");
                                TxbFechaRegistroGrupo.Text = DT.Rows[0]["FechaRegistroGrupo"].ToString();
                                TxbEstatus.Text = DT.Rows[0]["EstatusGrupo"].ToString();
                                TxbClientesActivos.Text = Convert.ToDecimal(DT.Rows[0]["ClientesActivos"]).ToString("0.00");

                                decimal CantidadActivos = decimal.Parse(TxbClientesActivos.Text);
                                decimal MontoGrupoCliente = decimal.Parse(TxbMontoGrupoCliente.Text);
                                decimal MontoTotalGrupo = decimal.Parse(TxbMontoTotalGrupo.Text);

                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(MontoGrupoCliente * CantidadActivos).ToString("0.00");
                                TxbFacturaValor.Text = Convert.ToDecimal(MontoGrupoCliente).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnSiTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoCredito */
                                TxbIDCargoCredito.Text = DT.Rows[0]["IDCargoCredito"].ToString();
                                TxbCargoCredito.Text = DT.Rows[0]["CargoCredito"].ToString();
                                TxbMontoCredito.Text = Convert.ToDecimal(DT.Rows[0]["MontoCredito"]).ToString("0.00");
                                TxbFechaCargoCredito.Text = DT.Rows[0]["FechaCargoCredito"].ToString();
                                TxbEstatusCredito.Text = DT.Rows[0]["EstatusCredito"].ToString();

                                TxbIDGrupoCliente.Text = DT.Rows[0]["IDGrupoCliente"].ToString();
                                TxbNombreGrupoMembresia.Text = DT.Rows[0]["NombreGrupoMembresia"].ToString();
                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(DT.Rows[0]["MontoTotalGrupo"]).ToString("0.00");
                                TxbMontoGrupoCliente.Text = Convert.ToDecimal(DT.Rows[0]["MontoGrupoCliente"]).ToString("0.00");
                                TxbFechaRegistroGrupo.Text = DT.Rows[0]["FechaRegistroGrupo"].ToString();
                                TxbEstatus.Text = DT.Rows[0]["EstatusGrupo"].ToString();
                                TxbClientesActivos.Text = Convert.ToDecimal(DT.Rows[0]["ClientesActivos"]).ToString("0.00");

                                decimal CantidadActivos = decimal.Parse(TxbClientesActivos.Text);
                                decimal MontoGrupoCliente = decimal.Parse(TxbMontoGrupoCliente.Text);
                                decimal MontoCredito = decimal.Parse(TxbMontoCredito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);
                                decimal MontoTotalGrupo = decimal.Parse(TxbMontoTotalGrupo.Text);

                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(MontoGrupoCliente * CantidadActivos).ToString("0.00");
                                TxbFacturaValor.Text = Convert.ToDecimal((MontoGrupoCliente + MontoCredito)).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnNoTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoDebito */
                                TxbIDCargoDebito.Text = DT.Rows[0]["IDCargoDebito"].ToString();
                                TxbCargoDebito.Text = DT.Rows[0]["CargoDebito"].ToString();
                                TxbMontoDebito.Text = Convert.ToDecimal(DT.Rows[0]["MontoDebito"]).ToString("0.00");
                                TxbFechaCargoDebito.Text = DT.Rows[0]["FechaCargoDebito"].ToString();
                                TxbEstatusDebito.Text = DT.Rows[0]["EstatusDebito"].ToString();

                                TxbIDGrupoCliente.Text = DT.Rows[0]["IDGrupoCliente"].ToString();
                                TxbNombreGrupoMembresia.Text = DT.Rows[0]["NombreGrupoMembresia"].ToString();
                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(DT.Rows[0]["MontoTotalGrupo"]).ToString("0.00");
                                TxbMontoGrupoCliente.Text = Convert.ToDecimal(DT.Rows[0]["MontoGrupoCliente"]).ToString("0.00");
                                TxbFechaRegistroGrupo.Text = DT.Rows[0]["FechaRegistroGrupo"].ToString();
                                TxbEstatus.Text = DT.Rows[0]["EstatusGrupo"].ToString();
                                TxbClientesActivos.Text = Convert.ToDecimal(DT.Rows[0]["ClientesActivos"]).ToString("0.00");

                                decimal CantidadActivos = decimal.Parse(TxbClientesActivos.Text);
                                decimal MontoGrupoCliente = decimal.Parse(TxbMontoGrupoCliente.Text);
                                decimal MontoTotalGrupo = decimal.Parse(TxbMontoTotalGrupo.Text);

                                decimal MontoDebito = decimal.Parse(TxbMontoDebito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                TxbMontoTotalGrupo.Text = Convert.ToDecimal(MontoGrupoCliente * CantidadActivos).ToString("0.00");
                                TxbFacturaValor.Text = Convert.ToDecimal((MontoGrupoCliente + MontoDebito)).ToString("0.00");

                            }

                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    int idClienteSinGrupo = listaClientes.IdCliente;
                    DataTable DT2 = clientesBLL.GetClientCargos(idClienteSinGrupo);
                    if (rbtnNoPerteneceGrupoCliente.Checked)
                    {
                        if (rbtnSiTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT2.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT2.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT2.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT2.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT2.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT2.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT2.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT2.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT2.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT2.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoCredito */
                                TxbIDCargoCredito.Text = DT2.Rows[0]["IDCargoCredito"].ToString();
                                TxbCargoCredito.Text = DT2.Rows[0]["CargoCredito"].ToString();
                                TxbMontoCredito.Text = Convert.ToDecimal(DT2.Rows[0]["MontoCredito"]).ToString("0.00");
                                TxbFechaCargoCredito.Text = DT2.Rows[0]["FechaCargoCredito"].ToString();
                                TxbEstatusCredito.Text = DT2.Rows[0]["EstatusCredito"].ToString();

                                /* Llenar Campos de CargoDebito */
                                TxbIDCargoDebito.Text = DT2.Rows[0]["IDCargoDebito"].ToString();
                                TxbCargoDebito.Text = DT2.Rows[0]["CargoDebito"].ToString();
                                TxbMontoDebito.Text = Convert.ToDecimal(DT.Rows[0]["MontoDebito"]).ToString("0.00");
                                TxbFechaCargoDebito.Text = DT2.Rows[0]["FechaCargoDebito"].ToString();
                                TxbEstatusDebito.Text = DT2.Rows[0]["EstatusDebito"].ToString();

                                decimal MontoCredito = decimal.Parse(TxbMontoCredito.Text);
                                decimal MontoDebito = decimal.Parse(TxbMontoDebito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                TxbFacturaValor.Text = Convert.ToDecimal(ValorMembresia + (MontoCredito + MontoDebito)).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnNoTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT2.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT2.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT2.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT2.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT2.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT2.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT2.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT2.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT2.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT2.Rows[0]["Valor"]).ToString("0.00");


                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);
                                TxbFacturaValor.Text = Convert.ToDecimal(ValorMembresia).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnSiTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT2.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT2.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT2.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT2.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT2.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT2.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT2.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT2.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT2.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT2.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoCredito */
                                TxbIDCargoCredito.Text = DT2.Rows[0]["IDCargoCredito"].ToString();
                                TxbCargoCredito.Text = DT2.Rows[0]["CargoCredito"].ToString();
                                TxbMontoCredito.Text = Convert.ToDecimal(DT2.Rows[0]["MontoCredito"]).ToString("0.00");
                                TxbFechaCargoCredito.Text = DT2.Rows[0]["FechaCargoCredito"].ToString();
                                TxbEstatusCredito.Text = DT2.Rows[0]["EstatusCredito"].ToString();


                                decimal MontoCredito = decimal.Parse(TxbMontoCredito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                TxbFacturaValor.Text = Convert.ToDecimal((ValorMembresia + MontoCredito)).ToString("0.00");

                            }
                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        if (rbtnNoTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
                        {
                            LimpiarCargos();

                            if (DT2.Rows.Count > 0)
                            {
                                /* Llenar Campos de Cliente */
                                TxbIDCliente.Text = DT2.Rows[0]["IDCliente"].ToString();
                                TxbNombreCliente.Text = DT2.Rows[0]["Nombre"].ToString();
                                TxbApellidoCliente.Text = DT2.Rows[0]["Apellido"].ToString();
                                TxbTipoDocumento.Text = DT2.Rows[0]["TipoDocumento"].ToString();
                                TxbDocumentoCliente.Text = DT2.Rows[0]["Documento"].ToString();

                                /* Llenar Campos de Membresia */
                                TxbIDMembresia.Text = DT2.Rows[0]["IDMembresia"].ToString();
                                TxbNombreMembresia.Text = DT2.Rows[0]["NombreMembresia"].ToString();
                                TxbDescrMembresia.Text = DT2.Rows[0]["Descripcion"].ToString();
                                TxbValorMembresia.Text = Convert.ToDecimal(DT2.Rows[0]["Valor"]).ToString("0.00");

                                /* Llenar Campos de CargoDebito */
                                TxbIDCargoDebito.Text = DT2.Rows[0]["IDCargoDebito"].ToString();
                                TxbCargoDebito.Text = DT2.Rows[0]["CargoDebito"].ToString();
                                TxbMontoDebito.Text = Convert.ToDecimal(DT2.Rows[0]["MontoDebito"]).ToString("0.00");
                                TxbFechaCargoDebito.Text = DT2.Rows[0]["FechaCargoDebito"].ToString();
                                TxbEstatusDebito.Text = DT2.Rows[0]["EstatusDebito"].ToString();


                                decimal MontoDebito = decimal.Parse(TxbMontoDebito.Text);
                                decimal ValorMembresia = decimal.Parse(TxbValorMembresia.Text);

                                TxbFacturaValor.Text = Convert.ToDecimal((ValorMembresia + MontoDebito)).ToString("0.00");

                            }

                            else
                            {
                                MessageBox.Show("Cliente no Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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

        private void LimpiarCargos()
        {
            TxbIDCargoCredito.Clear();
            TxbCargoCredito.Clear();
            TxbMontoCredito.Clear();
            TxbFechaCargoCredito.Clear();
            TxbEstatusCredito.Clear();

            TxbIDCargoDebito.Clear();
            TxbCargoDebito.Clear();
            TxbMontoDebito.Clear();
            TxbFechaCargoDebito.Clear();
            TxbEstatusDebito.Clear();
        }
        private void nuevaFacturaMembresia_Load(object sender, EventArgs e)
        {
            TxbIDUsuario.Text = gestioUsuarioEntities.IDUserLogged;
            TxbNombreApellidoUsuario.Text = gestioUsuarioEntities.usernameLogged;

            TxbFacturaNCF.Text = "B0100000005";
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
            string CampoObligatorio = "¡Debe Llenar este Campo!";
            if (string.IsNullOrEmpty(TxbMontoRecibido.Text))
            {
                errorProvider.SetError(TxbMontoRecibido, CampoObligatorio);
                validacion = false;
            }
            decimal MontoRecibido = decimal.Parse(TxbMontoRecibido.Text);
            if (!decimal.TryParse(TxbMontoRecibido.Text, out MontoRecibido))
            {
                errorProvider.SetError(TxbMontoRecibido, CampoObligatorio);
                validacion = false;
            }

            if (string.IsNullOrEmpty(TxbDevuelta.Text))
            {
                errorProvider.SetError(TxbDevuelta, CampoObligatorio);
                validacion = false;
            }
            decimal Devuelta = decimal.Parse(TxbDevuelta.Text);
            if (!decimal.TryParse(TxbDevuelta.Text, out Devuelta))
            {
                errorProvider.SetError(TxbDevuelta, CampoObligatorio);
                validacion = false;
            }

            if (cbMetodoPago.SelectedIndex == -1)
            {
                errorProvider.SetError(cbMetodoPago, CampoObligatorio);
                validacion = false;
            }

            return validacion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Guarda si Tiene Cargo Credito y Cargo Debito */
            if (rbtnSiTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
            {
                if (!ValidarCampos())
                {

                    return;
                }

                PagoEntity nuevoPago = new PagoEntity();
                PagoBLL pagoBLL = new PagoBLL();
                FacturaMembresiaEntity nuevaFacturaMembresia = new FacturaMembresiaEntity();
                FacturaMembresiaBLL facturaMembresiaBLL = new FacturaMembresiaBLL();

                nuevaFacturaMembresia.IDMembresia = Convert.ToInt32(TxbIDMembresia.Text);
                nuevaFacturaMembresia.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
                nuevaFacturaMembresia.IDUsuario = Convert.ToInt32(TxbIDUsuario.Text);
                nuevaFacturaMembresia.CargoCredito = Convert.ToInt32(TxbIDCargoCredito.Text);
                nuevaFacturaMembresia.CargoDebito = Convert.ToInt32(TxbIDCargoDebito.Text);
                nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
                nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
                nuevaFacturaMembresia.FechaEmision = DateTime.Now;
                nuevaFacturaMembresia.FechaVencimiento = DateTime.Now.AddDays(30);
                nuevaFacturaMembresia.Estatus = "Pagado";

                nuevoPago.MetodoPago = cbMetodoPago.SelectedItem.ToString();
                nuevoPago.Monto = decimal.Parse(TxbFacturaValor.Text);
                nuevoPago.Pagado = decimal.Parse(TxbMontoRecibido.Text);
                nuevoPago.Devuelta = decimal.Parse(TxbDevuelta.Text);
                nuevoPago.FechaPago = DateTime.Now;
                nuevoPago.Estatus = "Pagado";


                try
                {
                    facturaMembresiaBLL.Insertar(nuevaFacturaMembresia);
                    MessageBox.Show("¡Factura de Membresia Guardada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodosLosCampos();
                    LimpiarCargos();
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
            if (rbtnSiTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
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
                nuevaFacturaMembresia.CargoCredito = Convert.ToInt32(TxbIDCargoCredito.Text);
                nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
                nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
                nuevaFacturaMembresia.FechaEmision = DateTime.Now;
                nuevaFacturaMembresia.FechaVencimiento = DateTime.Now.AddDays(30);
                nuevaFacturaMembresia.Estatus = "Pagado";

                try
                {
                    facturaMembresiaBLL.InsertarSoloCargoCredito(nuevaFacturaMembresia);
                    MessageBox.Show("¡Factura de Membresia Guardada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodosLosCampos();
                    LimpiarCargos();
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
            if (rbtnNoTieneCargoCredito.Checked && rbtnSiTieneCargoDebito.Checked)
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
                nuevaFacturaMembresia.CargoDebito = Convert.ToInt32(TxbIDCargoDebito.Text);
                nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
                nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
                nuevaFacturaMembresia.FechaEmision = DateTime.Now;
                nuevaFacturaMembresia.FechaVencimiento = DateTime.Now.AddDays(30);
                nuevaFacturaMembresia.Estatus = "Pagado";

                try
                {
                    facturaMembresiaBLL.InsertarSoloCargoDebito(nuevaFacturaMembresia);
                    MessageBox.Show("¡Factura de Membresia Guardada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTodosLosCampos();
                    LimpiarCargos();
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
            if (rbtnNoTieneCargoCredito.Checked && rbtnNoTieneCargoDebito.Checked)
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
                nuevaFacturaMembresia.NCF = TxbFacturaNCF.Text;
                nuevaFacturaMembresia.ValorFactura = Convert.ToDecimal(TxbFacturaValor.Text);
                nuevaFacturaMembresia.FechaEmision = DateTime.Now;
                nuevaFacturaMembresia.FechaVencimiento = DateTime.Now.AddDays(30);
                nuevaFacturaMembresia.Estatus = "Pagado";

                try
                {
                    facturaMembresiaBLL.InsertarSinCargos(nuevaFacturaMembresia);
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

            TxbFacturaValor.Clear();

            TxbIDGrupoCliente.Clear();
            TxbNombreGrupoMembresia.Clear();
            TxbMontoGrupoCliente.Clear();
            TxbMontoTotalGrupo.Clear();
            TxbFechaRegistroGrupo.Clear();
            TxbEstatus.Clear();
        }

        private void btnCargoCredito_Click(object sender, EventArgs e)
        {
            nuevoCargoCredito newCargoCredito = new nuevoCargoCredito();
            newCargoCredito.Show();
        }

        private void btnCargosDebito_Click(object sender, EventArgs e)
        {
            nuevoCargoDebito newCargoDebito = new nuevoCargoDebito();
            newCargoDebito.Show();
        }

        private void TxbMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularDevuelta();
        }
        private void CalcularDevuelta()
        {
            if (decimal.TryParse(TxbFacturaValor.Text, out decimal MontoTotal) &&
                decimal.TryParse(TxbMontoRecibido.Text, out decimal MontoRecibido))
            {
                decimal devuelta = MontoRecibido - MontoTotal;

                if (devuelta >= 0)
                {
                    TxbDevuelta.Text = devuelta.ToString("N2");
                }
                else
                {
                    TxbDevuelta.Text = "0.00";
                }

            }
            else
            {
                TxbDevuelta.Text = "0.00";
            }
        }
    }
}