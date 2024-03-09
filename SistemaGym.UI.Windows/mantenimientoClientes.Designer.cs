namespace SistemaGym.UI.Windows
{
    partial class frmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtTelRes = new TextBox();
            txtTelCell = new TextBox();
            txtDireccion = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtidcliente = new TextBox();
            dgvCliente = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            IDTipoListaCliente = new DataGridViewComboBoxColumn();
            IDTipoCliente = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TelCell = new DataGridViewTextBoxColumn();
            TelRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
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
            cbMembresia = new ComboBox();
            cbTipoCliente = new ComboBox();
            cbTipoDocumento = new ComboBox();
            cbUsuario = new ComboBox();
            cbTipoListaCliente = new ComboBox();
            cbEstatus = new ComboBox();
            btnGuardar = new Button();
            dtpFechaRegistro = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtTelRes
            // 
            txtTelRes.Location = new Point(105, 376);
            txtTelRes.Multiline = true;
            txtTelRes.Name = "txtTelRes";
            txtTelRes.Size = new Size(100, 20);
            txtTelRes.TabIndex = 84;
            // 
            // txtTelCell
            // 
            txtTelCell.Location = new Point(105, 350);
            txtTelCell.Multiline = true;
            txtTelCell.Name = "txtTelCell";
            txtTelCell.Size = new Size(100, 20);
            txtTelCell.TabIndex = 83;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(105, 322);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 20);
            txtDireccion.TabIndex = 82;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(105, 292);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 20);
            txtDocumento.TabIndex = 81;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(105, 230);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 20);
            txtApellido.TabIndex = 79;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 191);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 20);
            txtNombre.TabIndex = 78;
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(105, 38);
            txtidcliente.Multiline = true;
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(32, 25);
            txtidcliente.TabIndex = 73;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeight = 22;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, IDTipoListaCliente, IDTipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus });
            dgvCliente.Location = new Point(285, 48);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(702, 410);
            dgvCliente.TabIndex = 72;
            dgvCliente.CellClick += dgvCliente_CellClick;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDMembresia
            // 
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoListaCliente
            // 
            IDTipoListaCliente.HeaderText = "Tipo Lista Cliente";
            IDTipoListaCliente.Name = "IDTipoListaCliente";
            IDTipoListaCliente.ReadOnly = true;
            IDTipoListaCliente.Resizable = DataGridViewTriState.True;
            IDTipoListaCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.HeaderText = "Tipo Cliente";
            IDTipoCliente.Name = "IDTipoCliente";
            IDTipoCliente.ReadOnly = true;
            IDTipoCliente.Resizable = DataGridViewTriState.True;
            IDTipoCliente.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // TelCell
            // 
            TelCell.DataPropertyName = "TelCell";
            TelCell.HeaderText = "TelCell";
            TelCell.Name = "TelCell";
            TelCell.ReadOnly = true;
            // 
            // TelRes
            // 
            TelRes.DataPropertyName = "TelRes";
            TelRes.HeaderText = "TelRes";
            TelRes.Name = "TelRes";
            TelRes.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 433);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 71;
            label14.Text = "Estatus";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 405);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 70;
            label13.Text = "Fecha Registro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 380);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 69;
            label12.Text = "TelRes";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 353);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 68;
            label11.Text = "TelCell";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 325);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 67;
            label10.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 297);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 66;
            label9.Text = "Documento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 268);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 65;
            label8.Text = "Tipo Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 233);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 64;
            label7.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 196);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 63;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 164);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 62;
            label5.Text = "Tipo Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 134);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 61;
            label4.Text = "Tipo Lista Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 60;
            label3.Text = "Membresia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 77);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 59;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 48);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 58;
            label1.Text = "ID CLiente";
            // 
            // cbMembresia
            // 
            cbMembresia.FormattingEnabled = true;
            cbMembresia.Location = new Point(105, 98);
            cbMembresia.Name = "cbMembresia";
            cbMembresia.Size = new Size(100, 23);
            cbMembresia.TabIndex = 87;
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(105, 156);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(100, 23);
            cbTipoCliente.TabIndex = 88;
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "Cedula", "Pasaporte" });
            cbTipoDocumento.Location = new Point(105, 260);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(100, 23);
            cbTipoDocumento.TabIndex = 89;
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(105, 69);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(100, 23);
            cbUsuario.TabIndex = 90;
            // 
            // cbTipoListaCliente
            // 
            cbTipoListaCliente.FormattingEnabled = true;
            cbTipoListaCliente.Location = new Point(105, 127);
            cbTipoListaCliente.Name = "cbTipoListaCliente";
            cbTipoListaCliente.Size = new Size(100, 23);
            cbTipoListaCliente.TabIndex = 91;
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstatus.Location = new Point(105, 433);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(100, 23);
            cbEstatus.TabIndex = 92;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 94;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(105, 404);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(100, 23);
            dtpFechaRegistro.TabIndex = 96;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 526);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(btnGuardar);
            Controls.Add(cbEstatus);
            Controls.Add(cbTipoListaCliente);
            Controls.Add(cbUsuario);
            Controls.Add(cbTipoDocumento);
            Controls.Add(cbTipoCliente);
            Controls.Add(cbMembresia);
            Controls.Add(txtTelRes);
            Controls.Add(txtTelCell);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtidcliente);
            Controls.Add(dgvCliente);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTelRes;
        private TextBox txtTelCell;
        private TextBox txtDireccion;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtidcliente;
        private DataGridView dgvCliente;
        private Label label14;
        private Label label13;
        private Label label12;
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
        private ComboBox cbMembresia;
        private ComboBox cbTipoCliente;
        private ComboBox cbTipoDocumento;
        private ComboBox cbUsuario;
        private ComboBox cbTipoListaCliente;
        private ComboBox cbEstatus;
        private Button btnGuardar;
        private DateTimePicker dtpFechaRegistro;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewComboBoxColumn IDTipoListaCliente;
        private DataGridViewComboBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TelCell;
        private DataGridViewTextBoxColumn TelRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}