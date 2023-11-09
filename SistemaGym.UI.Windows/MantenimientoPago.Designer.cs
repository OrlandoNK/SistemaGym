namespace SistemaGym.UI.Windows
{
    partial class MantenimientoPago
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
            lblIDPago = new Label();
            lblFacturaPruducto = new Label();
            lblMetodoPago = new Label();
            lblFechaPago = new Label();
            label5 = new Label();
            lblMonto = new Label();
            lblEstatus = new Label();
            txtIDPago = new TextBox();
            txtFacturaProducto = new TextBox();
            txtFacturaMembresia = new TextBox();
            txtMetodoPago = new TextBox();
            txtMonto = new TextBox();
            txtFechaPago = new TextBox();
            txtEstatus = new TextBox();
            dgvPago = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Factura = new DataGridViewTextBoxColumn();
            FacturaProducto = new DataGridViewTextBoxColumn();
            FaturaMembresia = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            SuspendLayout();
            // 
            // lblIDPago
            // 
            lblIDPago.AutoSize = true;
            lblIDPago.Location = new Point(20, 21);
            lblIDPago.Name = "lblIDPago";
            lblIDPago.Size = new Size(48, 15);
            lblIDPago.TabIndex = 0;
            lblIDPago.Text = "ID Pago";
            // 
            // lblFacturaPruducto
            // 
            lblFacturaPruducto.AutoSize = true;
            lblFacturaPruducto.Location = new Point(20, 58);
            lblFacturaPruducto.Name = "lblFacturaPruducto";
            lblFacturaPruducto.Size = new Size(98, 15);
            lblFacturaPruducto.TabIndex = 1;
            lblFacturaPruducto.Text = "Factura Producto";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(20, 123);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(79, 15);
            lblMetodoPago.TabIndex = 2;
            lblMetodoPago.Text = "Metodo Pago";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(20, 194);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(68, 15);
            lblFechaPago.TabIndex = 3;
            lblFechaPago.Text = "Fecha Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 91);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 4;
            label5.Text = "Factura Membresia";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(20, 158);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(20, 236);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus";
            // 
            // txtIDPago
            // 
            txtIDPago.Location = new Point(143, 12);
            txtIDPago.Name = "txtIDPago";
            txtIDPago.Size = new Size(100, 23);
            txtIDPago.TabIndex = 7;
            // 
            // txtFacturaProducto
            // 
            txtFacturaProducto.Location = new Point(143, 50);
            txtFacturaProducto.Name = "txtFacturaProducto";
            txtFacturaProducto.Size = new Size(100, 23);
            txtFacturaProducto.TabIndex = 8;
            // 
            // txtFacturaMembresia
            // 
            txtFacturaMembresia.Location = new Point(143, 83);
            txtFacturaMembresia.Name = "txtFacturaMembresia";
            txtFacturaMembresia.Size = new Size(100, 23);
            txtFacturaMembresia.TabIndex = 9;
            // 
            // txtMetodoPago
            // 
            txtMetodoPago.Location = new Point(143, 123);
            txtMetodoPago.Name = "txtMetodoPago";
            txtMetodoPago.Size = new Size(100, 23);
            txtMetodoPago.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(143, 155);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 11;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Location = new Point(143, 194);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.Size = new Size(100, 23);
            txtFechaPago.TabIndex = 12;
            txtFechaPago.TextChanged += textBox6_TextChanged;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(143, 236);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(100, 23);
            txtEstatus.TabIndex = 13;
            // 
            // dgvPago
            // 
            dgvPago.AllowUserToAddRows = false;
            dgvPago.AllowUserToDeleteRows = false;
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Columns.AddRange(new DataGridViewColumn[] { ID, Factura, FacturaProducto, FaturaMembresia, MetodoPago, Monto, FechaPago, Estatus });
            dgvPago.Location = new Point(249, 12);
            dgvPago.Name = "dgvPago";
            dgvPago.ReadOnly = true;
            dgvPago.RowTemplate.Height = 25;
            dgvPago.Size = new Size(855, 247);
            dgvPago.TabIndex = 14;
            dgvPago.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Factura
            // 
            Factura.HeaderText = "Column1";
            Factura.Name = "Factura";
            Factura.ReadOnly = true;
            // 
            // FacturaProducto
            // 
            FacturaProducto.HeaderText = "FacturaProducto";
            FacturaProducto.Name = "FacturaProducto";
            FacturaProducto.ReadOnly = true;
            // 
            // FaturaMembresia
            // 
            FaturaMembresia.HeaderText = "FacturaMembresia";
            FaturaMembresia.Name = "FaturaMembresia";
            FaturaMembresia.ReadOnly = true;
            // 
            // MetodoPago
            // 
            MetodoPago.HeaderText = "MetodoPago";
            MetodoPago.Name = "MetodoPago";
            MetodoPago.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // FechaPago
            // 
            FechaPago.HeaderText = "FechaPago";
            FechaPago.Name = "FechaPago";
            FechaPago.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(249, 354);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(404, 354);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(592, 354);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(788, 354);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPago);
            Controls.Add(txtEstatus);
            Controls.Add(txtFechaPago);
            Controls.Add(txtMonto);
            Controls.Add(txtMetodoPago);
            Controls.Add(txtFacturaMembresia);
            Controls.Add(txtFacturaProducto);
            Controls.Add(txtIDPago);
            Controls.Add(lblEstatus);
            Controls.Add(lblMonto);
            Controls.Add(label5);
            Controls.Add(lblFechaPago);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblFacturaPruducto);
            Controls.Add(lblIDPago);
            Name = "MantenimientoPago";
            Text = "MantenimientoPago";
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDPago;
        private Label lblFacturaPruducto;
        private Label lblMetodoPago;
        private Label lblFechaPago;
        private Label label5;
        private Label lblMonto;
        private Label lblEstatus;
        private TextBox txtIDPago;
        private TextBox txtFacturaProducto;
        private TextBox txtFacturaMembresia;
        private TextBox txtMetodoPago;
        private TextBox txtMonto;
        private TextBox txtFechaPago;
        private TextBox txtEstatus;
        private DataGridView dgvPago;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Factura;
        private DataGridViewTextBoxColumn FacturaProducto;
        private DataGridViewTextBoxColumn FaturaMembresia;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
    }
}