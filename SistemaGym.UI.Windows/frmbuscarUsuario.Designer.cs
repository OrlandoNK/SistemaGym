namespace SistemaGym.UI.Windows
{
    partial class frmbuscarUsuario
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
            dgvUsuarioList = new DataGridView();
            IDUsuario = new DataGridViewTextBoxColumn();
            IDRol = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasena = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarioList).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarioList
            // 
            dgvUsuarioList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUsuarioList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarioList.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, IDRol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvUsuarioList.Location = new Point(27, 43);
            dgvUsuarioList.Name = "dgvUsuarioList";
            dgvUsuarioList.RowHeadersVisible = false;
            dgvUsuarioList.RowTemplate.Height = 25;
            dgvUsuarioList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarioList.Size = new Size(777, 428);
            dgvUsuarioList.TabIndex = 0;
            dgvUsuarioList.CellDoubleClick += dgvUsuarioList_CellDoubleClick;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Width = 83;
            // 
            // IDRol
            // 
            IDRol.DataPropertyName = "IDRol";
            IDRol.HeaderText = "IDRol";
            IDRol.Name = "IDRol";
            IDRol.Width = 60;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 76;
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "Sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.Width = 57;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.Width = 68;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 82;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 106;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Width = 116;
            // 
            // Contrasena
            // 
            Contrasena.DataPropertyName = "Contrasena";
            Contrasena.HeaderText = "Contrasena";
            Contrasena.Name = "Contrasena";
            Contrasena.Width = 92;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.Width = 69;
            // 
            // frmbuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 514);
            Controls.Add(dgvUsuarioList);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmbuscarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmbuscarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarioList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarioList;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn IDRol;
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