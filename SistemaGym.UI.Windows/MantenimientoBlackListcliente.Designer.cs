namespace SistemaGym.UI.Windows
{
    partial class MantenimientoBlackListcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoBlackListcliente));
            lblIDBlackListCliente = new Label();
            lblCliente = new Label();
            lblRazones = new Label();
            lblListaCliente = new Label();
            lblFechaInicio = new Label();
            lblFechaVencimiento = new Label();
            lblEstatus = new Label();
            txtIDBlackListCliente = new TextBox();
            txtCliente = new TextBox();
            txtListaClientes = new TextBox();
            txtRazones = new TextBox();
            txtFechaInicio = new TextBox();
            txtFechaVencimiento = new TextBox();
            txtEstatus = new TextBox();
            dgvBlackListCliente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            ListaClientes = new DataGridViewTextBoxColumn();
            Razones = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBlackListCliente).BeginInit();
            SuspendLayout();
            // 
            // lblIDBlackListCliente
            // 
            lblIDBlackListCliente.AutoSize = true;
            lblIDBlackListCliente.Location = new Point(12, 20);
            lblIDBlackListCliente.Name = "lblIDBlackListCliente";
            lblIDBlackListCliente.Size = new Size(110, 15);
            lblIDBlackListCliente.TabIndex = 0;
            lblIDBlackListCliente.Text = "ID Black List Cliente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 60);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblRazones
            // 
            lblRazones.AutoSize = true;
            lblRazones.Location = new Point(12, 139);
            lblRazones.Name = "lblRazones";
            lblRazones.Size = new Size(50, 15);
            lblRazones.TabIndex = 2;
            lblRazones.Text = "Razones";
            // 
            // lblListaCliente
            // 
            lblListaCliente.AutoSize = true;
            lblListaCliente.Location = new Point(12, 98);
            lblListaCliente.Name = "lblListaCliente";
            lblListaCliente.Size = new Size(76, 15);
            lblListaCliente.TabIndex = 3;
            lblListaCliente.Text = "Lista Clientes";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(12, 175);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(12, 209);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(107, 15);
            lblFechaVencimiento.TabIndex = 5;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(12, 246);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus";
            // 
            // txtIDBlackListCliente
            // 
            txtIDBlackListCliente.Location = new Point(128, 17);
            txtIDBlackListCliente.Name = "txtIDBlackListCliente";
            txtIDBlackListCliente.Size = new Size(156, 23);
            txtIDBlackListCliente.TabIndex = 7;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(128, 52);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(156, 23);
            txtCliente.TabIndex = 8;
            // 
            // txtListaClientes
            // 
            txtListaClientes.Location = new Point(128, 95);
            txtListaClientes.Name = "txtListaClientes";
            txtListaClientes.Size = new Size(156, 23);
            txtListaClientes.TabIndex = 9;
            // 
            // txtRazones
            // 
            txtRazones.Location = new Point(128, 131);
            txtRazones.Name = "txtRazones";
            txtRazones.Size = new Size(156, 23);
            txtRazones.TabIndex = 10;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(128, 167);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(156, 23);
            txtFechaInicio.TabIndex = 11;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(128, 201);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(156, 23);
            txtFechaVencimiento.TabIndex = 12;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(128, 243);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(156, 23);
            txtEstatus.TabIndex = 13;
            // 
            // dgvBlackListCliente
            // 
            dgvBlackListCliente.AllowUserToAddRows = false;
            dgvBlackListCliente.AllowUserToDeleteRows = false;
            dgvBlackListCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlackListCliente.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, ListaClientes, Razones, FechaInicio, FechaVencimiento, Estatus });
            dgvBlackListCliente.Location = new Point(300, 17);
            dgvBlackListCliente.Name = "dgvBlackListCliente";
            dgvBlackListCliente.ReadOnly = true;
            dgvBlackListCliente.RowTemplate.Height = 25;
            dgvBlackListCliente.Size = new Size(700, 249);
            dgvBlackListCliente.TabIndex = 14;
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
            // ListaClientes
            // 
            ListaClientes.HeaderText = "ListaClientes";
            ListaClientes.Name = "ListaClientes";
            ListaClientes.ReadOnly = true;
            // 
            // Razones
            // 
            Razones.HeaderText = "Razones";
            Razones.Name = "Razones";
            Razones.ReadOnly = true;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "FechaInicio";
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(300, 336);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 53);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(468, 336);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 53);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(640, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 53);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(797, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 53);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoBlackListcliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvBlackListCliente);
            Controls.Add(txtEstatus);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtRazones);
            Controls.Add(txtListaClientes);
            Controls.Add(txtCliente);
            Controls.Add(txtIDBlackListCliente);
            Controls.Add(lblEstatus);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblListaCliente);
            Controls.Add(lblRazones);
            Controls.Add(lblCliente);
            Controls.Add(lblIDBlackListCliente);
            Name = "MantenimientoBlackListcliente";
            Text = "MantenimientoBlackListcliente";
            ((System.ComponentModel.ISupportInitialize)dgvBlackListCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDBlackListCliente;
        private Label lblCliente;
        private Label lblRazones;
        private Label lblListaCliente;
        private Label lblFechaInicio;
        private Label lblFechaVencimiento;
        private Label lblEstatus;
        private TextBox txtIDBlackListCliente;
        private TextBox txtCliente;
        private TextBox txtListaClientes;
        private TextBox txtRazones;
        private TextBox txtFechaInicio;
        private TextBox txtFechaVencimiento;
        private TextBox txtEstatus;
        private DataGridView dgvBlackListCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn ListaClientes;
        private DataGridViewTextBoxColumn Razones;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
    }
}