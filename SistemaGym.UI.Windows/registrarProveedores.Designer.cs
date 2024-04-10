namespace SistemaGym.UI.Windows
{
    partial class registrarProveedores
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txbRNC = new TextBox();
            txbCorreo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            btnGuardarProveedor = new Guna.UI2.WinForms.Guna2Button();
            TxbNombreProveedor = new TextBox();
            label3 = new Label();
            label1 = new Label();
            mskbxTellProveedor = new MaskedTextBox();
            TxbDireccionProveedor = new TextBox();
            label2 = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 65);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(71, 19);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 5;
            label4.Text = "Proveedores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_proveedor_mantenimiento__x32__waos;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btn_cerrar_ventana_x_x32;
            btnClose.Location = new Point(709, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txbRNC);
            panel3.Controls.Add(txbCorreo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(TxbNombreProveedor);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(mskbxTellProveedor);
            panel3.Controls.Add(TxbDireccionProveedor);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(754, 366);
            panel3.TabIndex = 2;
            // 
            // txbRNC
            // 
            txbRNC.Location = new Point(393, 216);
            txbRNC.Name = "txbRNC";
            txbRNC.Size = new Size(160, 23);
            txbRNC.TabIndex = 14;
            // 
            // txbCorreo
            // 
            txbCorreo.Location = new Point(227, 216);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(160, 23);
            txbCorreo.TabIndex = 13;
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(393, 194);
            label6.Name = "label6";
            label6.Size = new Size(160, 19);
            label6.TabIndex = 12;
            label6.Text = "RNC";
            // 
            // label5
            // 
            label5.ForeColor = Color.Black;
            label5.Location = new Point(227, 194);
            label5.Name = "label5";
            label5.Size = new Size(160, 19);
            label5.TabIndex = 10;
            label5.Text = "Correo del Proveedor";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnGuardarProveedor);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 364);
            panel4.TabIndex = 8;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BorderColor = Color.Goldenrod;
            btnGuardarProveedor.BorderThickness = 1;
            btnGuardarProveedor.Cursor = Cursors.Hand;
            btnGuardarProveedor.CustomizableEdges = customizableEdges1;
            btnGuardarProveedor.DisabledState.BorderColor = Color.DarkGray;
            btnGuardarProveedor.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardarProveedor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardarProveedor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardarProveedor.FillColor = Color.Transparent;
            btnGuardarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarProveedor.ForeColor = Color.White;
            btnGuardarProveedor.HoverState.FillColor = Color.Goldenrod;
            btnGuardarProveedor.HoverState.ForeColor = Color.Black;
            btnGuardarProveedor.Image = Properties.Resources.icon_save_button__x32_;
            btnGuardarProveedor.ImageAlign = HorizontalAlignment.Left;
            btnGuardarProveedor.ImageSize = new Size(32, 32);
            btnGuardarProveedor.Location = new Point(-1, 86);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGuardarProveedor.Size = new Size(200, 45);
            btnGuardarProveedor.TabIndex = 8;
            btnGuardarProveedor.Text = "Guardar";
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // TxbNombreProveedor
            // 
            TxbNombreProveedor.Location = new Point(227, 150);
            TxbNombreProveedor.Name = "TxbNombreProveedor";
            TxbNombreProveedor.Size = new Size(160, 23);
            TxbNombreProveedor.TabIndex = 0;
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(559, 128);
            label3.Name = "label3";
            label3.Size = new Size(160, 19);
            label3.TabIndex = 6;
            label3.Text = "Telefono del Proveedor";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 126);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 4;
            label1.Text = "Nombre del Proveedor";
            // 
            // mskbxTellProveedor
            // 
            mskbxTellProveedor.Location = new Point(559, 150);
            mskbxTellProveedor.Name = "mskbxTellProveedor";
            mskbxTellProveedor.Size = new Size(160, 23);
            mskbxTellProveedor.TabIndex = 2;
            // 
            // TxbDireccionProveedor
            // 
            TxbDireccionProveedor.Location = new Point(393, 150);
            TxbDireccionProveedor.Name = "TxbDireccionProveedor";
            TxbDireccionProveedor.Size = new Size(160, 23);
            TxbDireccionProveedor.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(393, 128);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 5;
            label2.Text = "Dirección del Proveedor";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 471);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox TxbNombreProveedor;
        private MaskedTextBox mskbxTellProveedor;
        private TextBox TxbDireccionProveedor;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnGuardarProveedor;
        private ErrorProvider errorProvider;
        private PictureBox btnClose;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private TextBox txbRNC;
        private TextBox txbCorreo;
    }
}