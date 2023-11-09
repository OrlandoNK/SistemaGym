namespace SistemaGym.UI.Windows
{
    partial class MantenimientoGrupoCliente
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
            lblEstatus = new Label();
            lblIDCliente = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEstatus = new TextBox();
            txtCliente = new TextBox();
            txtGrupoMembresia = new TextBox();
            txtGrupoCliente = new TextBox();
            dgvGrupoCliente = new DataGridView();
            GrupoCliente = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            GrupoMembresia = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrupoCliente).BeginInit();
            SuspendLayout();
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(32, 164);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 0;
            lblEstatus.Text = "Estatus";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Location = new Point(32, 68);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(44, 15);
            lblIDCliente.TabIndex = 1;
            lblIDCliente.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 118);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Grupo Membresia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 20);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Grupo Cliente";
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(139, 164);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(157, 23);
            txtEstatus.TabIndex = 4;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(139, 68);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(157, 23);
            txtCliente.TabIndex = 5;
            // 
            // txtGrupoMembresia
            // 
            txtGrupoMembresia.Location = new Point(139, 118);
            txtGrupoMembresia.Name = "txtGrupoMembresia";
            txtGrupoMembresia.Size = new Size(157, 23);
            txtGrupoMembresia.TabIndex = 6;
            // 
            // txtGrupoCliente
            // 
            txtGrupoCliente.Location = new Point(139, 20);
            txtGrupoCliente.Name = "txtGrupoCliente";
            txtGrupoCliente.Size = new Size(157, 23);
            txtGrupoCliente.TabIndex = 7;
            // 
            // dgvGrupoCliente
            // 
            dgvGrupoCliente.AllowUserToAddRows = false;
            dgvGrupoCliente.AllowUserToDeleteRows = false;
            dgvGrupoCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoCliente.Columns.AddRange(new DataGridViewColumn[] { GrupoCliente, Cliente, GrupoMembresia, Estatus });
            dgvGrupoCliente.Location = new Point(350, 20);
            dgvGrupoCliente.Name = "dgvGrupoCliente";
            dgvGrupoCliente.ReadOnly = true;
            dgvGrupoCliente.RowTemplate.Height = 25;
            dgvGrupoCliente.Size = new Size(444, 237);
            dgvGrupoCliente.TabIndex = 8;
            // 
            // GrupoCliente
            // 
            GrupoCliente.HeaderText = "GrupoCliente";
            GrupoCliente.Name = "GrupoCliente";
            GrupoCliente.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // GrupoMembresia
            // 
            GrupoMembresia.HeaderText = "GrupoMembresia";
            GrupoMembresia.Name = "GrupoMembresia";
            GrupoMembresia.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(473, 365);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(95, 46);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(594, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 46);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(706, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 46);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(350, 365);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 46);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoGrupoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 532);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(dgvGrupoCliente);
            Controls.Add(txtGrupoCliente);
            Controls.Add(txtGrupoMembresia);
            Controls.Add(txtCliente);
            Controls.Add(txtEstatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIDCliente);
            Controls.Add(lblEstatus);
            Name = "MantenimientoGrupoCliente";
            Text = "MantenimientoGrupoCliente";
            ((System.ComponentModel.ISupportInitialize)dgvGrupoCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstatus;
        private Label lblIDCliente;
        private Label label3;
        private Label label4;
        private TextBox txtEstatus;
        private TextBox txtCliente;
        private TextBox txtGrupoMembresia;
        private TextBox txtGrupoCliente;
        private DataGridView dgvGrupoCliente;
        private DataGridViewTextBoxColumn GrupoCliente;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn GrupoMembresia;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}