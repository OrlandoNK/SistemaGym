namespace SistemaGym.UI.Windows
{
    partial class frmBuscarUsuario
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
            txtBuscarUsuario = new TextBox();
            dgvBuscarUsuarios = new DataGridView();
            label1 = new Label();
            IDUsuario = new DataGridViewTextBoxColumn();
            IDRol = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasena = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(283, 45);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(354, 20);
            txtBuscarUsuario.TabIndex = 5;
            // 
            // dgvBuscarUsuarios
            // 
            dgvBuscarUsuarios.AllowUserToAddRows = false;
            dgvBuscarUsuarios.AllowUserToDeleteRows = false;
            dgvBuscarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarUsuarios.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, IDRol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvBuscarUsuarios.Location = new Point(28, 80);
            dgvBuscarUsuarios.Name = "dgvBuscarUsuarios";
            dgvBuscarUsuarios.ReadOnly = true;
            dgvBuscarUsuarios.RowTemplate.Height = 25;
            dgvBuscarUsuarios.Size = new Size(935, 456);
            dgvBuscarUsuarios.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 48);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 3;
            label1.Text = "Introduzca los datos a buscar";
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "ID";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            // 
            // IDRol
            // 
            IDRol.HeaderText = "Rol";
            IDRol.Name = "IDRol";
            IDRol.ReadOnly = true;
            IDRol.Resizable = DataGridViewTriState.True;
            IDRol.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contrasena
            // 
            Contrasena.HeaderText = "Contraseña";
            Contrasena.Name = "Contrasena";
            Contrasena.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // frmBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 548);
            Controls.Add(txtBuscarUsuario);
            Controls.Add(dgvBuscarUsuarios);
            Controls.Add(label1);
            Name = "frmBuscarUsuario";
            Text = "frmBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvBuscarUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarUsuario;
        private DataGridView dgvBuscarUsuarios;
        private Label label1;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn IDRol;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contrasena;
        private DataGridViewTextBoxColumn Estatus;
    }
}