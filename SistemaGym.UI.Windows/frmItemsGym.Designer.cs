namespace SistemaGym.UI.Windows
{
    partial class frmItemsGym
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
            txtCantidad = new TextBox();
            label4 = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtProveedor = new TextBox();
            txtIDItem = new TextBox();
            lbl2 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            txtFechaRegistro = new TextBox();
            label6 = new Label();
            IDItem = new DataGridViewTextBoxColumn();
            IDProveedor = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(120, 128);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 20);
            txtCantidad.TabIndex = 164;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 133);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 163;
            label4.Text = "Cantidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 162;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(104, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 161;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 260);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 160;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(120, 76);
            txtProveedor.Multiline = true;
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 20);
            txtProveedor.TabIndex = 159;
            // 
            // txtIDItem
            // 
            txtIDItem.Location = new Point(120, 38);
            txtIDItem.Multiline = true;
            txtIDItem.Name = "txtIDItem";
            txtIDItem.Size = new Size(29, 25);
            txtIDItem.TabIndex = 158;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(22, 79);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(61, 15);
            lbl2.TabIndex = 157;
            lbl2.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 156;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 155;
            label1.Text = "ID Item";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDItem, IDProveedor, Nombre, Cantidad, Precio, Descripcion, FechaRegistro });
            dataGridView1.Location = new Point(277, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(569, 408);
            dataGridView1.TabIndex = 166;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 104);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 20);
            txtNombre.TabIndex = 167;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(120, 154);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 20);
            txtPrecio.TabIndex = 169;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 168;
            label3.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(120, 180);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 20);
            txtDescripcion.TabIndex = 171;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 185);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 170;
            label5.Text = "Descripcion";
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(120, 206);
            txtFechaRegistro.Multiline = true;
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new Size(100, 20);
            txtFechaRegistro.TabIndex = 173;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 211);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 172;
            label6.Text = "FechaRegistro";
            // 
            // IDItem
            // 
            IDItem.DataPropertyName = "IDItem";
            IDItem.HeaderText = "IDItem";
            IDItem.Name = "IDItem";
            IDItem.ReadOnly = true;
            // 
            // IDProveedor
            // 
            IDProveedor.DataPropertyName = "IDProveedor";
            IDProveedor.HeaderText = "IDProveedor";
            IDProveedor.Name = "IDProveedor";
            IDProveedor.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // frmItemsGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(txtFechaRegistro);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProveedor);
            Controls.Add(txtIDItem);
            Controls.Add(lbl2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmItemsGym";
            Text = "frmItemsGym";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private Label label4;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtProveedor;
        private TextBox txtIDItem;
        private Label lbl2;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label5;
        private TextBox txtFechaRegistro;
        private Label label6;
        private DataGridViewTextBoxColumn IDItem;
        private DataGridViewTextBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaRegistro;
    }
}