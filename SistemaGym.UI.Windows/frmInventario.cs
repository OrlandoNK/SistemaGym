using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //datos de control al objeto
            InventarioEntity inventario = new InventarioEntity();
            inventario.NombreItems = textNombreItems.Text;
            inventario.Descripcion = textDescripcion.Text;
            inventario.Categoria = textCategoria.Text;
            inventario.Ubicacion = textUbicacion.Text;
            inventario.Cantidad = Cantidad.Index;
            inventario.EstatusItems = cmbxEstatus.Text;

            

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
