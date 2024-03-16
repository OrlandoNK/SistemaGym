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
    public partial class mantenimientoCategorias : Form
    {
        public mantenimientoCategorias()
        {
            InitializeComponent();
        }

        private string SISTEMA_GYM = "Sistema Gestion Gimnasio (CONFORT GYM) dice";

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCategoria nuevaCategoria = new frmCategoria();
            nuevaCategoria.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mantenimientoCategorias_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            dgvCategoria.AutoGenerateColumns = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            dgvCategoria.AutoGenerateColumns = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvCategoria.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<CategoriaProductoEntity> categoriaActualizar = ConvertirDatatableALista(changeData);

                    foreach (CategoriaProductoEntity categoria in categoriaActualizar)
                    {
                        CategoriaProductoBLL.Actualizar(categoria);
                    }

                    MessageBox.Show("¡Categoria Modificada de Manera Satisfactoria!", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCategoria.DataSource = CategoriaProductoBLL.Mostrar();
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
        private List<CategoriaProductoEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<CategoriaProductoEntity> CategoriaList = new List<CategoriaProductoEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                CategoriaProductoEntity categoria = new CategoriaProductoEntity
                {
                    IDCategoria = Convert.ToInt32(fila["IDCategoria"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Descripcion = Convert.ToString(fila["Descripcion"])
                };

                CategoriaList.Add(categoria);
            }

            return CategoriaList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar esta Categoria?", SISTEMA_GYM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int idUsuario = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells["IDCategoria"].Value);



                        bool seElimino = CategoriaProductoBLL.Eliminar(idUsuario);


                        if (seElimino)
                        {
                            dgvCategoria.Rows.RemoveAt(dgvCategoria.SelectedRows[0].Index);
                            MessageBox.Show("¡Categoria Eliminada Satisfactoriamente!", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvCategoria.DataSource = CategoriaProductoBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Se Produjo un Error al Intentar Eliminar la Categoria", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar la Categoria. \nDetalles a Continuacion:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Produjo un Error al Intentar Eliminar la Categoria. \nDetalles a Continuacion:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
