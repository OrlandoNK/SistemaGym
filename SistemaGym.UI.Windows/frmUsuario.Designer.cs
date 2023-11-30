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
            txtDireccion = new TextBox();
            txtContrasena = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtSexo = new TextBox();
            txtNombreUsuario = new TextBox();
            txtCorreo = new TextBox();
            txtIDUsuario = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
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
            cbEstatus = new ComboBox();
            dtpFechaRegistro = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 252);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 20);
            txtDireccion.TabIndex = 110;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(122, 342);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 20);
            txtContrasena.TabIndex = 109;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 152);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 20);
            txtApellido.TabIndex = 107;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 126);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 20);
            txtNombre.TabIndex = 106;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(122, 183);
            txtSexo.Multiline = true;
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 20);
            txtSexo.TabIndex = 105;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(122, 316);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 20);
            txtNombreUsuario.TabIndex = 104;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(122, 217);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 20);
            txtCorreo.TabIndex = 103;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(122, 62);
            txtIDUsuario.Multiline = true;
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.ReadOnly = true;
            txtIDUsuario.Size = new Size(29, 25);
            txtIDUsuario.TabIndex = 101;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 377);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 97;
            label11.Text = "Estatus";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 349);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 96;
            label10.Text = "Contraseña";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 321);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 95;
            label9.Text = "NombreUsuario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 292);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 94;
            label8.Text = "FechaRegistro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 257);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 93;
            label7.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 220);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 92;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 188);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 91;
            label5.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 158);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 90;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 89;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 101);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 88;
            label2.Text = "Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 72);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 87;
            label1.Text = "ID Usuario";
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, Rol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro, NombreUsuario, Contrasena, Estatus });
            dgvUsuario.Location = new Point(308, 54);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.Size = new Size(720, 410);
            dgvUsuario.TabIndex = 112;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Resizable = DataGridViewTriState.True;
            Rol.SortMode = DataGridViewColumnSortMode.Automatic;
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
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btnNuevo
            // 
            btnNuevo.Location = new Point(16, 441);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 113;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(110, 441);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 114;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(211, 441);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 115;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(122, 97);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(100, 23);
            cbRol.TabIndex = 116;
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstatus.Location = new Point(122, 369);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(100, 23);
            cbEstatus.TabIndex = 117;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(122, 285);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(100, 23);
            dtpFechaRegistro.TabIndex = 118;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 598);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(cbEstatus);
            Controls.Add(cbRol);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvUsuario);
            Controls.Add(txtDireccion);
            Controls.Add(txtContrasena);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtSexo);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(txtIDUsuario);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
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
        private ComboBox cbEstatus;
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
        private DateTimePicker dtpFechaRegistro;
        private ErrorProvider errorProvider;
    }
}