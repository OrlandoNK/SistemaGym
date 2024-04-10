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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label1 = new Label();
            label5 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label3 = new Label();
            txtIDUsuario = new TextBox();
            label20 = new Label();
            txtNCF = new TextBox();
            label18 = new Label();
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
            txtProducto = new TextBox();
            label10 = new Label();
            txtIDProducto = new TextBox();
            label9 = new Label();
            btnBuscarProducto = new Button();
            label13 = new Label();
            txtPrecio = new TextBox();
            label11 = new Label();
            txtCantidad = new TextBox();
            label12 = new Label();
            txtDescuento = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
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
            label21 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            groupBox1 = new GroupBox();
            cbTipoCliente = new ComboBox();
            btnBuscarCliente = new Button();
            txtIDCliente = new TextBox();
            txtDocumento = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtCliente = new TextBox();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            cbMetodoPago = new ComboBox();
            label22 = new Label();
            txtMontoRecibido = new TextBox();
            label4 = new Label();
            txtMontoTotal = new TextBox();
            label19 = new Label();
            txtDevuelta = new TextBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "ID Factura";
            // 
            // label5
            // 
            label5.Location = new Point(437, 97);
            label5.Name = "label5";
            label5.Size = new Size(175, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha Vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Location = new Point(437, 123);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(175, 23);
            dtpFechaVencimiento.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(218, 37);
            label3.Name = "label3";
            label3.Size = new Size(213, 18);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(122, 59);
            txtIDUsuario.Multiline = true;
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(90, 25);
            txtIDUsuario.TabIndex = 21;
            // 
            // label20
            // 
            label20.Location = new Point(122, 37);
            label20.Name = "label20";
            label20.Size = new Size(90, 19);
            label20.TabIndex = 20;
            label20.Text = "IDUsuario";
            // 
            // txtNCF
            // 
            txtNCF.Location = new Point(437, 59);
            txtNCF.Multiline = true;
            txtNCF.Name = "txtNCF";
            txtNCF.ReadOnly = true;
            txtNCF.Size = new Size(175, 25);
            txtNCF.TabIndex = 18;
            // 
            // label18
            // 
            label18.Location = new Point(437, 39);
            label18.Name = "label18";
            label18.Size = new Size(175, 19);
            label18.TabIndex = 16;
            label18.Text = "NCF";
            // 
            // txtIDFactura
            // 
            txtIDFactura.Location = new Point(37, 59);
            txtIDFactura.Multiline = true;
            txtIDFactura.Name = "txtIDFactura";
            txtIDFactura.ReadOnly = true;
            txtIDFactura.Size = new Size(79, 25);
            txtIDFactura.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(218, 59);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(213, 25);
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
            dgvProductos.Location = new Point(396, 179);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(575, 360);
            dgvProductos.TabIndex = 12;
            // 
            // IDDetalle
            // 
            IDDetalle.DataPropertyName = "IDProducto";
            IDDetalle.HeaderText = "ID";
            IDDetalle.Name = "IDDetalle";
            IDDetalle.ReadOnly = true;
            IDDetalle.Width = 43;
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "Producto";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            IDProducto.Resizable = DataGridViewTriState.True;
            IDProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            IDProducto.Width = 81;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle6;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 65;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            Subtotal.DefaultCellStyle = dataGridViewCellStyle7;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 76;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle8;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 88;
            // 
            // Impuesto
            // 
            Impuesto.DataPropertyName = "Itbis";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            Impuesto.DefaultCellStyle = dataGridViewCellStyle9;
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            Impuesto.Width = 82;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle10;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 57;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(txtProducto);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtIDProducto);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnBuscarProducto);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtDescuento);
            groupBox3.Location = new Point(9, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(380, 202);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = Properties.Resources.icon_btn_Add_Product__x32_;
            btnAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar.Location = new Point(224, 147);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 49);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.TextAlign = ContentAlignment.BottomLeft;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(62, 59);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(180, 23);
            txtProducto.TabIndex = 5;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(62, 35);
            label10.Name = "label10";
            label10.Size = new Size(180, 21);
            label10.TabIndex = 1;
            label10.Text = "Producto";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(9, 59);
            txtIDProducto.Multiline = true;
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.ReadOnly = true;
            txtIDProducto.Size = new Size(47, 23);
            txtIDProducto.TabIndex = 4;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(9, 35);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatAppearance.BorderSize = 2;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Image = Properties.Resources.icon_btn_search_producto__x32_;
            btnBuscarProducto.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscarProducto.Location = new Point(224, 93);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(144, 49);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.TextAlign = ContentAlignment.BottomLeft;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(91, 93);
            label13.Name = "label13";
            label13.Size = new Size(76, 21);
            label13.TabIndex = 9;
            label13.Text = "Descuento";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(248, 59);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(123, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(248, 35);
            label11.Name = "label11";
            label11.Size = new Size(123, 21);
            label11.TabIndex = 2;
            label11.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(9, 119);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(76, 23);
            txtCantidad.TabIndex = 7;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(9, 93);
            label12.Name = "label12";
            label12.Size = new Size(76, 23);
            label12.TabIndex = 3;
            label12.Text = "Cantidad";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(91, 119);
            txtDescuento.Multiline = true;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(76, 23);
            txtDescuento.TabIndex = 8;
            txtDescuento.KeyPress += txtDescuento_KeyPress;
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
            btnNuevo.Location = new Point(-1, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(205, 49);
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
            btnGuardar.Image = Properties.Resources.icon_save_button__x32_;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(-1, 79);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(205, 49);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(591, 556);
            label14.Name = "label14";
            label14.Size = new Size(89, 21);
            label14.TabIndex = 17;
            label14.Text = "Subtotal";
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(787, 556);
            label15.Name = "label15";
            label15.Size = new Size(89, 21);
            label15.TabIndex = 18;
            label15.Text = "Descuento";
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(686, 556);
            label16.Name = "label16";
            label16.Size = new Size(89, 21);
            label16.TabIndex = 19;
            label16.Text = "Impuesto";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Black;
            label17.Location = new Point(882, 556);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 20;
            label17.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(591, 581);
            txtSubTotal.Multiline = true;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(89, 25);
            txtSubTotal.TabIndex = 21;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(686, 581);
            txtImpuesto.Multiline = true;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(89, 25);
            txtImpuesto.TabIndex = 22;
            // 
            // txtTotalDescuento
            // 
            txtTotalDescuento.Location = new Point(787, 581);
            txtTotalDescuento.Multiline = true;
            txtTotalDescuento.Name = "txtTotalDescuento";
            txtTotalDescuento.ReadOnly = true;
            txtTotalDescuento.Size = new Size(89, 25);
            txtTotalDescuento.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(882, 581);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(89, 25);
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
            TopPanel.Controls.Add(label21);
            TopPanel.Controls.Add(pictureBox2);
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1188, 61);
            TopPanel.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Goldenrod;
            label21.Location = new Point(69, 17);
            label21.Name = "label21";
            label21.Size = new Size(194, 24);
            label21.TabIndex = 30;
            label21.Text = "Facturación Producto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Facturacion_Producto_Icon_;
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._BotonXcerrarVentana;
            pictureBox1.Location = new Point(1143, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
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
            panel1.Size = new Size(1188, 32);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 619);
            panel2.TabIndex = 27;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtIDUsuario);
            groupBox4.Controls.Add(txtNCF);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtIDFactura);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(dtpFechaVencimiento);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtUsuario);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(323, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(648, 165);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos de Factura";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipoCliente);
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(txtIDCliente);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Location = new Point(9, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(147, 59);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(143, 23);
            cbTipoCliente.TabIndex = 22;
            cbTipoCliente.Visible = false;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.Black;
            btnBuscarCliente.FlatAppearance.BorderSize = 2;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Image = Properties.Resources.icon_btn_search_for_Cliente__x32_;
            btnBuscarCliente.Location = new Point(91, 36);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(50, 46);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(19, 59);
            txtIDCliente.Multiline = true;
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(66, 23);
            txtIDCliente.TabIndex = 13;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(147, 113);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(143, 23);
            txtDocumento.TabIndex = 15;
            // 
            // label7
            // 
            label7.Location = new Point(19, 36);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 7;
            label7.Text = "ID Cliente";
            // 
            // label8
            // 
            label8.Location = new Point(147, 90);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 8;
            label8.Text = "Documento";
            // 
            // label2
            // 
            label2.Location = new Point(147, 36);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 6;
            label2.Text = "Tipo Cliente";
            label2.Visible = false;
            // 
            // label6
            // 
            label6.Location = new Point(19, 90);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(19, 113);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(122, 23);
            txtCliente.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvProductos);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtSubTotal);
            panel3.Controls.Add(txtTotalDescuento);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtImpuesto);
            panel3.Controls.Add(label16);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(205, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 619);
            panel3.TabIndex = 28;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMetodoPago);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(txtMontoRecibido);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMontoTotal);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtDevuelta);
            groupBox2.Controls.Add(label23);
            groupBox2.Location = new Point(9, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 152);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pagos";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Transferencia" });
            cbMetodoPago.Location = new Point(12, 118);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(122, 23);
            cbMetodoPago.TabIndex = 23;
            // 
            // label22
            // 
            label22.BackColor = Color.Transparent;
            label22.Location = new Point(12, 94);
            label22.Name = "label22";
            label22.Size = new Size(122, 21);
            label22.TabIndex = 7;
            label22.Text = "Metodo de Pago";
            // 
            // txtMontoRecibido
            // 
            txtMontoRecibido.Location = new Point(246, 59);
            txtMontoRecibido.Multiline = true;
            txtMontoRecibido.Name = "txtMontoRecibido";
            txtMontoRecibido.Size = new Size(122, 23);
            txtMontoRecibido.TabIndex = 5;
            txtMontoRecibido.TextChanged += txtMontoRecibido_TextChanged;
            txtMontoRecibido.KeyPress += txtMontoRecibido_KeyPress;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(246, 35);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 1;
            label4.Text = "Monto Recibido";
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(12, 59);
            txtMontoTotal.Multiline = true;
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.ReadOnly = true;
            txtMontoTotal.Size = new Size(122, 23);
            txtMontoTotal.TabIndex = 4;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.Location = new Point(12, 35);
            label19.Name = "label19";
            label19.Size = new Size(122, 21);
            label19.TabIndex = 0;
            label19.Text = "Monto a Pagar";
            // 
            // txtDevuelta
            // 
            txtDevuelta.Enabled = false;
            txtDevuelta.Location = new Point(246, 118);
            txtDevuelta.Multiline = true;
            txtDevuelta.Name = "txtDevuelta";
            txtDevuelta.ReadOnly = true;
            txtDevuelta.Size = new Size(122, 23);
            txtDevuelta.TabIndex = 6;
            txtDevuelta.KeyPress += txtDevuelta_KeyPress;
            // 
            // label23
            // 
            label23.BackColor = Color.Transparent;
            label23.Location = new Point(246, 94);
            label23.Name = "label23";
            label23.Size = new Size(122, 21);
            label23.TabIndex = 2;
            label23.Text = "Devuelta";
            // 
            // frmFacturaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 712);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura Productos";
            Load += frmFacturaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label5;
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
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtSubTotal;
        private TextBox txtImpuesto;
        private TextBox txtTotalDescuento;
        private TextBox txtTotal;
        private TextBox txtNCF;
        private Label label18;
        private ErrorProvider errorProvider;
        private TextBox txtIDUsuario;
        private Label label20;
        private Panel panel1;
        private Panel TopPanel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnBuscarCliente;
        private TextBox txtDocumento;
        private TextBox txtIDCliente;
        private TextBox txtCliente;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label21;
        private PictureBox pictureBox2;
        private ComboBox cbTipoCliente;
        private Panel panel3;
        private DataGridViewTextBoxColumn IDDetalle;
        private DataGridViewComboBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox2;
        private TextBox txtMontoRecibido;
        private Label label4;
        private TextBox txtMontoTotal;
        private Label label19;
        private TextBox txtDevuelta;
        private Label label23;
        private ComboBox cbMetodoPago;
        private Label label22;
    }
}