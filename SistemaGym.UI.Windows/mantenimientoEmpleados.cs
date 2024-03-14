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
    public partial class mantenimientoEmpleados : Form
    {
        public mantenimientoEmpleados()
        {
            InitializeComponent();
        }

        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarEmpleados nuevoEmpleado = new registrarEmpleados();
            nuevoEmpleado.Show();
        }

        private void mantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvEmpleados.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<EmpleadoEntity> empleadosActualizar = ConvertirDatatableALista(changeData);

                    foreach (EmpleadoEntity empleado in empleadosActualizar)
                    {
                        EmpleadoBLL.Update(empleado);
                    }

                    MessageBox.Show("¡Empleado Modificado de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<EmpleadoEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<EmpleadoEntity> empleadosList = new List<EmpleadoEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                EmpleadoEntity empleados = new EmpleadoEntity
                {
                    IDEmpleado = Convert.ToInt32(fila["IDEmpleado"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Apellido = Convert.ToString(fila["Apellido"]),
                    TipoDocumento = Convert.ToString(fila["TipoDocumento"]),
                    Documento = Convert.ToString(fila["Documento"]),
                    Direccion = Convert.ToString(fila["Direccion"]),
                    TellCell = Convert.ToString(fila["TellCell"]),
                    TelRes = Convert.ToString(fila["TellRes"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                empleadosList.Add(empleados);
            }

            return empleadosList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmpleadoBLL empleadoBLL = new EmpleadoBLL();

            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Empleado?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvEmpleados.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvEmpleados.SelectedRows[0];
                        int deleteEmpleado = Convert.ToInt32(selectRow.Cells["IDEmpleado"].Value);
                        bool resultado = empleadoBLL.Delete(deleteEmpleado);

                        if (resultado)
                        {
                            MessageBox.Show("¡Empleado Eliminado con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar el Empleado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Empleado. \n\nDetalles a continuación:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Empleado. \n\nDetalles a continuación:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
