namespace SistemaGym.UI.Windows
{
    partial class frmListaCliente
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
            txtID = new Label();
            Nombre = new Label();
            Descripcion = new Label();
            txtIDTipoCliente = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            dgvListaCliente = new DataGridView();
            IdListaCliente = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Nuevo = new Label();
            btnGuardar = new Label();
            btnCancelar = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.Location = new Point(64, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 15);
            txtID.TabIndex = 0;
            txtID.Text = "IDListaCliente";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(48, 111);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(48, 173);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(69, 15);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // txtIDTipoCliente
            // 
            txtIDTipoCliente.Location = new Point(164, 52);
            txtIDTipoCliente.Name = "txtIDTipoCliente";
            txtIDTipoCliente.Size = new Size(100, 23);
            txtIDTipoCliente.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 173);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvListaCliente
            // 
            dgvListaCliente.AllowUserToAddRows = false;
            dgvListaCliente.AllowUserToDeleteRows = false;
            dgvListaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCliente.Columns.AddRange(new DataGridViewColumn[] { IdListaCliente, Nombres, Descripciones });
            dgvListaCliente.Location = new Point(346, 49);
            dgvListaCliente.Name = "dgvListaCliente";
            dgvListaCliente.ReadOnly = true;
            dgvListaCliente.RowTemplate.Height = 25;
            dgvListaCliente.Size = new Size(341, 150);
            dgvListaCliente.TabIndex = 6;
            dgvListaCliente.CellContentClick += dgvListaCliente_CellContentClick;
            // 
            // IdListaCliente
            // 
            IdListaCliente.HeaderText = "IdListaCliente";
            IdListaCliente.Name = "IdListaCliente";
            IdListaCliente.ReadOnly = true;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Nuevo
            // 
            Nuevo.AutoSize = true;
            Nuevo.Location = new Point(239, 239);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(42, 15);
            Nuevo.TabIndex = 7;
            Nuevo.Text = "Nuevo";
            Nuevo.Click += Nuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(373, 239);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(49, 15);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(505, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(53, 15);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(Nuevo);
            Controls.Add(dgvListaCliente);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtIDTipoCliente);
            Controls.Add(Descripcion);
            Controls.Add(Nombre);
            Controls.Add(txtID);
            Name = "frmListaCliente";
            Text = "frmListaCliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtID;
        private Label Nombre;
        private Label Descripcion;
        private TextBox txtIDTipoCliente;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ErrorProvider errorProvider1;
        private DataGridView dgvListaCliente;
        private DataGridViewTextBoxColumn IdListaCliente;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Descripciones;
        private Label btnCancelar;
        private Label btnGuardar;
        private Label Nuevo;
    }
}