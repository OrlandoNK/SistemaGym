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
using System.Windows.Forms.VisualStyles;

namespace SistemaGym.UI.Windows
{
    public partial class registrarGrupoClientes : Form
    {
        public registrarGrupoClientes()
        {
            InitializeComponent();
        }
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
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

                        txbMontoGrupoCliente.Text = Convert.ToDecimal(DT.Rows[0]["Valor"]).ToString("0.00");

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

        private void registrarGrupoClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarGrupoMembresia_Click(object sender, EventArgs e)
        {
            listaGrupoMembresia listaGrupoMembresias = new listaGrupoMembresia();

            if (listaGrupoMembresias.ShowDialog() == DialogResult.OK)
            {
                GrupoMembresiaEntity oGrupoMembresia = GrupoMembresiaBLL.GetByID((int)listaGrupoMembresias.IdGrupoMembresia);

                if (oGrupoMembresia != null)
                {
                    this.txbIdGrupoMembresia.Text = oGrupoMembresia.IDGrupoMembresia.ToString();
                    this.txbNombreGrupoMembresia.Text = oGrupoMembresia.Nombre.ToString();
                    this.txbMontoTotalGrupoMembresia.Text = Convert.ToDecimal(oGrupoMembresia.MontoTotal).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Grupo de Membresia No Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            ErrorProvider.Clear();
            bool validation = true;

            string GrupoMembresiaObligatorio = "Debe de Agregar el Grupo de Membresia";
            string ClienteObligatorio = "Debe de Agregar el Cliente";
            string MembresiaObligatoria = "Debe de Agregar la Membresia";

            if (string.IsNullOrEmpty(txbIdGrupoMembresia.Text))
            {
                ErrorProvider.SetError(txbIdGrupoMembresia, GrupoMembresiaObligatorio);
                validation = false;
            }
            int IDGrupoMembresia;
            if (!int.TryParse(txbIdGrupoMembresia.Text, out IDGrupoMembresia))
            {
                ErrorProvider.SetError(txbIdGrupoMembresia, GrupoMembresiaObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(txbNombreGrupoMembresia.Text))
            {
                ErrorProvider.SetError(txbNombreGrupoMembresia, GrupoMembresiaObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(txbMontoTotalGrupoMembresia.Text))
            {
                ErrorProvider.SetError(txbMontoTotalGrupoMembresia, GrupoMembresiaObligatorio);
                validation = false;
            }
            decimal MontoTotalGrupoMembresia;
            if (!decimal.TryParse(txbMontoTotalGrupoMembresia.Text, out MontoTotalGrupoMembresia))
            {
                ErrorProvider.SetError(txbMontoTotalGrupoMembresia, GrupoMembresiaObligatorio);
                validation = false;
            }

            if (string.IsNullOrEmpty(TxbIDCliente.Text))
            {
                ErrorProvider.SetError(TxbIDCliente, ClienteObligatorio);
                validation = false;
            }
            int IDCliente;
            if (!int.TryParse(TxbIDCliente.Text, out IDCliente))
            {
                ErrorProvider.SetError(TxbIDCliente, ClienteObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbNombreCliente.Text))
            {
                ErrorProvider.SetError(TxbNombreCliente, ClienteObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbApellidoCliente.Text))
            {
                ErrorProvider.SetError(TxbApellidoCliente, ClienteObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbTipoDocumento.Text))
            {
                ErrorProvider.SetError(TxbTipoDocumento, ClienteObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbDocumentoCliente.Text))
            {
                ErrorProvider.SetError(TxbDocumentoCliente, ClienteObligatorio);
                validation = false;
            }


            if (string.IsNullOrEmpty(TxbIDMembresia.Text))
            {
                ErrorProvider.SetError(TxbIDMembresia, MembresiaObligatoria);
                validation = false;
            }
            int IDMembresia;
            if (!int.TryParse(TxbIDMembresia.Text, out IDMembresia))
            {
                ErrorProvider.SetError(TxbIDMembresia, MembresiaObligatoria);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbNombreMembresia.Text))
            {
                ErrorProvider.SetError(TxbNombreMembresia, MembresiaObligatoria);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbDescrMembresia.Text))
            {
                ErrorProvider.SetError(TxbDescrMembresia, MembresiaObligatoria);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbValorMembresia.Text))
            {
                ErrorProvider.SetError(TxbValorMembresia, MembresiaObligatoria);
                validation = false;
            }
            decimal ValorMembresia;
            if (!decimal.TryParse(TxbValorMembresia.Text, out ValorMembresia))
            {
                ErrorProvider.SetError(TxbValorMembresia, MembresiaObligatoria);
                validation = false;
            }

            return validation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {

                return;
            }

            GrupoClienteEntity nuevoGrupoCliente = new GrupoClienteEntity();
            GrupoClienteBLL grupoClienteBLL = new GrupoClienteBLL();

            nuevoGrupoCliente.IDGrupoMembresia = Convert.ToInt32(txbIdGrupoMembresia.Text);
            nuevoGrupoCliente.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
            nuevoGrupoCliente.Monto = Convert.ToDecimal(txbMontoGrupoCliente.Text);
            nuevoGrupoCliente.FechaRegistro = DateTime.Now;
            nuevoGrupoCliente.Estatus = "Activo";

            try
            {
                GrupoClienteBLL.Insertar(nuevoGrupoCliente);
                MessageBox.Show("¡El Grupo de Cliente ha sido Guardado de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Grupo de Clientes:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Grupo de Clientes:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarCampos()
        {
            txbIdGrupoMembresia.Clear();
            txbNombreGrupoMembresia.Clear();
            txbMontoTotalGrupoMembresia.Clear();

            TxbIDCliente.Clear();
            TxbNombreCliente.Clear();
            TxbApellidoCliente.Clear();
            TxbTipoDocumento.Clear();
            TxbDocumentoCliente.Clear();

            TxbIDMembresia.Clear();
            TxbNombreMembresia.Clear();
            TxbValorMembresia.Clear();
            TxbDescrMembresia.Clear();

            txbMontoGrupoCliente.Clear();
        }

    }
}

