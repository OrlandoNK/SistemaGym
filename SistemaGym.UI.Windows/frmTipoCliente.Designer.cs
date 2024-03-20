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
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvTipoCliente = new DataGridView();
            IDTipoCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvTipoCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 247);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 24);
            txtNombre.TabIndex = 128;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(220, 301);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 24);
            txtDescripcion.TabIndex = 124;
            // 
            // txtID
            // 
            txtID.Location = new Point(220, 183);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(52, 25);
            txtID.TabIndex = 123;
            // 
            // label3
            // 
            label3.Location = new Point(220, 220);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 114;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Location = new Point(220, 274);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 113;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.Location = new Point(220, 156);
            label1.Name = "label1";
            label1.Size = new Size(52, 24);
            label1.TabIndex = 112;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvTipoCliente
            // 
            dgvTipoCliente.AllowUserToAddRows = false;
            dgvTipoCliente.AllowUserToDeleteRows = false;
            dgvTipoCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoCliente.Columns.AddRange(new DataGridViewColumn[] { IDTipoCliente, Nombre, Descripcion, FechaCreacion });
            dgvTipoCliente.Location = new Point(546, 256);
            dgvTipoCliente.Name = "dgvTipoCliente";
            dgvTipoCliente.ReadOnly = true;
            dgvTipoCliente.RowTemplate.Height = 25;
            dgvTipoCliente.Size = new Size(225, 175);
            dgvTipoCliente.TabIndex = 134;
            dgvTipoCliente.CellContentClick += dgvTipoCliente_CellContentClick;
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
            // btnNuevo
            // 
            btnNuevo.Location = new Point(546, 169);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 135;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(546, 198);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 136;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(546, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 137;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTipoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 443);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvTipoCliente);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTipoCliente";
            Text = "frmTipoCliente";
            Load += frmTipoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvTipoCliente;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaCreacion;
        private ErrorProvider errorProvider1;
    }
}