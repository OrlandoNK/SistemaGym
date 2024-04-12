namespace SistemaGym.UI.Windows
{
    partial class registrarAsistenciaClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAssistanceSave = new Guna.UI2.WinForms.Guna2Button();
            groupBox1 = new GroupBox();
            rbtnAsistio = new CheckBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            btnBuscarIDCliente = new Guna.UI2.WinForms.Guna2Button();
            TxbIDCliente = new TextBox();
            label4 = new Label();
            label6 = new Label();
            TxbApellidoCliente = new TextBox();
            TxbDocumentoCliente = new TextBox();
            TxbTipoDocumento = new TextBox();
            label38 = new Label();
            label5 = new Label();
            TxbNombreCliente = new TextBox();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 71);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources._BotonXcerrarVentana;
            btnCerrar.Location = new Point(599, 18);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_asistencia_clientes_gym__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.DarkGoldenrod;
            guna2HtmlLabel1.Location = new Point(72, 21);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(174, 27);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Asistencia Clientes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 32, 39);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnAssistanceSave);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(644, 386);
            panel3.TabIndex = 2;
            // 
            // btnAssistanceSave
            // 
            btnAssistanceSave.BorderColor = Color.White;
            btnAssistanceSave.BorderRadius = 3;
            btnAssistanceSave.BorderThickness = 2;
            btnAssistanceSave.Cursor = Cursors.Hand;
            btnAssistanceSave.CustomizableEdges = customizableEdges1;
            btnAssistanceSave.DisabledState.BorderColor = Color.DarkGray;
            btnAssistanceSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAssistanceSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAssistanceSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAssistanceSave.FillColor = Color.Transparent;
            btnAssistanceSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssistanceSave.ForeColor = Color.White;
            btnAssistanceSave.Image = Properties.Resources.icon_save_button__x32_;
            btnAssistanceSave.ImageSize = new Size(32, 32);
            btnAssistanceSave.Location = new Point(191, 324);
            btnAssistanceSave.Name = "btnAssistanceSave";
            btnAssistanceSave.PressedColor = Color.Transparent;
            btnAssistanceSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAssistanceSave.Size = new Size(448, 55);
            btnAssistanceSave.TabIndex = 19;
            btnAssistanceSave.Text = "Guardar Asistencia";
            btnAssistanceSave.Click += btnAssistanceSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnAsistio);
            groupBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 217);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asistencia";
            // 
            // rbtnAsistio
            // 
            rbtnAsistio.CheckAlign = ContentAlignment.MiddleRight;
            rbtnAsistio.Cursor = Cursors.Hand;
            rbtnAsistio.FlatAppearance.BorderSize = 0;
            rbtnAsistio.FlatAppearance.CheckedBackColor = Color.Transparent;
            rbtnAsistio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rbtnAsistio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rbtnAsistio.Image = Properties.Resources.icon_check_asistencia_true__x32_;
            rbtnAsistio.ImageAlign = ContentAlignment.MiddleLeft;
            rbtnAsistio.Location = new Point(7, 54);
            rbtnAsistio.Name = "rbtnAsistio";
            rbtnAsistio.Size = new Size(169, 44);
            rbtnAsistio.TabIndex = 0;
            rbtnAsistio.Text = "Asistió";
            rbtnAsistio.TextAlign = ContentAlignment.MiddleCenter;
            rbtnAsistio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnBuscarIDCliente);
            groupBox2.Controls.Add(TxbIDCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxbApellidoCliente);
            groupBox2.Controls.Add(TxbDocumentoCliente);
            groupBox2.Controls.Add(TxbTipoDocumento);
            groupBox2.Controls.Add(label38);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxbNombreCliente);
            groupBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(636, 155);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Cliente";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(260, 24);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 15;
            label7.Text = "Apellido";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarIDCliente
            // 
            btnBuscarIDCliente.BorderColor = Color.White;
            btnBuscarIDCliente.BorderRadius = 5;
            btnBuscarIDCliente.BorderThickness = 2;
            btnBuscarIDCliente.Cursor = Cursors.Hand;
            btnBuscarIDCliente.CustomizableEdges = customizableEdges3;
            btnBuscarIDCliente.DisabledState.BorderColor = Color.DarkGray;
            btnBuscarIDCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscarIDCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscarIDCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscarIDCliente.FillColor = Color.Transparent;
            btnBuscarIDCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarIDCliente.ForeColor = Color.White;
            btnBuscarIDCliente.Image = Properties.Resources.icon_buscar_cliente_asistencia__x32_;
            btnBuscarIDCliente.ImageSize = new Size(32, 32);
            btnBuscarIDCliente.Location = new Point(506, 88);
            btnBuscarIDCliente.Name = "btnBuscarIDCliente";
            btnBuscarIDCliente.PressedColor = Color.Transparent;
            btnBuscarIDCliente.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBuscarIDCliente.Size = new Size(117, 55);
            btnBuscarIDCliente.TabIndex = 18;
            btnBuscarIDCliente.TextAlign = HorizontalAlignment.Left;
            btnBuscarIDCliente.Click += btnBuscarIDCliente_Click;
            // 
            // TxbIDCliente
            // 
            TxbIDCliente.Enabled = false;
            TxbIDCliente.ForeColor = Color.Black;
            TxbIDCliente.Location = new Point(14, 55);
            TxbIDCliente.Name = "TxbIDCliente";
            TxbIDCliente.ReadOnly = true;
            TxbIDCliente.Size = new Size(117, 23);
            TxbIDCliente.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 24);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 11;
            label4.Text = "IDCliente";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(137, 24);
            label6.Name = "label6";
            label6.Size = new Size(117, 24);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbApellidoCliente
            // 
            TxbApellidoCliente.Enabled = false;
            TxbApellidoCliente.ForeColor = Color.Black;
            TxbApellidoCliente.Location = new Point(260, 55);
            TxbApellidoCliente.Name = "TxbApellidoCliente";
            TxbApellidoCliente.ReadOnly = true;
            TxbApellidoCliente.Size = new Size(117, 23);
            TxbApellidoCliente.TabIndex = 14;
            // 
            // TxbDocumentoCliente
            // 
            TxbDocumentoCliente.Enabled = false;
            TxbDocumentoCliente.ForeColor = Color.Black;
            TxbDocumentoCliente.Location = new Point(506, 55);
            TxbDocumentoCliente.Name = "TxbDocumentoCliente";
            TxbDocumentoCliente.ReadOnly = true;
            TxbDocumentoCliente.Size = new Size(117, 23);
            TxbDocumentoCliente.TabIndex = 16;
            // 
            // TxbTipoDocumento
            // 
            TxbTipoDocumento.Enabled = false;
            TxbTipoDocumento.ForeColor = Color.Black;
            TxbTipoDocumento.Location = new Point(383, 55);
            TxbTipoDocumento.Name = "TxbTipoDocumento";
            TxbTipoDocumento.ReadOnly = true;
            TxbTipoDocumento.Size = new Size(117, 23);
            TxbTipoDocumento.TabIndex = 19;
            // 
            // label38
            // 
            label38.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(383, 24);
            label38.Name = "label38";
            label38.Size = new Size(117, 24);
            label38.TabIndex = 20;
            label38.Text = "Tipo de Doc.";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(506, 24);
            label5.Name = "label5";
            label5.Size = new Size(117, 24);
            label5.TabIndex = 17;
            label5.Text = "Documento";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbNombreCliente
            // 
            TxbNombreCliente.Enabled = false;
            TxbNombreCliente.ForeColor = Color.Black;
            TxbNombreCliente.Location = new Point(137, 55);
            TxbNombreCliente.Name = "TxbNombreCliente";
            TxbNombreCliente.ReadOnly = true;
            TxbNombreCliente.Size = new Size(117, 23);
            TxbNombreCliente.TabIndex = 12;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarAsistenciaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 497);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarAsistenciaClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox btnCerrar;
        private Panel panel3;
        private GroupBox groupBox2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btnBuscarIDCliente;
        private TextBox TxbIDCliente;
        private Label label4;
        private Label label6;
        private TextBox TxbApellidoCliente;
        private TextBox TxbDocumentoCliente;
        private TextBox TxbTipoDocumento;
        private Label label38;
        private Label label5;
        private TextBox TxbNombreCliente;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAssistanceSave;
        private CheckBox rbtnAsistio;
        private ErrorProvider errorProvider;
    }
}