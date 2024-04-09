namespace SistemaGym.UI.Windows
{
    partial class mantenimientoUsuarios
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            topPanel = new Panel();
            btnclose = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            subtopPanel = new Panel();
            sidePanel = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            fillpanel = new Panel();
            dgvUsuario = new DataGridView();
            IDUsuario = new DataGridViewTextBoxColumn();
            IDEmpleado = new DataGridViewComboBoxColumn();
            Rol = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasena = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidePanel.SuspendLayout();
            panel5.SuspendLayout();
            fillpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(btnclose);
            topPanel.Controls.Add(label8);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1085, 66);
            topPanel.TabIndex = 0;
            // 
            // btnclose
            // 
            btnclose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = Properties.Resources._BotonXcerrarVentana;
            btnclose.Location = new Point(1040, 16);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(32, 32);
            btnclose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnclose.TabIndex = 5;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(62, 20);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 4;
            label8.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_frmUsuarios__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // subtopPanel
            // 
            subtopPanel.BackColor = Color.DarkGoldenrod;
            subtopPanel.BorderStyle = BorderStyle.FixedSingle;
            subtopPanel.Dock = DockStyle.Top;
            subtopPanel.Location = new Point(0, 66);
            subtopPanel.Name = "subtopPanel";
            subtopPanel.Size = new Size(1085, 31);
            subtopPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Black;
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(btnDelete);
            sidePanel.Controls.Add(btnEdit);
            sidePanel.Controls.Add(btnRefresh);
            sidePanel.Controls.Add(btnNew);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 97);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(208, 588);
            sidePanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 334);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.Transparent;
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(208, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges13;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 276);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.Transparent;
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEdit.Size = new Size(208, 48);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderColor = Color.DarkGoldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.CustomizableEdges = customizableEdges15;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.DarkGoldenrod;
            btnRefresh.HoverState.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 218);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PressedColor = Color.Transparent;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRefresh.Size = new Size(208, 48);
            btnRefresh.TabIndex = 1;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.Cursor = Cursors.Hand;
            btnNew.CustomizableEdges = customizableEdges17;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.DarkGoldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources._NuevaFacturaMembresia;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 160);
            btnNew.Name = "btnNew";
            btnNew.PressedColor = Color.Transparent;
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnNew.Size = new Size(208, 48);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 32, 39);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(208, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(877, 68);
            panel5.TabIndex = 124;
            // 
            // TxbBuscar
            // 
            TxbBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges19;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(11, 14);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            TxbBuscar.Size = new Size(854, 39);
            TxbBuscar.TabIndex = 0;
            TxbBuscar.TextChanged += TxbBuscar_TextChanged;
            // 
            // fillpanel
            // 
            fillpanel.Controls.Add(dgvUsuario);
            fillpanel.Dock = DockStyle.Fill;
            fillpanel.Location = new Point(208, 165);
            fillpanel.Name = "fillpanel";
            fillpanel.Size = new Size(877, 520);
            fillpanel.TabIndex = 125;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.BackgroundColor = Color.WhiteSmoke;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, IDEmpleado, Rol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvUsuario.Dock = DockStyle.Fill;
            dgvUsuario.Location = new Point(0, 0);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(877, 520);
            dgvUsuario.TabIndex = 113;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.FillWeight = 150F;
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            // 
            // IDEmpleado
            // 
            IDEmpleado.DataPropertyName = "IDEmpleado";
            IDEmpleado.FillWeight = 200F;
            IDEmpleado.HeaderText = "IDEmpleado";
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Resizable = DataGridViewTriState.True;
            IDEmpleado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Rol
            // 
            Rol.FillWeight = 200F;
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.Resizable = DataGridViewTriState.True;
            Rol.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 200F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 200F;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "Sexo";
            Sexo.FillWeight = 200F;
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.FillWeight = 200F;
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.FillWeight = 200F;
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            FechaRegistro.FillWeight = 200F;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.FillWeight = 250F;
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            // 
            // Contrasena
            // 
            Contrasena.DataPropertyName = "Contrasena";
            Contrasena.FillWeight = 200F;
            Contrasena.HeaderText = "Contraseña";
            Contrasena.Name = "Contrasena";
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.FillWeight = 200F;
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // mantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(fillpanel);
            Controls.Add(panel5);
            Controls.Add(sidePanel);
            Controls.Add(subtopPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoUsuarios_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidePanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            fillpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel subtopPanel;
        private Panel sidePanel;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Panel fillpanel;
        private PictureBox btnclose;
        private DataGridView dgvUsuario;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn IDEmpleado;
        private DataGridViewComboBoxColumn Rol;
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