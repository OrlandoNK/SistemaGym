namespace SistemaGym.UI.Windows
{
    partial class frmListaCliente
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
            label = new Label();
            Nombre = new Label();
            Descripcion = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnNuevo = new Button();
            btnGuardar = new Button();
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.Location = new Point(44, 108);
            label.Name = "label";
            label.Size = new Size(79, 23);
            label.TabIndex = 0;
            label.Text = "IDListaCliente";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(129, 108);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(142, 23);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            Nombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(44, 179);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(227, 23);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            Descripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.Location = new Point(44, 134);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 23);
            txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(44, 205);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(227, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = Properties.Resources._NewFacturaProduct;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(-1, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(2, 0, 0, 0);
            btnNuevo.Size = new Size(183, 50);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = Properties.Resources._SaveFacturaProduct;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(-1, 80);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(5, 0, 0, 0);
            btnGuardar.Size = new Size(183, 50);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 63);
            panel1.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Goldenrod;
            guna2HtmlLabel1.Location = new Point(73, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(102, 25);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Lista Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mantenimiento_TipoCliente_x32__;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(453, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 33);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnNuevo);
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 354);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(txtDescripcion);
            panel4.Controls.Add(Descripcion);
            panel4.Controls.Add(txtID);
            panel4.Controls.Add(label);
            panel4.Controls.Add(Nombre);
            panel4.Controls.Add(txtNombre);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(183, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 354);
            panel4.TabIndex = 12;
            // 
            // frmListaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaCliente";
            Text = "frmListaCliente";
            Load += frmListaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private Label Nombre;
        private Label Descripcion;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ErrorProvider errorProvider1;
        private Button btnGuardar;
        private Button btnNuevo;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
    }
}