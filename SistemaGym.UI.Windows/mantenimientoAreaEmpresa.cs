using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class mantenimientoAreaEmpresa : Form
    {
        private AreaEmpresaBLL areaEmpresaBLL = new AreaEmpresaBLL();
        private string SISTEMA_GYM = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        public mantenimientoAreaEmpresa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarAreaEmpresa nuevaAreaEmpresa = new registrarAreaEmpresa();
            nuevaAreaEmpresa.Show();
        }
        private void CargarEncargado()
        {
            var colEncargado = (DataGridViewComboBoxColumn)dgvAreaEmpresa.Columns["Encargado"];

            colEncargado.ValueMember = "IDEmpleado";
            colEncargado.DisplayMember = "Nombre";
            colEncargado.DataPropertyName = "Encargado";
            colEncargado.DataSource = EmpleadoBLL.GetEmpleados();
        }

        private void mantenimientoAreaEmpresa_Load(object sender, EventArgs e)
        {
            AreaEmpresaBLL areaEmpresaBLL = new AreaEmpresaBLL();
            dgvAreaEmpresa.DataSource = areaEmpresaBLL.Mostrar();
            dgvAreaEmpresa.AutoGenerateColumns = false;
            CargarEncargado();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable changeData = ((DataTable)dgvAreaEmpresa.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<AreaEmpresaEntity> areaEmpresaActualizar = ConvertirDatatableALista(changeData);

                    foreach (AreaEmpresaEntity areasgym in areaEmpresaActualizar)
                    {
                        areaEmpresaBLL.Actualizar(areasgym);
                    }

                    MessageBox.Show("¡El Area de Empresa ha sido Modificada de Manera Satisfactoria!", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAreaEmpresa.DataSource = areaEmpresaBLL.Mostrar();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar. \nDetalles A Continuacion:\n {ex.Message}", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<AreaEmpresaEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<AreaEmpresaEntity> areasEmpresaList = new List<AreaEmpresaEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                AreaEmpresaEntity areasgym = new AreaEmpresaEntity
                {
                    IDArea = Convert.ToInt32(fila["IDArea"]),
                    Encargado = Convert.ToInt32(fila["Encargado"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Descripcion = Convert.ToString(fila["Descripcion"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                };

                areasEmpresaList.Add(areasgym);
            }

            return areasEmpresaList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAreaEmpresa.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar esta Area de Empresa?", SISTEMA_GYM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idAreaGym = Convert.ToInt32(dgvAreaEmpresa.SelectedRows[0].Cells["IDArea"].Value);

                        bool seElimino = areaEmpresaBLL.Eliminar(idAreaGym);


                        if (seElimino)
                        {
                            dgvAreaEmpresa.Rows.RemoveAt(dgvAreaEmpresa.SelectedRows[0].Index);
                            MessageBox.Show("¡El Area de Empresa ha sido Eliminada Satisfactoriamente!", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvAreaEmpresa.DataSource = areaEmpresaBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Area de Empresa", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Area de Empresa. \nDetalles a Continuacion:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Area de Empresa. \nDetalles a Continuacion:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbSearchBar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbSearchBar.Text;

            DataTable resultBusqueda = AreaEmpresaBLL.Buscar(buscar);
            dgvAreaEmpresa.DataSource = resultBusqueda;
        }
    }
}
