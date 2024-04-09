namespace SistemaGym.UI.Windows
{
    partial class registrarMembresia
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            txtCantidadPersonas = new TextBox();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtValor = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDuracion = new TextBox();
            panel6 = new Panel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            txtNombre = new TextBox();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(69, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 4;
            label1.Text = "Membresias";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon_facturacion_membresia__x32_;
            pictureBox2.Location = new Point(11, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(648, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 35);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtCantidadPersonas);
            panel5.Controls.Add(txtDescripcion);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtValor);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtDuracion);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtNombre);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(693, 422);
            panel5.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(354, 158);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 36;
            label6.Text = "Cantidad (Personas)";
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.Anchor = AnchorStyles.None;
            txtCantidadPersonas.Location = new Point(354, 181);
            txtCantidadPersonas.Multiline = true;
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.Size = new Size(126, 24);
            txtCantidadPersonas.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.Location = new Point(354, 110);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 24);
            txtDescripcion.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(222, 158);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 24;
            label4.Text = "Duracion (Meses)";
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.None;
            txtValor.Location = new Point(560, 110);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(126, 24);
            txtValor.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(560, 87);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 25;
            label5.Text = "Valor $";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(222, 87);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(354, 87);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 23;
            label3.Text = "Descripcion";
            // 
            // txtDuracion
            // 
            txtDuracion.Anchor = AnchorStyles.None;
            txtDuracion.Location = new Point(222, 181);
            txtDuracion.Multiline = true;
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(126, 24);
            txtDuracion.TabIndex = 31;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnSave);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(216, 420);
            panel6.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.Goldenrod;
            btnSave.BorderThickness = 1;
            btnSave.CustomizableEdges = customizableEdges7;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.Transparent;
            btnSave.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.FillColor = Color.Black;
            btnSave.HoverState.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.icon_save_button__x32_;
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.ImageSize = new Size(32, 32);
            btnSave.Location = new Point(-2, 32);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.Transparent;
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSave.Size = new Size(218, 45);
            btnSave.TabIndex = 35;
            btnSave.Text = "&Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(222, 110);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(126, 24);
            txtNombre.TabIndex = 29;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 523);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private TextBox txtValor;
        private TextBox txtDuracion;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private ErrorProvider errorProvider;
        private PictureBox btnClose;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox txtCantidadPersonas;
        private TextBox txtDescripcion;
    }
}