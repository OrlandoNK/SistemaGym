namespace SistemaGym.UI.Windows
{
    partial class registrarEmpleados
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            gbPersonalData = new GroupBox();
            TxbNombre = new TextBox();
            TxbTellCell = new MaskedTextBox();
            chEstatus = new CheckBox();
            label4 = new Label();
            cbTipoDocumento = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            TxbApellido = new TextBox();
            TxbTelRes = new MaskedTextBox();
            label3 = new Label();
            label6 = new Label();
            TxbDocumento = new MaskedTextBox();
            TxbDireccion = new RichTextBox();
            label5 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            gbPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(67, 19);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 5;
            label1.Text = "Empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.businessman_mante__x32_;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(797, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 36);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 460);
            panel3.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.DarkGoldenrod;
            btnSave.BorderThickness = 1;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.Transparent;
            btnSave.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.FillColor = Color.DarkGoldenrod;
            btnSave.HoverState.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources._GuardarFacturaMembresia;
            btnSave.ImageSize = new Size(25, 25);
            btnSave.Location = new Point(-1, 196);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(206, 61);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(gbPersonalData);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(206, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(636, 460);
            panel4.TabIndex = 3;
            // 
            // gbPersonalData
            // 
            gbPersonalData.Controls.Add(TxbNombre);
            gbPersonalData.Controls.Add(TxbTellCell);
            gbPersonalData.Controls.Add(chEstatus);
            gbPersonalData.Controls.Add(label4);
            gbPersonalData.Controls.Add(cbTipoDocumento);
            gbPersonalData.Controls.Add(label2);
            gbPersonalData.Controls.Add(label7);
            gbPersonalData.Controls.Add(label8);
            gbPersonalData.Controls.Add(TxbApellido);
            gbPersonalData.Controls.Add(TxbTelRes);
            gbPersonalData.Controls.Add(label3);
            gbPersonalData.Controls.Add(label6);
            gbPersonalData.Controls.Add(TxbDocumento);
            gbPersonalData.Controls.Add(TxbDireccion);
            gbPersonalData.Controls.Add(label5);
            gbPersonalData.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbPersonalData.Location = new Point(4, 91);
            gbPersonalData.Name = "gbPersonalData";
            gbPersonalData.Size = new Size(627, 276);
            gbPersonalData.TabIndex = 15;
            gbPersonalData.TabStop = false;
            gbPersonalData.Text = "Datos Personales";
            // 
            // TxbNombre
            // 
            TxbNombre.Location = new Point(23, 82);
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(140, 23);
            TxbNombre.TabIndex = 0;
            // 
            // TxbTellCell
            // 
            TxbTellCell.Location = new Point(315, 150);
            TxbTellCell.Mask = "(999)-999-9999";
            TxbTellCell.Name = "TxbTellCell";
            TxbTellCell.Size = new Size(141, 23);
            TxbTellCell.TabIndex = 10;
            // 
            // chEstatus
            // 
            chEstatus.CheckAlign = ContentAlignment.MiddleRight;
            chEstatus.Location = new Point(480, 199);
            chEstatus.Name = "chEstatus";
            chEstatus.Size = new Size(123, 24);
            chEstatus.TabIndex = 14;
            chEstatus.Text = "Estatus";
            chEstatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(315, 54);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 5;
            label4.Text = "Tipo de Documento";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "Cedula", "Pasaporte", "Carnet Universitario" });
            cbTipoDocumento.Location = new Point(315, 80);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(141, 25);
            cbTipoDocumento.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(315, 124);
            label7.Name = "label7";
            label7.Size = new Size(141, 23);
            label7.TabIndex = 11;
            label7.Text = "Telefono (Movil)";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(462, 124);
            label8.Name = "label8";
            label8.Size = new Size(141, 23);
            label8.TabIndex = 13;
            label8.Text = "Telefono (Residencial)";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbApellido
            // 
            TxbApellido.Location = new Point(169, 80);
            TxbApellido.Name = "TxbApellido";
            TxbApellido.Size = new Size(140, 23);
            TxbApellido.TabIndex = 2;
            // 
            // TxbTelRes
            // 
            TxbTelRes.Location = new Point(462, 150);
            TxbTelRes.Mask = "(999)-999-9999";
            TxbTelRes.Name = "TxbTelRes";
            TxbTelRes.Size = new Size(141, 23);
            TxbTelRes.TabIndex = 12;
            // 
            // label3
            // 
            label3.Location = new Point(169, 54);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(23, 124);
            label6.Name = "label6";
            label6.Size = new Size(206, 23);
            label6.TabIndex = 9;
            label6.Text = "Direccion";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbDocumento
            // 
            TxbDocumento.Location = new Point(462, 80);
            TxbDocumento.Mask = "999-9999999-9";
            TxbDocumento.Name = "TxbDocumento";
            TxbDocumento.Size = new Size(141, 23);
            TxbDocumento.TabIndex = 6;
            // 
            // TxbDireccion
            // 
            TxbDireccion.Location = new Point(23, 150);
            TxbDireccion.Name = "TxbDireccion";
            TxbDireccion.Size = new Size(206, 73);
            TxbDireccion.TabIndex = 8;
            TxbDireccion.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(462, 54);
            label5.Name = "label5";
            label5.Size = new Size(141, 23);
            label5.TabIndex = 7;
            label5.Text = "No. Documento";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            gbPersonalData.ResumeLayout(false);
            gbPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Label label7;
        private MaskedTextBox TxbTellCell;
        private Label label6;
        private RichTextBox TxbDireccion;
        private Label label5;
        private MaskedTextBox TxbDocumento;
        private Label label4;
        private ComboBox cbTipoDocumento;
        private Label label3;
        private TextBox TxbApellido;
        private Label label2;
        private TextBox TxbNombre;
        private CheckBox chEstatus;
        private Label label8;
        private MaskedTextBox TxbTelRes;
        private GroupBox gbPersonalData;
        private ErrorProvider errorProvider;
    }
}