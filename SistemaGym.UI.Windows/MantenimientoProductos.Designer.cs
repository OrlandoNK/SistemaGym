namespace SistemaGym.UI.Windows
{
    partial class MantenimientoProductos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblIDProducto = new Label();
            lblNombre = new Label();
            lblCategoria = new Label();
            lblPrecioUnitario = new Label();
            label = new Label();
            txtIDProducto = new TextBox();
            txtNombre = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtStock = new TextBox();
            dgvProductos = new DataGridView();
            btnAgregar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            cbCategoria = new ComboBox();
            cbProveedor = new ComboBox();
            label1 = new Label();
            IDProducto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewComboBoxColumn();
            IDProveedor = new DataGridViewComboBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblIDProducto
            // 
            lblIDProducto.AutoSize = true;
            lblIDProducto.Location = new Point(30, 22);
            lblIDProducto.Name = "lblIDProducto";
            lblIDProducto.Size = new Size(70, 15);
            lblIDProducto.TabIndex = 0;
            lblIDProducto.Text = "ID Producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(30, 109);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(30, 186);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(30, 227);
            label.Name = "label";
            label.Size = new Size(36, 15);
            label.TabIndex = 4;
            label.Text = "Stock";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(136, 22);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(147, 23);
            txtIDProducto.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(136, 183);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(147, 23);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(136, 224);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(147, 23);
            txtStock.TabIndex = 9;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IDProducto, Nombre, Categoria, IDProveedor, PrecioUnitario, Stock });
            dgvProductos.Location = new Point(311, 14);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(641, 233);
            dgvProductos.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(97, 296);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 39);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Nuevo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 296);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 39);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(136, 101);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(147, 23);
            cbCategoria.TabIndex = 14;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(136, 141);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(147, 23);
            cbProveedor.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 149);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 15;
            label1.Text = "Proveedor";
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "ID";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "IDCategoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Resizable = DataGridViewTriState.True;
            Categoria.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDProveedor
            // 
            IDProveedor.DataPropertyName = "IDProveedor";
            IDProveedor.HeaderText = "Proveedor";
            IDProveedor.Name = "IDProveedor";
            IDProveedor.ReadOnly = true;
            IDProveedor.Resizable = DataGridViewTriState.True;
            IDProveedor.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // MantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 531);
            Controls.Add(cbProveedor);
            Controls.Add(label1);
            Controls.Add(cbCategoria);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtNombre);
            Controls.Add(txtIDProducto);
            Controls.Add(label);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblIDProducto);
            Name = "MantenimientoProductos";
            Text = "MantenimientoProductos";
            Load += MantenimientoProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDProducto;
        private Label lblNombre;
        private Label lblCategoria;
        private Label lblPrecioUnitario;
        private Label label;
        private TextBox txtIDProducto;
        private TextBox txtNombre;
        private TextBox txtPrecioUnitario;
        private TextBox txtStock;
        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox cbCategoria;
        private ComboBox cbProveedor;
        private Label label1;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewComboBoxColumn Categoria;
        private DataGridViewComboBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
    }
}