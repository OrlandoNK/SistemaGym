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
using static Guna.UI2.Native.WinApi;

namespace SistemaGym.UI.Windows
{
    public partial class MantenimientoProveedores : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";

        public MantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
            dgvProveedores.AutoGenerateColumns = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedoresBLL proveedoresBLL = new ProveedoresBLL();

            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Proveedor?", "¿Eliminar Proveedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value);

                    bool seElimino = ProveedoresBLL.Eliminar(idProveedor);


                    if (seElimino)
                    {
                        dgvProveedores.Rows.RemoveAt(dgvProveedores.SelectedRows[0].Index);
                        MessageBox.Show("¡Proveedor Eliminado Satisfactoriamente!", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Proveedor", "Error al Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dialogResult == DialogResult.No)
                {

                }

            }
        }
    }
}
