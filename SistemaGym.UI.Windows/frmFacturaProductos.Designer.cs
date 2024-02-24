namespace SistemaGym.UI.Windows
{
    partial class frmFacturaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpFechaEmision = new DateTimePicker();
            dtpFechaVencimiento = new DateTimePicker();
            label3 = new Label();
            txtIDUsuario = new TextBox();
            label20 = new Label();
            cbEstatus = new ComboBox();
            txtNCF = new TextBox();
            label19 = new Label();
            label18 = new Label();
            btnBuscarUsuario = new Button();
            txtIDFactura = new TextBox();
            txtUsuario = new TextBox();
            dgvProductos = new DataGridView();
            IDDetalle = new DataGridViewTextBoxColumn();
            IDProducto = new DataGridViewComboBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnAgregar = new Button();
            btnBuscarProducto = new Button();
            label13 = new Label();
            txtDescuento = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            txtIDProducto = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtSubTotal = new TextBox();
            txtImpuesto = new TextBox();
            txtTotalDescuento = new TextBox();
            txtTotal = new TextBox();
            errorProvider = new ErrorProvider(components);
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tabDetalleFactura = new TabPage();
            tabClientData = new TabPage();
            label2 = new Label();
            label6 = new Label();
            txtTipoCliente = new TextBox();
            txtCliente = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtIDCliente = new TextBox();
            txtDocumento = new TextBox();
            btnBuscarCliente = new Button();
            tabControl1 = new TabControl();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabDetalleFactura.SuspendLayout();
            tabClientData.SuspendLayout();
            tabControl1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 26);
            label1.TabIndex = 0;
            label1.Text = "ID Factura";
            // 
            // label4
            // 
            label4.Location = new Point(42, 114);
            label4.Name = "label4";
            label4.Size = new Size(256, 23);
            label4.TabIndex = 3;
            label4.Text = "Fecha Emision";
            // 
            // label5
            // 
            label5.Location = new Point(304, 114);
            label5.Name = "label5";
            label5.Size = new Size(261, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha Vencimiento";
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Location = new Point(42, 142);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(256, 23);
            dtpFechaEmision.TabIndex = 6;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(304, 142);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(261, 23);
            dtpFechaVencimiento.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(212, 41);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(127, 72);
            txtIDUsuario.Multiline = true;
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(79, 28);
            txtIDUsuario.TabIndex = 21;
            // 
            // label20
            // 
            label20.Location = new Point(127, 41);
            label20.Name = "label20";
            label20.Size = new Size(79, 26);
            label20.TabIndex = 20;
            label20.Text = "IDUsuario";
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo", "En Proceso" });
            cbEstatus.Location = new Point(42, 214);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(171, 25);
            cbEstatus.TabIndex = 19;
            // 
            // txtNCF
            // 
            txtNCF.Location = new Point(419, 72);
            txtNCF.Multiline = true;
            txtNCF.Name = "txtNCF";
            txtNCF.ReadOnly = true;
            txtNCF.Size = new Size(146, 28);
            txtNCF.TabIndex = 18;
            // 
            // label19
            // 
            label19.Location = new Point(42, 185);
            label19.Name = "label19";
            label19.Size = new Size(171, 26);
            label19.TabIndex = 17;
            label19.Text = "Estatus";
            // 
            // label18
            // 
            label18.Location = new Point(419, 48);
            label18.Name = "label18";
            label18.Size = new Size(146, 21);
            label18.TabIndex = 16;
            label18.Text = "NCF";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(346, 41);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(67, 59);
            btnBuscarUsuario.TabIndex = 15;
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // txtIDFactura
            // 
            txtIDFactura.Location = new Point(42, 72);
            txtIDFactura.Multiline = true;
            txtIDFactura.Name = "txtIDFactura";
            txtIDFactura.ReadOnly = true;
            txtIDFactura.Size = new Size(79, 28);
            txtIDFactura.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(212, 72);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(128, 28);
            txtUsuario.TabIndex = 11;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IDDetalle, IDProducto, Precio, Cantidad, Subtotal, Descuento, Impuesto, Total });
            dgvProductos.Location = new Point(6, 176);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(615, 157);
            dgvProductos.TabIndex = 12;
            // 
            // IDDetalle
            // 
            IDDetalle.DataPropertyName = "IDProducto";
            IDDetalle.HeaderText = "ID";
            IDDetalle.Name = "IDDetalle";
            IDDetalle.ReadOnly = true;
            IDDetalle.Width = 46;
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "Producto";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            IDProducto.Resizable = DataGridViewTriState.True;
            IDProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            IDProducto.Width = 86;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle41.Format = "C2";
            dataGridViewCellStyle41.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle41;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 69;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 85;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle42.Format = "C2";
            dataGridViewCellStyle42.NullValue = null;
            Subtotal.DefaultCellStyle = dataGridViewCellStyle42;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 81;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle43.Format = "C2";
            dataGridViewCellStyle43.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle43;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 94;
            // 
            // Impuesto
            // 
            Impuesto.DataPropertyName = "Itbis";
            dataGridViewCellStyle44.Format = "C2";
            dataGridViewCellStyle44.NullValue = null;
            Impuesto.DefaultCellStyle = dataGridViewCellStyle44;
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            Impuesto.Width = 88;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle45.Format = "C2";
            dataGridViewCellStyle45.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle45;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 62;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(txtProducto);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnBuscarProducto);
            groupBox3.Controls.Add(txtIDProducto);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtDescuento);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(615, 164);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = Properties.Resources._btnAgregarProductooo;
            btnAgregar.Location = new Point(459, 95);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(57, 54);
            btnAgregar.TabIndex = 11;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Image = Properties.Resources._BotonBuscarProducto;
            btnBuscarProducto.Location = new Point(459, 30);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(57, 54);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(201, 92);
            label13.Name = "label13";
            label13.Size = new Size(104, 21);
            label13.TabIndex = 9;
            label13.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(201, 116);
            txtDescuento.Multiline = true;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(104, 30);
            txtDescuento.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(91, 116);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(104, 30);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(330, 54);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(123, 30);
            txtPrecio.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(144, 54);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(180, 30);
            txtProducto.TabIndex = 5;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(91, 54);
            txtIDProducto.Multiline = true;
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.ReadOnly = true;
            txtIDProducto.Size = new Size(47, 30);
            txtIDProducto.TabIndex = 4;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(91, 92);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 3;
            label12.Text = "Cantidad";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(330, 30);
            label11.Name = "label11";
            label11.Size = new Size(123, 21);
            label11.TabIndex = 2;
            label11.Text = "Precio";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(144, 30);
            label10.Name = "label10";
            label10.Size = new Size(180, 21);
            label10.TabIndex = 1;
            label10.Text = "Producto";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(91, 30);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.Goldenrod;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources._NewFacturaProduct;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(3, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(197, 49);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Goldenrod;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources._SaveFacturaProduct;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(3, 79);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(197, 49);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.Goldenrod;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = Properties.Resources._cancelFacturaProduct;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(3, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(197, 49);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(246, 349);
            label14.Name = "label14";
            label14.Size = new Size(89, 21);
            label14.TabIndex = 17;
            label14.Text = "Subtotal";
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(436, 349);
            label15.Name = "label15";
            label15.Size = new Size(89, 21);
            label15.TabIndex = 18;
            label15.Text = "Descuento";
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(341, 349);
            label16.Name = "label16";
            label16.Size = new Size(89, 21);
            label16.TabIndex = 19;
            label16.Text = "Impuesto";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Black;
            label17.Location = new Point(531, 348);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 20;
            label17.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(246, 373);
            txtSubTotal.Multiline = true;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(89, 33);
            txtSubTotal.TabIndex = 21;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(341, 373);
            txtImpuesto.Multiline = true;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(89, 33);
            txtImpuesto.TabIndex = 22;
            // 
            // txtTotalDescuento
            // 
            txtTotalDescuento.Location = new Point(436, 373);
            txtTotalDescuento.Multiline = true;
            txtTotalDescuento.Name = "txtTotalDescuento";
            txtTotalDescuento.ReadOnly = true;
            txtTotalDescuento.Size = new Size(89, 33);
            txtTotalDescuento.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(531, 373);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(89, 33);
            txtTotal.TabIndex = 24;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Black;
            TopPanel.BorderStyle = BorderStyle.FixedSingle;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(840, 61);
            TopPanel.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._BotonXcerrarVentana;
            pictureBox1.Location = new Point(784, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 32);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnCancelar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 463);
            panel2.TabIndex = 27;
            // 
            // tabDetalleFactura
            // 
            tabDetalleFactura.Controls.Add(groupBox3);
            tabDetalleFactura.Controls.Add(dgvProductos);
            tabDetalleFactura.Controls.Add(txtSubTotal);
            tabDetalleFactura.Controls.Add(txtTotal);
            tabDetalleFactura.Controls.Add(label17);
            tabDetalleFactura.Controls.Add(label14);
            tabDetalleFactura.Controls.Add(txtImpuesto);
            tabDetalleFactura.Controls.Add(txtTotalDescuento);
            tabDetalleFactura.Controls.Add(label15);
            tabDetalleFactura.Controls.Add(label16);
            tabDetalleFactura.Location = new Point(4, 26);
            tabDetalleFactura.Name = "tabDetalleFactura";
            tabDetalleFactura.Padding = new Padding(3);
            tabDetalleFactura.Size = new Size(626, 423);
            tabDetalleFactura.TabIndex = 2;
            tabDetalleFactura.Text = "Detalle de Factura";
            tabDetalleFactura.UseVisualStyleBackColor = true;
            // 
            // tabClientData
            // 
            tabClientData.Controls.Add(groupBox4);
            tabClientData.Controls.Add(groupBox1);
            tabClientData.Location = new Point(4, 26);
            tabClientData.Name = "tabClientData";
            tabClientData.Padding = new Padding(3);
            tabClientData.Size = new Size(626, 423);
            tabClientData.TabIndex = 0;
            tabClientData.Text = "Datos de Cliente y Factura";
            tabClientData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(114, 43);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "Tipo Cliente";
            // 
            // label6
            // 
            label6.Location = new Point(220, 43);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(114, 72);
            txtTipoCliente.Multiline = true;
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.ReadOnly = true;
            txtTipoCliente.Size = new Size(100, 28);
            txtTipoCliente.TabIndex = 13;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(220, 72);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(100, 28);
            txtCliente.TabIndex = 14;
            // 
            // label7
            // 
            label7.Location = new Point(42, 43);
            label7.Name = "label7";
            label7.Size = new Size(66, 26);
            label7.TabIndex = 7;
            label7.Text = "ID Cliente";
            // 
            // label8
            // 
            label8.Location = new Point(326, 46);
            label8.Name = "label8";
            label8.Size = new Size(143, 26);
            label8.TabIndex = 8;
            label8.Text = "Documento";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(42, 72);
            txtIDCliente.Multiline = true;
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(66, 28);
            txtIDCliente.TabIndex = 13;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(326, 72);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(143, 28);
            txtDocumento.TabIndex = 15;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.FlatAppearance.BorderColor = Color.Black;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Image = Properties.Resources._btnbuscarclienteee;
            btnBuscarCliente.Location = new Point(502, 43);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(63, 57);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabClientData);
            tabControl1.Controls.Add(tabDetalleFactura);
            tabControl1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(207, 99);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(634, 453);
            tabControl1.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(txtIDCliente);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTipoCliente);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbEstatus);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(txtIDUsuario);
            groupBox4.Controls.Add(txtNCF);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(dtpFechaVencimiento);
            groupBox4.Controls.Add(txtIDFactura);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(dtpFechaEmision);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(btnBuscarUsuario);
            groupBox4.Controls.Add(txtUsuario);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(6, 147);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(607, 258);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos de Factura";
            // 
            // frmFacturaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 556);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturaProductos";
            Text = "Factura Productos";
            Load += frmFacturaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabDetalleFactura.ResumeLayout(false);
            tabDetalleFactura.PerformLayout();
            tabClientData.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFechaEmision;
        private DateTimePicker dtpFechaVencimiento;
        private Label label3;
        private TextBox txtIDFactura;
        private TextBox txtUsuario;
        private DataGridView dgvProductos;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtProducto;
        private TextBox txtIDProducto;
        private Label label13;
        private TextBox txtDescuento;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Button btnBuscarProducto;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtSubTotal;
        private TextBox txtImpuesto;
        private TextBox txtTotalDescuento;
        private TextBox txtTotal;
        private Button btnBuscarUsuario;
        private ComboBox cbEstatus;
        private TextBox txtNCF;
        private Label label19;
        private Label label18;
        private ErrorProvider errorProvider;
        private TextBox txtIDUsuario;
        private Label label20;
        private DataGridViewTextBoxColumn IDDetalle;
        private DataGridViewComboBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Total;
        private Panel panel1;
        private Panel TopPanel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabClientData;
        private Button btnBuscarCliente;
        private TextBox txtDocumento;
        private TextBox txtIDCliente;
        private TextBox txtCliente;
        private TextBox txtTipoCliente;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private TabPage tabDetalleFactura;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
    }
}