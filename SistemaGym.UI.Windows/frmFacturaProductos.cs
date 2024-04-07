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
using static Guna.UI2.Native.WinApi;

namespace SistemaGym.UI.Windows
{
    public partial class frmFacturaProductos : Form
    {
        FacturaProductoEntity oFactura = new FacturaProductoEntity();
        const string SISTEMA = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
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
                cbTipoCliente.ValueMember = "IDTipoCliente";
                cbTipoCliente.DisplayMember = "Nombre";
                cbTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();

            }

        }
        private bool ValidarDetalle()
        {
            bool resultado = true;
            string CampoNegativoError = "¡Este Campo No Puede Ser Negativo!";
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (txtIDProducto.Text == "0")
            {
                MessageBox.Show("Por Favor Agregue el Producto", SISTEMA);
                resultado = false;
            }
            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            if (Cantidad < 0)
            {
                errorProvider.SetError(txtCantidad, CampoNegativoError);
                resultado = false;
            }
            Decimal Descuento = Convert.ToDecimal(txtDescuento.Text);
            if (Descuento < 0)
            {
                errorProvider.SetError(txtDescuento, CampoNegativoError);
                resultado = false;
            }
            if (txtCantidad.Text == "0")
            {
                MessageBox.Show("Por Favor Agregue La Cantidad", SISTEMA);
                resultado = false;
            }
            else if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                errorProvider.SetError(txtCantidad, "La Cantidad Es Obligatoria");
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
            txtDescuento.Text = 0.ToString("N2");
            txtDocumento.Clear();
            txtImpuesto.Text = 0.ToString("N2");
            txtSubTotal.Text = 0.ToString("N2");
            txtTotal.Text = 0.ToString("N2");
            txtProducto.Clear();
            txtCantidad.Text = "0";
            txtTotalDescuento.Text = 0.ToString("N2");
            txtNCF.Text = "B0100000005";
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
            txtIDUsuario.Text = gestioUsuarioEntities.IDUserLogged;
            txtUsuario.Text = gestioUsuarioEntities.usernameLogged;
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
            detalleFactura.Descuento = decimal.Parse(txtDescuento.Text);
            oFactura.Detalles.Add(detalleFactura);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = oFactura.Detalles;
            txtSubTotal.Text = oFactura.SubTotal.ToString("N2");
            if (txtTotalDescuento.Text == "0")
            {
                txtTotalDescuento.Text = 0.ToString("N2");
            }
            txtTotalDescuento.Text = oFactura.TotalDescuento.ToString();
            txtImpuesto.Text = oFactura.TotalItbis.ToString();
            txtTotal.Text = oFactura.Total.ToString();
            InicializarDetalles();
            CargarProducto();
        }
        private void InicializarDetalles()
        {
            txtIDProducto.Text = "0";
            txtProducto.Clear();
            txtCantidad.Text = "0";
            txtPrecio.Text = 0.ToString("N2");
        }
        public void CargarProducto()
        {
            var colProducto = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDProducto"];
            colProducto.DataSource = ProductoBLL.GetAll();
            colProducto.ValueMember = "IDProducto";
            colProducto.DisplayMember = "Nombre";
            colProducto.DataPropertyName = "IDProducto";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFactura())
            {
                return;
            }
            oFactura.IDCliente = int.Parse(txtIDCliente.Text);
            oFactura.IDUsuario = int.Parse(txtIDUsuario.Text);
            oFactura.Estatus = "Activo";
            oFactura.FechaEmision = DateTime.Now;
            oFactura.FechaVencimiento = DateTime.Parse(dtpFechaVencimiento.Text);
            oFactura.NCF = txtNCF.Text;
            try
            {
                FacturacionProductoBLL.Guardar(oFactura);
                MessageBox.Show("¡Factura Guardada de Manera Satisfactoria!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ValidarFactura()
        {

            bool resultado = true;
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                errorProvider.SetError(txtCliente, "El Cliente Es Obligatorio");
                btnBuscarCliente.Focus();
                resultado = false;
            }
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Por Favor Agregue el Producto", SISTEMA);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtNCF.Text))
            {
                errorProvider.SetError(txtNCF, "El NCF Es Obligatorio");
                resultado = false;
            }
            /*
            int cant = txtCantidad.Text;
            if (string.IsNullOrEmpty(txtCantidad.Text) ||  <= 0)
            {
                errorProvider.SetError(txtNCF, "El NCF Es Obligatorio");
                resultado = false;
            }
            */
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtNCF, "El Usuario Es Obligatorio");
                resultado = false;
            }
            return resultado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
