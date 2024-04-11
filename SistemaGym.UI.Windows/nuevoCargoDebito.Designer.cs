namespace SistemaGym.UI.Windows
{
    partial class nuevoCargoDebito
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoCargoDebito));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            topPanel = new Panel();
            lblTitleMantenimientoFacturaMembresia = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            TxbIDClienteCargoDebito = new TextBox();
            label19 = new Label();
            label20 = new Label();
            btnBuscarClienteCargoDebito = new Guna.UI2.WinForms.Guna2Button();
            label21 = new Label();
            TxbApellidoClienteCargoDebito = new TextBox();
            TxbDocClienteCargoDebito = new TextBox();
            label22 = new Label();
            TxbNombreClienteCargoDebito = new TextBox();
            label23 = new Label();
            TxbMontoCargoDebito = new TextBox();
            TxbCargoDebito = new TextBox();
            label25 = new Label();
            btnGuardarCargoDebito = new Guna.UI2.WinForms.Guna2Button();
            panel3 = new Panel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 31);
            panel1.TabIndex = 3;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(lblTitleMantenimientoFacturaMembresia);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(btnClose);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(826, 66);
            topPanel.TabIndex = 2;
            // 
            // lblTitleMantenimientoFacturaMembresia
            // 
            lblTitleMantenimientoFacturaMembresia.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMantenimientoFacturaMembresia.ForeColor = Color.Gold;
            lblTitleMantenimientoFacturaMembresia.Location = new Point(71, 6);
            lblTitleMantenimientoFacturaMembresia.Name = "lblTitleMantenimientoFacturaMembresia";
            lblTitleMantenimientoFacturaMembresia.Size = new Size(200, 53);
            lblTitleMantenimientoFacturaMembresia.TabIndex = 6;
            lblTitleMantenimientoFacturaMembresia.Text = "Cargo Débito";
            lblTitleMantenimientoFacturaMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._PaymentMembresiaFactura;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(781, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 388);
            panel2.TabIndex = 4;
            // 
            // TxbIDClienteCargoDebito
            // 
            TxbIDClienteCargoDebito.Enabled = false;
            TxbIDClienteCargoDebito.Location = new Point(40, 136);
            TxbIDClienteCargoDebito.Name = "TxbIDClienteCargoDebito";
            TxbIDClienteCargoDebito.ReadOnly = true;
            TxbIDClienteCargoDebito.Size = new Size(72, 23);
            TxbIDClienteCargoDebito.TabIndex = 36;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(40, 105);
            label19.Name = "label19";
            label19.Size = new Size(72, 24);
            label19.TabIndex = 37;
            label19.Text = "IDCliente";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(184, 105);
            label20.Name = "label20";
            label20.Size = new Size(166, 24);
            label20.TabIndex = 44;
            label20.Text = "Documento";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarClienteCargoDebito
            // 
            btnBuscarClienteCargoDebito.BorderRadius = 10;
            btnBuscarClienteCargoDebito.BorderThickness = 2;
            btnBuscarClienteCargoDebito.Cursor = Cursors.Hand;
            btnBuscarClienteCargoDebito.CustomizableEdges = customizableEdges1;
            btnBuscarClienteCargoDebito.DisabledState.BorderColor = Color.DarkGray;
            btnBuscarClienteCargoDebito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscarClienteCargoDebito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscarClienteCargoDebito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscarClienteCargoDebito.FillColor = Color.Transparent;
            btnBuscarClienteCargoDebito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarClienteCargoDebito.ForeColor = Color.White;
            btnBuscarClienteCargoDebito.Image = Properties.Resources.icon_btn_search_for_Cliente__x32_;
            btnBuscarClienteCargoDebito.ImageSize = new Size(32, 32);
            btnBuscarClienteCargoDebito.Location = new Point(118, 104);
            btnBuscarClienteCargoDebito.Name = "btnBuscarClienteCargoDebito";
            btnBuscarClienteCargoDebito.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBuscarClienteCargoDebito.Size = new Size(60, 55);
            btnBuscarClienteCargoDebito.TabIndex = 38;
            btnBuscarClienteCargoDebito.Click += btnBuscarClienteCargoDebito_Click;
            // 
            // label21
            // 
            label21.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(356, 105);
            label21.Name = "label21";
            label21.Size = new Size(117, 24);
            label21.TabIndex = 40;
            label21.Text = "Nombre";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbApellidoClienteCargoDebito
            // 
            TxbApellidoClienteCargoDebito.Enabled = false;
            TxbApellidoClienteCargoDebito.Location = new Point(479, 136);
            TxbApellidoClienteCargoDebito.Name = "TxbApellidoClienteCargoDebito";
            TxbApellidoClienteCargoDebito.ReadOnly = true;
            TxbApellidoClienteCargoDebito.Size = new Size(117, 23);
            TxbApellidoClienteCargoDebito.TabIndex = 41;
            // 
            // TxbDocClienteCargoDebito
            // 
            TxbDocClienteCargoDebito.Enabled = false;
            TxbDocClienteCargoDebito.Location = new Point(184, 136);
            TxbDocClienteCargoDebito.Name = "TxbDocClienteCargoDebito";
            TxbDocClienteCargoDebito.ReadOnly = true;
            TxbDocClienteCargoDebito.Size = new Size(166, 23);
            TxbDocClienteCargoDebito.TabIndex = 43;
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(479, 105);
            label22.Name = "label22";
            label22.Size = new Size(117, 24);
            label22.TabIndex = 42;
            label22.Text = "Apellido";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbNombreClienteCargoDebito
            // 
            TxbNombreClienteCargoDebito.Enabled = false;
            TxbNombreClienteCargoDebito.Location = new Point(356, 136);
            TxbNombreClienteCargoDebito.Name = "TxbNombreClienteCargoDebito";
            TxbNombreClienteCargoDebito.ReadOnly = true;
            TxbNombreClienteCargoDebito.Size = new Size(117, 23);
            TxbNombreClienteCargoDebito.TabIndex = 39;
            // 
            // label23
            // 
            label23.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(40, 191);
            label23.Name = "label23";
            label23.Size = new Size(117, 24);
            label23.TabIndex = 46;
            label23.Text = "Monto";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbMontoCargoDebito
            // 
            TxbMontoCargoDebito.Location = new Point(40, 222);
            TxbMontoCargoDebito.Name = "TxbMontoCargoDebito";
            TxbMontoCargoDebito.Size = new Size(117, 23);
            TxbMontoCargoDebito.TabIndex = 45;
            // 
            // TxbCargoDebito
            // 
            TxbCargoDebito.Location = new Point(163, 222);
            TxbCargoDebito.Name = "TxbCargoDebito";
            TxbCargoDebito.Size = new Size(117, 23);
            TxbCargoDebito.TabIndex = 47;
            // 
            // label25
            // 
            label25.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(163, 191);
            label25.Name = "label25";
            label25.Size = new Size(117, 24);
            label25.TabIndex = 48;
            label25.Text = "Cargo";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGuardarCargoDebito
            // 
            btnGuardarCargoDebito.BorderRadius = 5;
            btnGuardarCargoDebito.BorderThickness = 2;
            btnGuardarCargoDebito.Cursor = Cursors.Hand;
            btnGuardarCargoDebito.CustomizableEdges = customizableEdges3;
            btnGuardarCargoDebito.DisabledState.BorderColor = Color.DarkGray;
            btnGuardarCargoDebito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardarCargoDebito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardarCargoDebito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardarCargoDebito.FillColor = Color.Transparent;
            btnGuardarCargoDebito.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCargoDebito.ForeColor = Color.Black;
            btnGuardarCargoDebito.HoverState.FillColor = Color.DarkGoldenrod;
            btnGuardarCargoDebito.HoverState.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCargoDebito.HoverState.ForeColor = Color.Black;
            btnGuardarCargoDebito.Image = (Image)resources.GetObject("btnGuardarCargoDebito.Image");
            btnGuardarCargoDebito.ImageAlign = HorizontalAlignment.Left;
            btnGuardarCargoDebito.ImageSize = new Size(45, 45);
            btnGuardarCargoDebito.Location = new Point(432, 222);
            btnGuardarCargoDebito.Name = "btnGuardarCargoDebito";
            btnGuardarCargoDebito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGuardarCargoDebito.Size = new Size(164, 62);
            btnGuardarCargoDebito.TabIndex = 49;
            btnGuardarCargoDebito.Text = "&Guardar Cargo Débito";
            btnGuardarCargoDebito.TextAlign = HorizontalAlignment.Right;
            btnGuardarCargoDebito.Click += btnGuardarCargoDebito_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnBuscarClienteCargoDebito);
            panel3.Controls.Add(btnGuardarCargoDebito);
            panel3.Controls.Add(TxbNombreClienteCargoDebito);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(TxbMontoCargoDebito);
            panel3.Controls.Add(TxbDocClienteCargoDebito);
            panel3.Controls.Add(TxbCargoDebito);
            panel3.Controls.Add(TxbApellidoClienteCargoDebito);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(TxbIDClienteCargoDebito);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label19);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(190, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 388);
            panel3.TabIndex = 50;
            // 
            // nuevoCargoDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 485);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "nuevoCargoDebito";
            StartPosition = FormStartPosition.CenterScreen;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel topPanel;
        private PictureBox btnClose;
        private Panel panel2;
        private TextBox TxbIDClienteCargoDebito;
        private Label label19;
        private Label label20;
        private Guna.UI2.WinForms.Guna2Button btnBuscarClienteCargoDebito;
        private Label label21;
        private TextBox TxbApellidoClienteCargoDebito;
        private TextBox TxbDocClienteCargoDebito;
        private Label label22;
        private TextBox TxbNombreClienteCargoDebito;
        private Label label23;
        private TextBox TxbMontoCargoDebito;
        private TextBox TxbCargoDebito;
        private Label label25;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCargoDebito;
        private Panel panel3;
        private Label lblTitleMantenimientoFacturaMembresia;
        private PictureBox pictureBox1;
    }
}