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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFechaEmision = new DateTimePicker();
            dtpFechaVencimiento = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnBuscarCliente = new Button();
            txtTipoCliente = new TextBox();
            txtCliente = new TextBox();
            txtIDCliente = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cbEstatus = new ComboBox();
            txtNCF = new TextBox();
            label19 = new Label();
            label18 = new Label();
            button2 = new Button();
            txtIDFactura = new TextBox();
            txtUsuario = new TextBox();
            dataGridView1 = new DataGridView();
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
            txtIDDetalle = new TextBox();
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
            txtDocumento = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Factura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 19);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Emision";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 54);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Vencimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 54);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "Cliente";
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Location = new Point(344, 13);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(130, 23);
            dtpFechaEmision.TabIndex = 6;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(344, 54);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(130, 23);
            dtpFechaVencimiento.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(txtTipoCliente);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtIDCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(45, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 86);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(366, 22);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(59, 36);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(244, 10);
            txtTipoCliente.Multiline = true;
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.ReadOnly = true;
            txtTipoCliente.Size = new Size(100, 21);
            txtTipoCliente.TabIndex = 13;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(49, 48);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(100, 21);
            txtCliente.TabIndex = 14;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(70, 16);
            txtIDCliente.Multiline = true;
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(79, 20);
            txtIDCliente.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(168, 51);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 8;
            label8.Text = "Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "ID Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 16);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbEstatus);
            groupBox2.Controls.Add(txtNCF);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtIDFactura);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpFechaVencimiento);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtpFechaEmision);
            groupBox2.Location = new Point(534, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 148);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Factura";
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo", "En Proceso" });
            cbEstatus.Location = new Point(282, 92);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(121, 23);
            cbEstatus.TabIndex = 19;
            // 
            // txtNCF
            // 
            txtNCF.Location = new Point(51, 95);
            txtNCF.Multiline = true;
            txtNCF.Name = "txtNCF";
            txtNCF.Size = new Size(146, 19);
            txtNCF.TabIndex = 18;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(232, 98);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 17;
            label19.Text = "Estatus";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 95);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 16;
            label18.Text = "NCF";
            // 
            // button2
            // 
            button2.Location = new Point(170, 46);
            button2.Name = "button2";
            button2.Size = new Size(51, 23);
            button2.TabIndex = 15;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtIDFactura
            // 
            txtIDFactura.Location = new Point(64, 16);
            txtIDFactura.Multiline = true;
            txtIDFactura.Name = "txtIDFactura";
            txtIDFactura.ReadOnly = true;
            txtIDFactura.Size = new Size(100, 20);
            txtIDFactura.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(64, 46);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDDetalle, IDProducto, Precio, Cantidad, Subtotal, Descuento, Impuesto, Total });
            dataGridView1.Location = new Point(51, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(929, 267);
            dataGridView1.TabIndex = 12;
            // 
            // IDDetalle
            // 
            IDDetalle.DataPropertyName = "IDDetalleFacturaProducto";
            IDDetalle.HeaderText = "ID";
            IDDetalle.Name = "IDDetalle";
            IDDetalle.ReadOnly = true;
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "Producto";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            IDProducto.Resizable = DataGridViewTriState.True;
            IDProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle1;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle3;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            // 
            // Impuesto
            // 
            Impuesto.DataPropertyName = "Itbis";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Impuesto.DefaultCellStyle = dataGridViewCellStyle4;
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(btnBuscarProducto);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtDescuento);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(txtProducto);
            groupBox3.Controls.Add(txtIDDetalle);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(51, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(929, 103);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalles Factura";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(683, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(61, 34);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(683, 19);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(59, 36);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(552, 44);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 9;
            label13.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(553, 62);
            txtDescuento.Multiline = true;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(62, 17);
            txtDescuento.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(457, 62);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(62, 17);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(326, 62);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(99, 17);
            txtPrecio.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(115, 62);
            txtProducto.Multiline = true;
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(180, 17);
            txtProducto.TabIndex = 5;
            // 
            // txtIDDetalle
            // 
            txtIDDetalle.Location = new Point(6, 62);
            txtIDDetalle.Multiline = true;
            txtIDDetalle.Name = "txtIDDetalle";
            txtIDDetalle.ReadOnly = true;
            txtIDDetalle.Size = new Size(90, 17);
            txtIDDetalle.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(457, 42);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 3;
            label12.Text = "Cantidad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(350, 40);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 2;
            label11.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(171, 39);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 1;
            label10.Text = "Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(20, 39);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 0;
            label9.Text = "ID Detalle";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(54, 563);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 49);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(193, 563);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 49);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(333, 563);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 49);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(549, 559);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 17;
            label14.Text = "Subtotal";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(766, 559);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 18;
            label15.Text = "Descuento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(660, 559);
            label16.Name = "label16";
            label16.Size = new Size(57, 15);
            label16.TabIndex = 19;
            label16.Text = "Impuesto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(895, 559);
            label17.Name = "label17";
            label17.Size = new Size(32, 15);
            label17.TabIndex = 20;
            label17.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(530, 577);
            txtSubTotal.Multiline = true;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(89, 33);
            txtSubTotal.TabIndex = 21;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(642, 577);
            txtImpuesto.Multiline = true;
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(89, 33);
            txtImpuesto.TabIndex = 22;
            // 
            // txtTotalDescuento
            // 
            txtTotalDescuento.Location = new Point(751, 577);
            txtTotalDescuento.Multiline = true;
            txtTotalDescuento.Name = "txtTotalDescuento";
            txtTotalDescuento.ReadOnly = true;
            txtTotalDescuento.Size = new Size(89, 33);
            txtTotalDescuento.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(864, 577);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(89, 33);
            txtTotal.TabIndex = 24;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(244, 48);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(100, 21);
            txtDocumento.TabIndex = 15;
            // 
            // frmFacturaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 626);
            Controls.Add(txtTotal);
            Controls.Add(txtTotalDescuento);
            Controls.Add(txtImpuesto);
            Controls.Add(txtSubTotal);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmFacturaProductos";
            Text = "Factura Productos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFechaEmision;
        private DateTimePicker dtpFechaVencimiento;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtIDFactura;
        private TextBox txtUsuario;
        private TextBox txtTipoCliente;
        private TextBox txtCliente;
        private TextBox txtIDCliente;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtProducto;
        private TextBox txtIDDetalle;
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
        private Button btnBuscarCliente;
        private Button button2;
        private DataGridViewTextBoxColumn IDDetalle;
        private DataGridViewComboBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Total;
        private ComboBox cbEstatus;
        private TextBox txtNCF;
        private Label label19;
        private Label label18;
        private TextBox txtDocumento;
    }
}