using SistemaGym.BLL;
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
                        TxbValorMembresia.Text = DT.Rows[0]["Valor"].ToString();

                        txbMontoGrupoCliente.Text = DT.Rows[0]["Valor"].ToString();

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
    }
}
