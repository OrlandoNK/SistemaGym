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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvUsuario.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<UsuarioEntity> usuariosActualizar = ConvertirDatatableALista(changeData);

                    foreach (UsuarioEntity usuario in usuariosActualizar)
                    {
                        UsuarioBLL.Update(usuario);
                    }

                    MessageBox.Show("¡Usuario Modificado de Manera Satisfactoria!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuario.DataSource = UsuarioBLL.Mostrar();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string nombreUsuario;
        private string contrasena;
        private List<UsuarioEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<UsuarioEntity> UsuariosList = new List<UsuarioEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                UsuarioEntity usuarios = new UsuarioEntity(nombreUsuario, contrasena)
                {
                    IDUsuario = Convert.ToInt32(fila["IDUsuario"]),
                    IDRol = Convert.ToInt32(fila["IDRol"]),
                    IDEmpleado = Convert.ToInt32(fila["IDEmpleado"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Apellido = Convert.ToString(fila["Apellido"]),
                    Sexo = Convert.ToString(fila["Sexo"]),
                    Correo = Convert.ToString(fila["Correo"]),
                    Direccion = Convert.ToString(fila["Direccion"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"]),
                    NombreUsuario = Convert.ToString(fila["NombreUsuario"]),
                    Contrasena = Convert.ToString(fila["Contrasena"])
                };

                UsuariosList.Add(usuarios);
            }

            return UsuariosList;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = UsuarioBLL.BuscarUsuario(buscar);
            dgvUsuario.DataSource = resultBusqueda;
        }
    }
}
