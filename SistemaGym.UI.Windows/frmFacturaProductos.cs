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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGym.UI.Windows
{
    public partial class frmFacturaProductos : Form
    {
        PagoEntity Pago = new PagoEntity();
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
            txtMontoTotal.Text = 0.ToString("N2");
            txtMontoRecibido.Text = "0";
            txtDevuelta.Text = "0";
            cbMetodoPago.Text = Convert.ToString(cbMetodoPago.SelectedItem);
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

        private void CalcularDevuelta()
        {
            if (decimal.TryParse(txtMontoTotal.Text, out decimal MontoTotal) &&
                decimal.TryParse(txtMontoRecibido.Text, out decimal MontoRecibido))
            {
                decimal devuelta = MontoRecibido - MontoTotal;

                if (devuelta >= 0)
                {
                    txtDevuelta.Text = devuelta.ToString("N2");
                }
                else
                {
                    txtDevuelta.Text = "0.00";
                }

            }
            else
            {
                txtDevuelta.Text = "0.00";
            }
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
            txtMontoTotal.Text = txtTotal.SelectedText;
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
            txtMontoTotal.Text = oFactura.Total.ToString();
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

            Pago.MetodoPago = cbMetodoPago.Text;
            Pago.Monto = decimal.Parse(txtTotal.Text);
            Pago.Pagado = decimal.Parse(txtMontoRecibido.Text);
            Pago.Devuelta = decimal.Parse(txtDevuelta.Text);
            Pago.FechaPago = DateTime.Now;
            Pago.Estatus = "Pagado";
            oFactura.Pagos.Add(Pago);
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
            decimal montorecibido;
            if (decimal.TryParse(txtMontoRecibido.Text, out montorecibido))
            {
                if (montorecibido <= 0)
                {
                    errorProvider.SetError(txtMontoRecibido, "Introduzca un monto mayor que cero");
                    resultado = false;
                }
      
            }
            else
            {
                errorProvider.SetError(txtMontoRecibido, "Introduzca un monto válido");
                resultado = false;
            }
            decimal montore;
            decimal montottal;

            if (decimal.TryParse(txtMontoRecibido.Text, out montore) && decimal.TryParse(txtMontoTotal.Text, out montottal))
            {
                if (montore < montottal)
                {
                    errorProvider.SetError(txtMontoRecibido, "El monto debe ser mayor o igual al monto a pagar");
                    return false;
                }
                
            }
          

            decimal devuelta = decimal.Parse(txtDevuelta.Text);
            if (devuelta < 0)
            {
                errorProvider.SetError(txtDevuelta, "Introduzca una devuelta valida");
                resultado = false;
            }
           
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtNCF, "El NCF Es Obligatorio");
                resultado = false;
            }
            return resultado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtDevuelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtMontoRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool validation = true;
            decimal MontoRecibido = decimal.Parse(txtMontoRecibido.Text);
            decimal MontoTotal = decimal.Parse(txtMontoTotal.Text);

            if (MontoRecibido > MontoTotal)
            {
                txtDevuelta.Text = Convert.ToDecimal(MontoRecibido - MontoTotal).ToString("0.00");
            }
            else if (MontoRecibido < MontoTotal)
            {
                MessageBox.Show("¡El Monto esta Incompleto para Pagar!", SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MontoRecibido == MontoTotal)
            {
                txtDevuelta.Text = "0";
            }
            if (txtMontoRecibido.Text == "0")
            {
                errorProvider.SetError(txtMontoRecibido, "¡El Monto Recibido es Obligatorio!");
                validation = false;
            }
            if (!decimal.TryParse(txtMontoRecibido.Text, out MontoRecibido))
            {
                errorProvider.SetError(txtMontoRecibido, "¡El Monto Recibido es Obligatorio!");
                validation = false;
            }
            if (txtMontoTotal.Text == "0")
            {
                errorProvider.SetError(txtMontoTotal, "¡El Monto Total es Obligatorio!");
                validation = false;
            }
            if (!decimal.TryParse(txtMontoTotal.Text, out MontoRecibido))
            {
                errorProvider.SetError(txtMontoTotal, "¡El Monto Total es Obligatorio!");
                validation = false;
            }
        }

        private void txtMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            CalcularDevuelta();
        }
    }
}
