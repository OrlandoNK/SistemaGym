namespace SistemaGym.UI.Windows
{
    partial class frmRol
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDRol = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            dgvRol = new DataGridView();
            IDRol = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnNuevo = new Label();
            btnGuardar = new Label();
            btnCancelar = new Label();
            label7 = new Label();
            txtID = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvRol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Rol";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // txtIDRol
            // 
            txtIDRol.Location = new Point(107, 53);
            txtIDRol.Name = "txtIDRol";
            txtIDRol.Size = new Size(100, 23);
            txtIDRol.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(107, 120);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // dgvRol
            // 
            dgvRol.AllowUserToAddRows = false;
            dgvRol.AllowUserToDeleteRows = false;
            dgvRol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRol.Columns.AddRange(new DataGridViewColumn[] { IDRol, Nombre, Descripcion });
            dgvRol.Location = new Point(240, 27);
            dgvRol.Name = "dgvRol";
            dgvRol.ReadOnly = true;
            dgvRol.RowTemplate.Height = 25;
            dgvRol.Size = new Size(346, 150);
            dgvRol.TabIndex = 6;
            dgvRol.CellContentClick += dgvRol_CellContentClick;
            // 
            // IDRol
            // 
            IDRol.HeaderText = "IDRol";
            IDRol.Name = "IDRol";
            IDRol.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSize = true;
            btnNuevo.Location = new Point(52, 360);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(42, 15);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(159, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(49, 15);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(284, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(53, 15);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 360);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 10;
            label7.Text = "label7";
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 272);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvRol);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtIDRol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRol";
            Text = "frmRol";
            ((System.ComponentModel.ISupportInitialize)dgvRol).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDRol;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private DataGridView dgvRol;
        private DataGridViewTextBoxColumn IDRol;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private Label btnNuevo;
        private Label btnGuardar;
        private Label btnCancelar;
        private Label label7;
        private TextBox txtID;
        private ErrorProvider errorProvider1;
    }
}