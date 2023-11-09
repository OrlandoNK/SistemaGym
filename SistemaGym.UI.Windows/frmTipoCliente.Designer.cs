namespace SistemaGym.UI.Windows
{
    partial class frmTipoCliente
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
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtRol = new TextBox();
            txtIDTipoCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            IDTipoCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(116, 102);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 20);
            txtApellido.TabIndex = 129;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 50);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 20);
            txtNombre.TabIndex = 128;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(116, 76);
            txtRol.Multiline = true;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(100, 20);
            txtRol.TabIndex = 124;
            // 
            // txtIDTipoCliente
            // 
            txtIDTipoCliente.Location = new Point(116, 12);
            txtIDTipoCliente.Multiline = true;
            txtIDTipoCliente.Name = "txtIDTipoCliente";
            txtIDTipoCliente.Size = new Size(29, 25);
            txtIDTipoCliente.TabIndex = 123;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 115;
            label4.Text = "FechaCreacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 114;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 113;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 112;
            label1.Text = "ID Tipo CLiente";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDTipoCliente, Nombre, Descripcion, FechaCreacion });
            dataGridView1.Location = new Point(274, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(417, 175);
            dataGridView1.TabIndex = 134;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(77, 210);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 135;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(172, 210);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 136;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(268, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 137;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.DataPropertyName = "IDTipoCliente";
            IDTipoCliente.HeaderText = "IDTipoCliente";
            IDTipoCliente.Name = "IDTipoCliente";
            IDTipoCliente.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // frmTipoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 252);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRol);
            Controls.Add(txtIDTipoCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTipoCliente";
            Text = "frmTipoCliente";
            Load += frmTipoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtRol;
        private TextBox txtIDTipoCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaCreacion;
    }
}