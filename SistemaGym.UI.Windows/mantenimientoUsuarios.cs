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
    public partial class mantenimientoUsuarios : Form
    {
        public mantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private string sistema = "Sistema Gestion Gimnasio (COMFORT GYM) dice";

        private void mantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = UsuarioBLL.Mostrar();
            dgvUsuario.AutoGenerateColumns = false;
            CargarRol();
            CargarIDEmpleado();
        }

        private void CargarRol()
        {
            var colRol = (DataGridViewComboBoxColumn)dgvUsuario.Columns["Rol"];
            colRol.ValueMember = "IDRol";
            colRol.DisplayMember = "Nombre";
            colRol.DataPropertyName = "IDRol";
            colRol.DataSource = RolBLL.MostrarRol();
        }
        private void CargarIDEmpleado()
        {
            var colRol = (DataGridViewComboBoxColumn)dgvUsuario.Columns["IDEmpleado"];
            colRol.ValueMember = "IDEmpleado";
            colRol.DisplayMember = "Documento";
            colRol.DataPropertyName = "IDEmpleado";
            colRol.DataSource = EmpleadoBLL.GetEmpleados();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Usuario?", "¿Eliminar Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idUsuario = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells["IDUsuario"].Value);



                        bool seElimino = UsuarioBLL.Eliminar(idUsuario);


                        if (seElimino)
                        {
                            dgvUsuario.Rows.RemoveAt(dgvUsuario.SelectedRows[0].Index);
                            MessageBox.Show("¡Usuario Eliminado Satisfactoriamente!", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvUsuario.DataSource = UsuarioBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Usuario", "Error al Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Usuario. \nDetalles a Continuacion:\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Usuario. \nDetalles a Continuacion:\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUsuario registrarUsuario = new frmUsuario();
            registrarUsuario.Show();
        }
    }
}
