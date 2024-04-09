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
    }
}
