namespace SistemaGym.UI.Windows
{
    partial class MantenimientoCargoDebito
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
            lblCargoDebito = new Label();
            lblFechaCargo = new Label();
            lblMonto = new Label();
            lblCliente = new Label();
            lblCargo = new Label();
            txtIDCargoDebito = new TextBox();
            txtcliente = new TextBox();
            txtMonto = new TextBox();
            txtCargo = new TextBox();
            txtFechaCargo = new TextBox();
            txtEstatus = new TextBox();
            lblEstatus = new Label();
            dgvCargoDebito = new DataGridView();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaCargo = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCargoDebito).BeginInit();
            SuspendLayout();
            // 
            // lblCargoDebito
            // 
            lblCargoDebito.AutoSize = true;
            lblCargoDebito.Location = new Point(28, 15);
            lblCargoDebito.Name = "lblCargoDebito";
            lblCargoDebito.Size = new Size(85, 15);
            lblCargoDebito.TabIndex = 0;
            lblCargoDebito.Text = "IDCargoDebito";
            // 
            // lblFechaCargo
            // 
            lblFechaCargo.AutoSize = true;
            lblFechaCargo.Location = new Point(28, 184);
            lblFechaCargo.Name = "lblFechaCargo";
            lblFechaCargo.Size = new Size(73, 15);
            lblFechaCargo.TabIndex = 1;
            lblFechaCargo.Text = "Fecha Cargo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(28, 140);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(28, 55);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(28, 98);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 4;
            lblCargo.Text = "Cargo";
            // 
            // txtIDCargoDebito
            // 
            txtIDCargoDebito.Location = new Point(152, 12);
            txtIDCargoDebito.Name = "txtIDCargoDebito";
            txtIDCargoDebito.Size = new Size(100, 23);
            txtIDCargoDebito.TabIndex = 5;
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(152, 48);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(100, 23);
            txtcliente.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(152, 133);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 7;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(152, 87);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 8;
            // 
            // txtFechaCargo
            // 
            txtFechaCargo.Location = new Point(152, 176);
            txtFechaCargo.Name = "txtFechaCargo";
            txtFechaCargo.Size = new Size(100, 23);
            txtFechaCargo.TabIndex = 9;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(152, 215);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(100, 23);
            txtEstatus.TabIndex = 10;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(28, 218);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 11;
            lblEstatus.Text = "Estatus";
            // 
            // dgvCargoDebito
            // 
            dgvCargoDebito.AllowUserToAddRows = false;
            dgvCargoDebito.AllowUserToDeleteRows = false;
            dgvCargoDebito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargoDebito.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, Cargo, Monto, FechaCargo, Estatus, Column1 });
            dgvCargoDebito.Location = new Point(331, 12);
            dgvCargoDebito.Name = "dgvCargoDebito";
            dgvCargoDebito.ReadOnly = true;
            dgvCargoDebito.RowTemplate.Height = 25;
            dgvCargoDebito.Size = new Size(451, 236);
            dgvCargoDebito.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(472, 345);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(587, 345);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(331, 345);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(707, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // FechaCargo
            // 
            FechaCargo.HeaderText = "FechaCargo";
            FechaCargo.Name = "FechaCargo";
            FechaCargo.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // MantenimientoCargoDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 518);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(dgvCargoDebito);
            Controls.Add(lblEstatus);
            Controls.Add(txtEstatus);
            Controls.Add(txtFechaCargo);
            Controls.Add(txtCargo);
            Controls.Add(txtMonto);
            Controls.Add(txtcliente);
            Controls.Add(txtIDCargoDebito);
            Controls.Add(lblCargo);
            Controls.Add(lblCliente);
            Controls.Add(lblMonto);
            Controls.Add(lblFechaCargo);
            Controls.Add(lblCargoDebito);
            Name = "MantenimientoCargoDebito";
            Text = "MantenimientoCargoDebito";
            ((System.ComponentModel.ISupportInitialize)dgvCargoDebito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCargoDebito;
        private Label lblFechaCargo;
        private Label lblMonto;
        private Label lblCliente;
        private Label lblCargo;
        private TextBox txtIDCargoDebito;
        private TextBox txtcliente;
        private TextBox txtMonto;
        private TextBox txtCargo;
        private TextBox txtFechaCargo;
        private TextBox txtEstatus;
        private Label lblEstatus;
        private DataGridView dgvCargoDebito;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaCargo;
        private DataGridViewTextBoxColumn Estatus;
        private DataGridViewTextBoxColumn Column1;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}