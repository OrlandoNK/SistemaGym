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
    public partial class registrarProveedores : Form
    {
        public registrarProveedores()
        {
            InitializeComponent();
        }

        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        ProveedoresBLL proveedoresBLL = new ProveedoresBLL();


        private bool ValidarDatos()
        {
            string CampoObligatorio = "Este Campo es Obligatorio";
            bool resultado = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(TxbNombreProveedor.Text))
            {
                errorProvider.SetError(TxbNombreProveedor, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(TxbDireccionProveedor.Text))
            {
                errorProvider.SetError(TxbDireccionProveedor, CampoObligatorio);
                resultado = false;
            }

            if (string.IsNullOrEmpty(mskbxTellProveedor.Text))
            {
                errorProvider.SetError(mskbxTellProveedor, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txbCorreo.Text))
            {
                errorProvider.SetError(txbCorreo, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txbRNC.Text))
            {
                errorProvider.SetError(txbRNC, CampoObligatorio);
                resultado = false;
            }

            return resultado;
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;

            }

            ProveedoresEntity oProveedor = new ProveedoresEntity();
            oProveedor.Nombre = TxbNombreProveedor.Text;
            oProveedor.Telefono = mskbxTellProveedor.Text;
            oProveedor.Correo = txbCorreo.Text;
            oProveedor.RNC = txbRNC.Text;
            oProveedor.FechaRegistro = DateTime.Now;
            oProveedor.Direccion = TxbDireccionProveedor.Text;
            oProveedor.Estatus = "Activo";

            try
            {
                ProveedoresBLL.Guardar(oProveedor);
                MessageBox.Show("Proveedor Guardado Satisfactoriamente", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un error al intentar Guardar el Proveedor. \nMas Detalles a continuación\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al intentar Guardar el Proveedor. \nMas Detalles a continuación\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            TxbNombreProveedor.Clear();
            TxbDireccionProveedor.Clear();
            mskbxTellProveedor.Clear();
            txbCorreo.Clear();
            txbRNC.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
