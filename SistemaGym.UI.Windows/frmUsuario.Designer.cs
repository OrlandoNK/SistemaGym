namespace SistemaGym.UI.Windows
{
    partial class frmUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtDireccion = new TextBox();
            txtContrasena = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtSexo = new TextBox();
            txtNombreUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtIDUsuario = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUsuario = new DataGridView();
            IDUsuario = new DataGridViewTextBoxColumn();
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
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            cbRol = new ComboBox();
            errorProvider = new ErrorProvider(components);
            panel1 = new Panel();
            btnclose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnEditar = new Button();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(18, 256);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(240, 25);
            txtDireccion.TabIndex = 110;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(141, 325);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(117, 23);
            txtContrasena.TabIndex = 109;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(18, 202);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(117, 20);
            txtApellido.TabIndex = 107;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 145);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 20);
            txtNombre.TabIndex = 106;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(141, 145);
            txtSexo.Multiline = true;
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(117, 20);
            txtSexo.TabIndex = 105;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(18, 325);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(117, 23);
            txtNombreUsuario.TabIndex = 104;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(141, 202);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(117, 20);
            txtCorreo.TabIndex = 103;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(18, 82);
            txtIDUsuario.Multiline = true;
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(117, 23);
            txtIDUsuario.TabIndex = 101;
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(141, 300);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 96;
            label10.Text = "Contraseña";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 300);
            label9.Name = "label9";
            label9.Size = new Size(117, 22);
            label9.TabIndex = 95;
            label9.Text = "Nombre de Usuario";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 231);
            label7.Name = "label7";
            label7.Size = new Size(240, 22);
            label7.TabIndex = 93;
            label7.Text = "Direccion";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(141, 177);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 92;
            label6.Text = "Correo";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(141, 120);
            label5.Name = "label5";
            label5.Size = new Size(117, 22);
            label5.TabIndex = 91;
            label5.Text = "Sexo";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 177);
            label4.Name = "label4";
            label4.Size = new Size(117, 22);
            label4.TabIndex = 90;
            label4.Text = "Apellido";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 120);
            label3.Name = "label3";
            label3.Size = new Size(117, 22);
            label3.TabIndex = 89;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(141, 57);
            label2.Name = "label2";
            label2.Size = new Size(117, 22);
            label2.TabIndex = 88;
            label2.Text = "Rol";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(117, 22);
            label1.TabIndex = 87;
            label1.Text = "ID Usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUsuario.BackgroundColor = Color.WhiteSmoke;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, Rol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvUsuario.Location = new Point(-1, -1);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(487, 436);
            dgvUsuario.TabIndex = 112;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Width = 83;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Resizable = DataGridViewTriState.True;
            Rol.SortMode = DataGridViewColumnSortMode.Automatic;
            Rol.Width = 49;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 76;
            // 
            // Sexo
            // 
            Sexo.DataPropertyName = "Sexo";
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 57;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 68;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 82;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 106;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 116;
            // 
            // Contrasena
            // 
            Contrasena.DataPropertyName = "Contrasena";
            Contrasena.HeaderText = "Contraseña";
            Contrasena.Name = "Contrasena";
            Contrasena.ReadOnly = true;
            Contrasena.Width = 92;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 69;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(18, 373);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(240, 33);
            btnNuevo.TabIndex = 113;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(18, 412);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(240, 33);
            btnGuardar.TabIndex = 114;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = Properties.Resources._EliminarFacturaMembresia;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(-1, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 43);
            btnEliminar.TabIndex = 115;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(141, 82);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(117, 23);
            cbRol.TabIndex = 116;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnclose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 61);
            panel1.TabIndex = 119;
            // 
            // btnclose
            // 
            btnclose.Cursor = Cursors.Hand;
            btnclose.Image = Properties.Resources._BotonXcerrarVentana;
            btnclose.Location = new Point(920, 13);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(32, 32);
            btnclose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnclose.TabIndex = 0;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 33);
            panel2.TabIndex = 120;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnNuevo);
            panel3.Controls.Add(cbRol);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtIDUsuario);
            panel3.Controls.Add(txtDireccion);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtContrasena);
            panel3.Controls.Add(txtNombreUsuario);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(txtSexo);
            panel3.Controls.Add(txtNombre);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 504);
            panel3.TabIndex = 121;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnEditar);
            panel4.Controls.Add(btnEliminar);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(765, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 504);
            panel4.TabIndex = 122;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources._EditarFacturaMembresia;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(-1, 205);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 43);
            btnEditar.TabIndex = 116;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(278, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(487, 68);
            panel5.TabIndex = 123;
            // 
            // TxbBuscar
            // 
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges1;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(5, 14);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxbBuscar.Size = new Size(475, 39);
            TxbBuscar.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvUsuario);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(278, 162);
            panel6.Name = "panel6";
            panel6.Size = new Size(487, 436);
            panel6.TabIndex = 124;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuarios__mainScreen;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(76, 17);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 2;
            label8.Text = "Usuarios";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 598);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtEstatus;
        private TextBox txtDireccion;
        private TextBox txtContrasena;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtSexo;
        private TextBox txtNombreUsuario;
        private TextBox txtCorreo;
        private TextBox txtIDUsuario;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvUsuario;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox cbRol;
        private DataGridViewTextBoxColumn IDUsuario;
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
        private ErrorProvider errorProvider;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnEditar;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private PictureBox btnclose;
        private Label label8;
        private PictureBox pictureBox1;
    }
}