namespace SistemaGym.UI.Windows
{
    partial class nuevoCliente
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            cbTipoListaCliente = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbTipoCliente = new ComboBox();
            label5 = new Label();
            cbMembresia = new ComboBox();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            dtpFechaRegistro = new DateTimePicker();
            cbEstatus = new ComboBox();
            label14 = new Label();
            cbTipoDocumento = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            txtDocumento = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label13 = new Label();
            label10 = new Label();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            label11 = new Label();
            txtTelCell = new TextBox();
            label12 = new Label();
            txtTelRes = new TextBox();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 60);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 39);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 458);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 458);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(cbTipoListaCliente);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbTipoCliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbMembresia);
            groupBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(9, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(662, 175);
            groupBox2.TabIndex = 126;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Relacionados al Cliente";
            // 
            // label1
            // 
            label1.Location = new Point(168, 108);
            label1.Name = "label1";
            label1.Size = new Size(326, 19);
            label1.TabIndex = 124;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(168, 130);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(326, 25);
            txtUsuario.TabIndex = 123;
            // 
            // cbTipoListaCliente
            // 
            cbTipoListaCliente.FormattingEnabled = true;
            cbTipoListaCliente.Location = new Point(281, 61);
            cbTipoListaCliente.Name = "cbTipoListaCliente";
            cbTipoListaCliente.Size = new Size(100, 25);
            cbTipoListaCliente.TabIndex = 122;
            // 
            // label3
            // 
            label3.Location = new Point(119, 38);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 99;
            label3.Text = "Membresia";
            // 
            // label4
            // 
            label4.Location = new Point(281, 39);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 100;
            label4.Text = "Tipo Lista Cliente";
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(443, 61);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(100, 25);
            cbTipoCliente.TabIndex = 119;
            // 
            // label5
            // 
            label5.Location = new Point(443, 39);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 101;
            label5.Text = "Tipo Cliente";
            // 
            // cbMembresia
            // 
            cbMembresia.FormattingEnabled = true;
            cbMembresia.Location = new Point(119, 61);
            cbMembresia.Name = "cbMembresia";
            cbMembresia.Size = new Size(100, 25);
            cbMembresia.TabIndex = 118;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(dtpFechaRegistro);
            groupBox1.Controls.Add(cbEstatus);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cbTipoDocumento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTelCell);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTelRes);
            groupBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 259);
            groupBox1.TabIndex = 125;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales del Cliente";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(363, 76);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 25);
            txtNombre.TabIndex = 112;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(6, 226);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.RightToLeft = RightToLeft.No;
            dtpFechaRegistro.Size = new Size(158, 23);
            dtpFechaRegistro.TabIndex = 124;
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstatus.Location = new Point(520, 228);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(136, 25);
            cbEstatus.TabIndex = 123;
            // 
            // label14
            // 
            label14.Location = new Point(520, 207);
            label14.Name = "label14";
            label14.Size = new Size(136, 18);
            label14.TabIndex = 110;
            label14.Text = "Estatus";
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "Cedula", "Pasaporte" });
            cbTipoDocumento.Location = new Point(93, 76);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(129, 25);
            cbTipoDocumento.TabIndex = 120;
            // 
            // label6
            // 
            label6.Location = new Point(363, 55);
            label6.Name = "label6";
            label6.Size = new Size(100, 18);
            label6.TabIndex = 102;
            label6.Text = "Nombre";
            // 
            // label8
            // 
            label8.Location = new Point(93, 55);
            label8.Name = "label8";
            label8.Size = new Size(129, 18);
            label8.TabIndex = 104;
            label8.Text = "Tipo Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(228, 76);
            txtDocumento.Multiline = true;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(129, 25);
            txtDocumento.TabIndex = 114;
            // 
            // label7
            // 
            label7.Location = new Point(469, 55);
            label7.Name = "label7";
            label7.Size = new Size(100, 18);
            label7.TabIndex = 103;
            label7.Text = "Apellido";
            // 
            // label9
            // 
            label9.Location = new Point(228, 55);
            label9.Name = "label9";
            label9.Size = new Size(129, 18);
            label9.TabIndex = 105;
            label9.Text = "Documento";
            // 
            // label13
            // 
            label13.Location = new Point(6, 205);
            label13.Name = "label13";
            label13.Size = new Size(158, 18);
            label13.TabIndex = 109;
            label13.Text = "Fecha Registro";
            // 
            // label10
            // 
            label10.Location = new Point(175, 117);
            label10.Name = "label10";
            label10.Size = new Size(100, 18);
            label10.TabIndex = 106;
            label10.Text = "Direccion";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(469, 76);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 25);
            txtApellido.TabIndex = 113;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(175, 138);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 25);
            txtDireccion.TabIndex = 115;
            // 
            // label11
            // 
            label11.Location = new Point(281, 117);
            label11.Name = "label11";
            label11.Size = new Size(100, 18);
            label11.TabIndex = 107;
            label11.Text = "TelCell";
            // 
            // txtTelCell
            // 
            txtTelCell.Location = new Point(281, 138);
            txtTelCell.Multiline = true;
            txtTelCell.Name = "txtTelCell";
            txtTelCell.Size = new Size(100, 25);
            txtTelCell.TabIndex = 116;
            // 
            // label12
            // 
            label12.Location = new Point(387, 117);
            label12.Name = "label12";
            label12.Size = new Size(100, 18);
            label12.TabIndex = 108;
            label12.Text = "TelRes";
            // 
            // txtTelRes
            // 
            txtTelRes.Location = new Point(387, 138);
            txtTelRes.Multiline = true;
            txtTelRes.Name = "txtTelRes";
            txtTelRes.Size = new Size(100, 25);
            txtTelRes.TabIndex = 117;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderColor = Color.DarkGoldenrod;
            btnGuardar.BorderThickness = 1;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = customizableEdges3;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.Transparent;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.DarkGoldenrod;
            btnGuardar.HoverState.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources._SaveFacturaProduct;
            btnGuardar.ImageSize = new Size(25, 25);
            btnGuardar.Location = new Point(-1, 44);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedColor = Color.Transparent;
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGuardar.Size = new Size(204, 55);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "&Guardar";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._BotonXcerrarVentana;
            pictureBox1.Location = new Point(832, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // nuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 557);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "nuevoCliente";
            Load += nuevoCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker dtpFechaRegistro;
        private ComboBox cbEstatus;
        private ComboBox cbTipoListaCliente;
        private ComboBox cbTipoDocumento;
        private ComboBox cbTipoCliente;
        private ComboBox cbMembresia;
        private TextBox txtTelRes;
        private TextBox txtTelCell;
        private TextBox txtDireccion;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private TextBox txtNombre;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private PictureBox pictureBox1;
    }
}