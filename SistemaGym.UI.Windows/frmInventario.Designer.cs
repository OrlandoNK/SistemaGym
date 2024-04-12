namespace SistemaGym.UI.Windows
{
    partial class frmInventario
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
            lblIdinventario = new Label();
            lblNombreItems = new Label();
            lblDescripcion = new Label();
            lblCategoria = new Label();
            lblUbicacion = new Label();
            lblCantidad = new Label();
            lblEstatusItems = new Label();
            textIDInventario = new TextBox();
            textNombreItems = new TextBox();
            textDescripcion = new TextBox();
            textCategoria = new TextBox();
            textUbicacion = new TextBox();
            textCantidad = new TextBox();
            dataGridView1 = new DataGridView();
            IDInventario = new DataGridViewTextBoxColumn();
            NombreItems = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            EstatusItems = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            cmbxEstatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblIdinventario
            // 
            lblIdinventario.AutoSize = true;
            lblIdinventario.Location = new Point(33, 34);
            lblIdinventario.Name = "lblIdinventario";
            lblIdinventario.Size = new Size(74, 15);
            lblIdinventario.TabIndex = 0;
            lblIdinventario.Text = "ID Inventario";
            // 
            // lblNombreItems
            // 
            lblNombreItems.AutoSize = true;
            lblNombreItems.Location = new Point(24, 64);
            lblNombreItems.Name = "lblNombreItems";
            lblNombreItems.Size = new Size(83, 15);
            lblNombreItems.TabIndex = 1;
            lblNombreItems.Text = "Nombre Items";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(289, 34);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(300, 64);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(508, 34);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 4;
            lblUbicacion.Text = "Ubicacion";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(513, 67);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad";
            // 
            // lblEstatusItems
            // 
            lblEstatusItems.AutoSize = true;
            lblEstatusItems.Location = new Point(707, 34);
            lblEstatusItems.Name = "lblEstatusItems";
            lblEstatusItems.Size = new Size(76, 15);
            lblEstatusItems.TabIndex = 6;
            lblEstatusItems.Text = "Estatus Items";
            // 
            // textIDInventario
            // 
            textIDInventario.Location = new Point(113, 34);
            textIDInventario.Name = "textIDInventario";
            textIDInventario.Size = new Size(100, 23);
            textIDInventario.TabIndex = 7;
            // 
            // textNombreItems
            // 
            textNombreItems.Location = new Point(113, 64);
            textNombreItems.Name = "textNombreItems";
            textNombreItems.Size = new Size(100, 23);
            textNombreItems.TabIndex = 8;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(364, 34);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 9;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(364, 64);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(100, 23);
            textCategoria.TabIndex = 10;
            // 
            // textUbicacion
            // 
            textUbicacion.Location = new Point(574, 34);
            textUbicacion.Name = "textUbicacion";
            textUbicacion.Size = new Size(100, 23);
            textUbicacion.TabIndex = 11;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(574, 67);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(100, 23);
            textCantidad.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDInventario, NombreItems, Descripcion, Categoria, Ubicacion, Cantidad, EstatusItems });
            dataGridView1.Location = new Point(74, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 150);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDInventario
            // 
            IDInventario.HeaderText = "IDinventario";
            IDInventario.Name = "IDInventario";
            IDInventario.ReadOnly = true;
            // 
            // NombreItems
            // 
            NombreItems.HeaderText = "NombreItems";
            NombreItems.Name = "NombreItems";
            NombreItems.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Ubicacion
            // 
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.Name = "Ubicacion";
            Ubicacion.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // EstatusItems
            // 
            EstatusItems.HeaderText = "EstatusItems";
            EstatusItems.Name = "EstatusItems";
            EstatusItems.ReadOnly = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(278, 317);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(399, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(553, 321);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbxEstatus
            // 
            cmbxEstatus.FormattingEnabled = true;
            cmbxEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbxEstatus.Location = new Point(789, 34);
            cmbxEstatus.Name = "cmbxEstatus";
            cmbxEstatus.Size = new Size(116, 23);
            cmbxEstatus.TabIndex = 87;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(cmbxEstatus);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(textCantidad);
            Controls.Add(textUbicacion);
            Controls.Add(textCategoria);
            Controls.Add(textDescripcion);
            Controls.Add(textNombreItems);
            Controls.Add(textIDInventario);
            Controls.Add(lblEstatusItems);
            Controls.Add(lblCantidad);
            Controls.Add(lblUbicacion);
            Controls.Add(lblCategoria);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreItems);
            Controls.Add(lblIdinventario);
            Name = "frmInventario";
            Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdinventario;
        private Label lblNombreItems;
        private Label lblDescripcion;
        private Label lblCategoria;
        private Label lblUbicacion;
        private Label lblCantidad;
        private Label lblEstatusItems;
        private TextBox textIDInventario;
        private TextBox textNombreItems;
        private TextBox textDescripcion;
        private TextBox textCategoria;
        private TextBox textUbicacion;
        private TextBox textCantidad;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDInventario;
        private DataGridViewTextBoxColumn NombreItems;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn EstatusItems;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
        private ComboBox cmbxEstatus;
    }
}