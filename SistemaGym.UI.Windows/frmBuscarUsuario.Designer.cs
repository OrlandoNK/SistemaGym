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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBuscarUsuarios = new DataGridView();
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            TxbBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnclose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarUsuarios).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscarUsuarios
            // 
            dgvBuscarUsuarios.AllowUserToAddRows = false;
            dgvBuscarUsuarios.AllowUserToDeleteRows = false;
            dgvBuscarUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarUsuarios.BackgroundColor = Color.White;
            dgvBuscarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarUsuarios.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, IDRol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvBuscarUsuarios.Location = new Point(-1, -1);
            dgvBuscarUsuarios.Name = "dgvBuscarUsuarios";
            dgvBuscarUsuarios.ReadOnly = true;
            dgvBuscarUsuarios.RowHeadersVisible = false;
            dgvBuscarUsuarios.RowTemplate.Height = 25;
            dgvBuscarUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarUsuarios.Size = new Size(855, 391);
            dgvBuscarUsuarios.TabIndex = 4;
            dgvBuscarUsuarios.CellDoubleClick += dgvBuscarUsuarios_CellDoubleClick;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
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
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "Sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contrasena
            // 
            Contrasena.DataPropertyName = "Contrasena";
            Contrasena.HeaderText = "Contraseña";
            Contrasena.Name = "Contrasena";
            Contrasena.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnclose);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 64);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 34);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 32, 39);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TxbBusqueda);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(855, 58);
            panel3.TabIndex = 7;
            // 
            // TxbBusqueda
            // 
            TxbBusqueda.BorderRadius = 20;
            TxbBusqueda.CustomizableEdges = customizableEdges3;
            TxbBusqueda.DefaultText = "";
            TxbBusqueda.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBusqueda.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBusqueda.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBusqueda.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBusqueda.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBusqueda.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBusqueda.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBusqueda.Location = new Point(11, 6);
            TxbBusqueda.Name = "TxbBusqueda";
            TxbBusqueda.PasswordChar = '\0';
            TxbBusqueda.PlaceholderForeColor = Color.Silver;
            TxbBusqueda.PlaceholderText = "Buscar";
            TxbBusqueda.SelectedText = "";
            TxbBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxbBusqueda.Size = new Size(831, 45);
            TxbBusqueda.TabIndex = 0;
            TxbBusqueda.TextChanged += TxbBusqueda_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvBuscarUsuarios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(855, 391);
            panel4.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(76, 20);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 6;
            label8.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuarios__mainScreen;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            btnclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = Properties.Resources._BotonXcerrarVentana;
            btnclose.Location = new Point(810, 15);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(32, 32);
            btnclose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnclose.TabIndex = 7;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // frmBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 547);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscarUsuario";
            Text = "frmBuscarUsuario";
            Load += frmBuscarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBuscarUsuarios;
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox TxbBusqueda;
        private Panel panel4;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox btnclose;
    }
}