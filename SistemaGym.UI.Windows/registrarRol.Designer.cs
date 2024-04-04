namespace SistemaGym.UI.Windows
{
    partial class registrarRol
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
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            txtDescripcion = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            errorProvider = new ErrorProvider(components);
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 56);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(425, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 27);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 315);
            panel3.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderColor = Color.DarkGoldenrod;
            btnGuardar.BorderThickness = 1;
            btnGuardar.CustomizableEdges = customizableEdges1;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.Transparent;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.DarkGoldenrod;
            btnGuardar.HoverState.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources._SaveFacturaProduct;
            btnGuardar.ImageAlign = HorizontalAlignment.Left;
            btnGuardar.ImageSize = new Size(25, 25);
            btnGuardar.Location = new Point(-1, 36);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedColor = Color.Transparent;
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGuardar.Size = new Size(167, 45);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = HorizontalAlignment.Right;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.Controls.Add(txtDescripcion);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtNombre);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(167, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 315);
            panel4.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(59, 151);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 96);
            txtDescripcion.TabIndex = 13;
            txtDescripcion.Text = "";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 67);
            label2.Name = "label2";
            label2.Size = new Size(185, 27);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 123);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 11;
            label3.Text = "Descripcion";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(59, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 23);
            txtNombre.TabIndex = 12;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(62, 15);
            label8.Name = "label8";
            label8.Size = new Size(56, 24);
            label8.TabIndex = 8;
            label8.Text = "Roles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_role__x32_;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // registrarRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 398);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registrarRol";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Panel panel4;
        private RichTextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private ErrorProvider errorProvider;
        private PictureBox btnClose;
        private Label label8;
        private PictureBox pictureBox1;
    }
}