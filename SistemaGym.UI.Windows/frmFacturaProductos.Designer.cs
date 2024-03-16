﻿namespace SistemaGym.UI.Windows
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
            label5 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label3 = new Label();
            txtIDUsuario = new TextBox();
            label20 = new Label();
            txtNCF = new TextBox();
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
            txtProducto = new TextBox();
            label10 = new Label();
            btnBuscarProducto = new Button();
            txtIDProducto = new TextBox();
            label9 = new Label();
            label13 = new Label();
            txtPrecio = new TextBox();
            label11 = new Label();
            txtDescuento = new TextBox();
            txtCantidad = new TextBox();
            label12 = new Label();
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
            label21 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            groupBox1 = new GroupBox();
            btnBuscarCliente = new Button();
            txtIDCliente = new TextBox();
            txtDocumento = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtCliente = new TextBox();
            cbTipoCliente = new ComboBox();
            panel3 = new Panel();
            panel4 = new Panel();
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
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "ID Factura";
            // 
            // label5
            // 
            label5.Location = new Point(69, 124);
            label5.Name = "label5";
            label5.Size = new Size(365, 23);
            label5.TabIndex = 4;
            label5.Text = "Fecha Vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(69, 150);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(365, 23);
            dtpFechaVencimiento.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(154, 74);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(69, 96);
            txtIDUsuario.Multiline = true;
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(79, 25);
            txtIDUsuario.TabIndex = 21;
            // 
            // label20
            // 
            label20.Location = new Point(69, 74);
            label20.Name = "label20";
            label20.Size = new Size(79, 19);
            label20.TabIndex = 20;
            label20.Text = "IDUsuario";
            // 
            // txtNCF
            // 
            txtNCF.Location = new Point(288, 96);
            txtNCF.Multiline = true;
            txtNCF.Name = "txtNCF";
            txtNCF.ReadOnly = true;
            txtNCF.Size = new Size(146, 25);
            txtNCF.TabIndex = 18;
            // 
            // label18
            // 
            label18.Location = new Point(288, 76);
            label18.Name = "label18";
            label18.Size = new Size(146, 19);
            label18.TabIndex = 16;
            label18.Text = "NCF";
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Cursor = Cursors.Hand;
            btnBuscarUsuario.FlatAppearance.BorderColor = Color.Black;
            btnBuscarUsuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscarUsuario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Image = Properties.Resources._searchfacturabtn;
            btnBuscarUsuario.Location = new Point(154, 24);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(50, 47);
            btnBuscarUsuario.TabIndex = 15;
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // txtIDFactura
            // 
            txtIDFactura.Location = new Point(69, 46);
            txtIDFactura.Multiline = true;
            txtIDFactura.Name = "txtIDFactura";
            txtIDFactura.ReadOnly = true;
            txtIDFactura.Size = new Size(79, 25);
            txtIDFactura.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(154, 96);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(128, 25);
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
            dgvProductos.Location = new Point(6, 177);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(503, 249);
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
            dataGridViewCellStyle41.Format = "C2";
            dataGridViewCellStyle41.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle41;
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
            Subtotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle42.Format = "C2";
            dataGridViewCellStyle42.NullValue = null;
            Subtotal.DefaultCellStyle = dataGridViewCellStyle42;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 76;
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
            Descuento.Width = 88;
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
            Impuesto.Width = 82;
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
            Total.Width = 57;
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
            groupBox3.Size = new Size(503, 165);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = Properties.Resources._btnAgregarProductooo;
            btnAgregar.Location = new Point(407, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(57, 54);
            btnAgregar.TabIndex = 11;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(92, 59);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(180, 30);
            txtProducto.TabIndex = 5;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(92, 35);
            label10.Name = "label10";
            label10.Size = new Size(180, 21);
            label10.TabIndex = 1;
            label10.Text = "Producto";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Image = Properties.Resources._BotonBuscarProducto;
            btnBuscarProducto.Location = new Point(407, 35);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(57, 54);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(39, 59);
            txtIDProducto.Multiline = true;
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.ReadOnly = true;
            txtIDProducto.Size = new Size(47, 30);
            txtIDProducto.TabIndex = 4;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(39, 35);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 0;
            label9.Text = "ID";
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(149, 97);
            label13.Name = "label13";
            label13.Size = new Size(104, 21);
            label13.TabIndex = 9;
            label13.Text = "Descuento";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(278, 59);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(123, 30);
            txtPrecio.TabIndex = 6;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(278, 35);
            label11.Name = "label11";
            label11.Size = new Size(123, 21);
            label11.TabIndex = 2;
            label11.Text = "Precio";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(149, 121);
            txtDescuento.Multiline = true;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(104, 30);
            txtDescuento.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(39, 121);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(104, 30);
            txtCantidad.TabIndex = 7;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(39, 97);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 3;
            label12.Text = "Cantidad";
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
            btnGuardar.Image = Properties.Resources._SaveFacturaProduct;
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
            btnCancelar.Location = new Point(-1, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(205, 49);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(135, 454);
            label14.Name = "label14";
            label14.Size = new Size(89, 21);
            label14.TabIndex = 17;
            label14.Text = "Subtotal";
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(325, 454);
            label15.Name = "label15";
            label15.Size = new Size(89, 21);
            label15.TabIndex = 18;
            label15.Text = "Descuento";
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(230, 454);
            label16.Name = "label16";
            label16.Size = new Size(89, 21);
            label16.TabIndex = 19;
            label16.Text = "Impuesto";
            // 
            // label17
            // 
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.Black;
            label17.Location = new Point(420, 454);
            label17.Name = "label17";
            label17.Size = new Size(89, 21);
            label17.TabIndex = 20;
            label17.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(135, 478);
            txtSubTotal.Multiline = true;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(89, 27);
            txtSubTotal.TabIndex = 21;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(230, 478);
            txtImpuesto.Multiline = true;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(89, 27);
            txtImpuesto.TabIndex = 22;
            // 
            // txtTotalDescuento
            // 
            txtTotalDescuento.Location = new Point(325, 478);
            txtTotalDescuento.Multiline = true;
            txtTotalDescuento.Name = "txtTotalDescuento";
            txtTotalDescuento.ReadOnly = true;
            txtTotalDescuento.Size = new Size(89, 27);
            txtTotalDescuento.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(420, 478);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(89, 27);
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
            TopPanel.Size = new Size(1243, 61);
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
            pictureBox1.Location = new Point(1198, 13);
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
            panel1.Size = new Size(1243, 32);
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
            panel2.Size = new Size(205, 510);
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
            groupBox4.Controls.Add(btnBuscarUsuario);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtUsuario);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(10, 147);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(503, 184);
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
            groupBox1.Location = new Point(10, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderColor = Color.Black;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Image = Properties.Resources._btnbuscarclienteee;
            btnBuscarCliente.Location = new Point(127, 27);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(50, 46);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(55, 50);
            txtIDCliente.Multiline = true;
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(66, 23);
            txtIDCliente.TabIndex = 13;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(305, 102);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(143, 23);
            txtDocumento.TabIndex = 15;
            // 
            // label7
            // 
            label7.Location = new Point(55, 27);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 7;
            label7.Text = "ID Cliente";
            // 
            // label8
            // 
            label8.Location = new Point(305, 79);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 8;
            label8.Text = "Documento";
            // 
            // label2
            // 
            label2.Location = new Point(55, 79);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 6;
            label2.Text = "Tipo Cliente";
            // 
            // label6
            // 
            label6.Location = new Point(199, 79);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(199, 102);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 14;
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(55, 102);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(138, 23);
            cbTipoCliente.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(205, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 510);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(groupBox3);
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(dgvProductos);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtSubTotal);
            panel4.Controls.Add(txtTotalDescuento);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(txtImpuesto);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(728, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 510);
            panel4.TabIndex = 29;
            // 
            // frmFacturaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 603);
            Controls.Add(panel4);
            Controls.Add(panel3);
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
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private TextBox txtNCF;
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
        private Panel panel4;
    }
}