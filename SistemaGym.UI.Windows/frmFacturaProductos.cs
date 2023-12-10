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
    public partial class frmFacturaProductos : Form
    {
        const string SISTEMA = "Sistema Gym";
        public frmFacturaProductos()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            if (frmBuscarCliente.ShowDialog() == DialogResult.OK)
            {

                ClientesEntity cliente = ClientesBLL.BuscarPorID(frmBuscarCliente.id);
                txtIDCliente.Text = cliente.IDCliente.ToString();
                txtCliente.Text = cliente.Nombre;
                txtDocumento.Text = cliente.Documento;
                txtTipoCliente.Text = cliente.TipoCliente.ToString();

            }

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario frmBuscarUsuario = new frmBuscarUsuario();
            if (frmBuscarUsuario.ShowDialog() == DialogResult.OK)
            {

                UsuarioEntity usuario = UsuarioBLL.BuscarID(frmBuscarUsuario.id);
                txtUsuario.Text = usuario.Nombre;


            }
        }
        private bool ValidarDetalle()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (txtIDProducto.Text == "0")
            {
                errorProvider.SetError(txtIDProducto, "El Nombre Es Obligatorio");
                resultado = false;
            }

            return resultado;
        }
        private void InicializarControles()
        {
            txtCliente.Clear();
            txtIDCliente.Text = "0";
            txtIDFactura.Text = "0";
            txtIDProducto.Text = "0";
            txtDescuento.Clear();
            txtDocumento.Clear();
            txtImpuesto.Text = "0";
            txtSubTotal.Text = "0";
            txtTotal.Text = "0";
            txtProducto.Clear();
            txtTotalDescuento.Text = "0";
            txtNCF.Clear();

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos();
            if (frmBuscarProductos.ShowDialog() == DialogResult.OK)
            {

                ProductoEntity producto = ProductoBLL.searchById(frmBuscarProductos.id);
                txtIDProducto.Text = producto.IDProducto.ToString();
                txtProducto.Text = producto.Nombre;
                txtPrecio.Text = Convert.ToDecimal(producto.PrecioUnitario).ToString();


            }
        }

        private void frmFacturaProductos_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
