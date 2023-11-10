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
            lblIDProducto = new Label();
            lblNombre = new Label();
            lblCategoria = new Label();
            lblPrecioUnitario = new Label();
            lblNoExixtencia = new Label();
            txtIDProducto = new TextBox();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtNoExistencia = new TextBox();
            dgvProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            NoExistencia = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
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
            lblPrecioUnitario.Location = new Point(30, 153);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblNoExixtencia
            // 
            lblNoExixtencia.AutoSize = true;
            lblNoExixtencia.Location = new Point(30, 194);
            lblNoExixtencia.Name = "lblNoExixtencia";
            lblNoExixtencia.Size = new Size(81, 15);
            lblNoExixtencia.TabIndex = 4;
            lblNoExixtencia.Text = "No. Existencia";
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
            // txtCategoria
            // 
            txtCategoria.Location = new Point(136, 101);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(147, 23);
            txtCategoria.TabIndex = 7;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(136, 150);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(147, 23);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // txtNoExistencia
            // 
            txtNoExistencia.Location = new Point(136, 191);
            txtNoExistencia.Name = "txtNoExistencia";
            txtNoExistencia.Size = new Size(147, 23);
            txtNoExistencia.TabIndex = 9;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, PrecioUnitario, NoExistencia });
            dgvProductos.Location = new Point(311, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(546, 192);
            dgvProductos.TabIndex = 10;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // NoExistencia
            // 
            NoExistencia.HeaderText = "NoExistencia";
            NoExistencia.Name = "NoExistencia";
            NoExistencia.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(321, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 39);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(455, 342);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 39);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(749, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(595, 342);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 39);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // MantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 531);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(txtNoExistencia);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(txtIDProducto);
            Controls.Add(lblNoExixtencia);
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
        private Label lblNoExixtencia;
        private TextBox txtIDProducto;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private TextBox txtPrecioUnitario;
        private TextBox txtNoExistencia;
        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn NoExistencia;
        private Button btnLimpiar;
    }
}