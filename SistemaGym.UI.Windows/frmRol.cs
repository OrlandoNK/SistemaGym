﻿using SistemaGym.BLL;
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
    public partial class frmRol : Form
    {
        const string sistema = "Sistema Gestión Gimnasio (COMFORT GYM) dice:";
        public frmRol()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            dgvRol.DataSource = RolBLL.MostrarRol();
            dgvRol.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvRol.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<RolEntity> rolesEntities = ConvertirDatatableALista(changeData);

                    foreach (RolEntity oRoles in rolesEntities)
                    {
                        RolBLL.ActualizarRol(oRoles);
                    }

                    MessageBox.Show("¡Se Ha Modificado el Rol Correctamente!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRol.DataSource = RolBLL.MostrarRol();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Rol: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Rol: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<RolEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<RolEntity> RolList = new List<RolEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                RolEntity roles = new RolEntity
                {
                    IDRol = Convert.ToInt32(fila["IDRol"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Descripcion = Convert.ToString(fila["Descripcion"])
                };

                RolList.Add(roles);
            }
            return RolList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Rol?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvRol.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvRol.SelectedRows[0];
                    int deleteRol = Convert.ToInt32(selectRow.Cells["IDRol"].Value);
                    bool deleteProcess = RolBLL.EliminarRol(deleteRol);

                    if (deleteProcess)
                    {
                        MessageBox.Show("¡Rol Eliminado con Exito!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvRol.DataSource = RolBLL.MostrarRol();
                    }
                    else
                    {
                        MessageBox.Show("Error al Tratar de Eliminar el Rol", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = RolBLL.ObtenerByValor(buscar);
            dgvRol.DataSource = resultBusqueda;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarRol nuevoRol = new registrarRol();
            nuevoRol.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRol.DataSource = RolBLL.MostrarRol();
            dgvRol.AutoGenerateColumns = false;
        }
    }
}
