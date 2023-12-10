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
        FacturaProductoEntity oFactura = new FacturaProductoEntity();
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
                MessageBox.Show("Por Favor Agregue el Producto", SISTEMA);
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
            txtDescuento.Text = 0.ToString("C");
            txtDocumento.Clear();
            txtImpuesto.Text = 0.ToString("C");
            txtSubTotal.Text = 0.ToString("C");
            txtTotal.Text = 0.ToString("C");
            txtProducto.Clear();
            txtCantidad.Text = 0.ToString("C");
            txtTotalDescuento.Text = 0.ToString("C");
            txtNCF.Clear();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = null;
            

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDetalle())
            {
                return;
            }
            DetalleFacturaProductoEntity detalleFactura = new DetalleFacturaProductoEntity();

            detalleFactura.IDDetalleFacturaProducto = int.Parse(txtIDProducto.Text);
            detalleFactura.IDProducto = int.Parse(txtIDProducto.Text);
            detalleFactura.Cantidad = int.Parse(txtCantidad.Text);
            detalleFactura.Precio = decimal.Parse(txtPrecio.Text);

            oFactura.Detalles.Add(detalleFactura);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = oFactura.Detalles;
            txtSubTotal.Text = oFactura.SubTotal.ToString();
            txtTotalDescuento.Text = oFactura.TotalDescuento.ToString();
            txtImpuesto.Text = oFactura.TotalItbis.ToString();
            txtTotal.Text = oFactura.Total.ToString();
            InicializarDetalles();
        }
        private void InicializarDetalles()
        {
            txtIDProducto.Text = "0";
            txtProducto.Clear();
            txtCantidad.Text = "0";
            txtPrecio.Text = "0";
            txtDescuento.Text = "0";


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
