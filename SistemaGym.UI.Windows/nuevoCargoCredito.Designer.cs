namespace SistemaGym.UI.Windows
{
    partial class nuevoCargoCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoCargoCredito));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topPanel = new Panel();
            btnClose = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            TxbIDClienteCargoCredito = new TextBox();
            label12 = new Label();
            btnBuscarClienteCargoCredito = new Guna.UI2.WinForms.Guna2Button();
            btnGuardarCargoCredito = new Guna.UI2.WinForms.Guna2Button();
            label16 = new Label();
            TxbMontoCargoCredito = new TextBox();
            label9 = new Label();
            TxbCargoCredito = new TextBox();
            label17 = new Label();
            label13 = new Label();
            TxbApellidoClienteCargoCredito = new TextBox();
            TxbDocClienteCargoCredito = new TextBox();
            TxbNombreClienteCargoCredito = new TextBox();
            label18 = new Label();
            lblTitleMantenimientoFacturaMembresia = new Label();
            pictureBox1 = new PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            topPanel.TabIndex = 0;
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
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 31);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 388);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TxbIDClienteCargoCredito);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btnBuscarClienteCargoCredito);
            panel3.Controls.Add(btnGuardarCargoCredito);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(TxbMontoCargoCredito);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(TxbCargoCredito);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(TxbApellidoClienteCargoCredito);
            panel3.Controls.Add(TxbDocClienteCargoCredito);
            panel3.Controls.Add(TxbNombreClienteCargoCredito);
            panel3.Controls.Add(label18);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(190, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 388);
            panel3.TabIndex = 3;
            // 
            // TxbIDClienteCargoCredito
            // 
            TxbIDClienteCargoCredito.Enabled = false;
            TxbIDClienteCargoCredito.Location = new Point(42, 125);
            TxbIDClienteCargoCredito.Name = "TxbIDClienteCargoCredito";
            TxbIDClienteCargoCredito.ReadOnly = true;
            TxbIDClienteCargoCredito.Size = new Size(67, 23);
            TxbIDClienteCargoCredito.TabIndex = 36;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(42, 182);
            label12.Name = "label12";
            label12.Size = new Size(117, 24);
            label12.TabIndex = 31;
            label12.Text = "Monto";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuscarClienteCargoCredito
            // 
            btnBuscarClienteCargoCredito.BorderRadius = 10;
            btnBuscarClienteCargoCredito.BorderThickness = 2;
            btnBuscarClienteCargoCredito.Cursor = Cursors.Hand;
            btnBuscarClienteCargoCredito.CustomizableEdges = customizableEdges1;
            btnBuscarClienteCargoCredito.DisabledState.BorderColor = Color.DarkGray;
            btnBuscarClienteCargoCredito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscarClienteCargoCredito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscarClienteCargoCredito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscarClienteCargoCredito.FillColor = Color.Transparent;
            btnBuscarClienteCargoCredito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarClienteCargoCredito.ForeColor = Color.White;
            btnBuscarClienteCargoCredito.Image = Properties.Resources._BuscarClienteCCyCD_x32_;
            btnBuscarClienteCargoCredito.ImageSize = new Size(32, 32);
            btnBuscarClienteCargoCredito.Location = new Point(115, 94);
            btnBuscarClienteCargoCredito.Name = "btnBuscarClienteCargoCredito";
            btnBuscarClienteCargoCredito.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBuscarClienteCargoCredito.Size = new Size(60, 54);
            btnBuscarClienteCargoCredito.TabIndex = 38;
            btnBuscarClienteCargoCredito.Click += btnBuscarClienteCargoCredito_Click;
            // 
            // btnGuardarCargoCredito
            // 
            btnGuardarCargoCredito.BorderRadius = 5;
            btnGuardarCargoCredito.BorderThickness = 2;
            btnGuardarCargoCredito.Cursor = Cursors.Hand;
            btnGuardarCargoCredito.CustomizableEdges = customizableEdges3;
            btnGuardarCargoCredito.DisabledState.BorderColor = Color.DarkGray;
            btnGuardarCargoCredito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardarCargoCredito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardarCargoCredito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardarCargoCredito.FillColor = Color.Transparent;
            btnGuardarCargoCredito.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCargoCredito.ForeColor = Color.Black;
            btnGuardarCargoCredito.HoverState.FillColor = Color.DarkGoldenrod;
            btnGuardarCargoCredito.HoverState.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCargoCredito.HoverState.ForeColor = Color.Black;
            btnGuardarCargoCredito.Image = (Image)resources.GetObject("btnGuardarCargoCredito.Image");
            btnGuardarCargoCredito.ImageAlign = HorizontalAlignment.Left;
            btnGuardarCargoCredito.ImageSize = new Size(45, 45);
            btnGuardarCargoCredito.Location = new Point(429, 213);
            btnGuardarCargoCredito.Name = "btnGuardarCargoCredito";
            btnGuardarCargoCredito.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGuardarCargoCredito.Size = new Size(164, 62);
            btnGuardarCargoCredito.TabIndex = 39;
            btnGuardarCargoCredito.Text = "&Guardar Cargo Crédito";
            btnGuardarCargoCredito.TextAlign = HorizontalAlignment.Right;
            btnGuardarCargoCredito.Click += btnGuardarCargoCredito_Click;
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(181, 94);
            label16.Name = "label16";
            label16.Size = new Size(166, 24);
            label16.TabIndex = 44;
            label16.Text = "Documento";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbMontoCargoCredito
            // 
            TxbMontoCargoCredito.Location = new Point(42, 213);
            TxbMontoCargoCredito.Name = "TxbMontoCargoCredito";
            TxbMontoCargoCredito.Size = new Size(117, 23);
            TxbMontoCargoCredito.TabIndex = 30;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(42, 94);
            label9.Name = "label9";
            label9.Size = new Size(67, 24);
            label9.TabIndex = 37;
            label9.Text = "IDCliente";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbCargoCredito
            // 
            TxbCargoCredito.Location = new Point(165, 213);
            TxbCargoCredito.Name = "TxbCargoCredito";
            TxbCargoCredito.Size = new Size(117, 23);
            TxbCargoCredito.TabIndex = 32;
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(353, 94);
            label17.Name = "label17";
            label17.Size = new Size(117, 24);
            label17.TabIndex = 40;
            label17.Text = "Nombre";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(165, 182);
            label13.Name = "label13";
            label13.Size = new Size(117, 24);
            label13.TabIndex = 33;
            label13.Text = "Cargo";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbApellidoClienteCargoCredito
            // 
            TxbApellidoClienteCargoCredito.Enabled = false;
            TxbApellidoClienteCargoCredito.Location = new Point(476, 125);
            TxbApellidoClienteCargoCredito.Name = "TxbApellidoClienteCargoCredito";
            TxbApellidoClienteCargoCredito.ReadOnly = true;
            TxbApellidoClienteCargoCredito.Size = new Size(117, 23);
            TxbApellidoClienteCargoCredito.TabIndex = 41;
            // 
            // TxbDocClienteCargoCredito
            // 
            TxbDocClienteCargoCredito.Enabled = false;
            TxbDocClienteCargoCredito.Location = new Point(181, 125);
            TxbDocClienteCargoCredito.Name = "TxbDocClienteCargoCredito";
            TxbDocClienteCargoCredito.ReadOnly = true;
            TxbDocClienteCargoCredito.Size = new Size(166, 23);
            TxbDocClienteCargoCredito.TabIndex = 43;
            // 
            // TxbNombreClienteCargoCredito
            // 
            TxbNombreClienteCargoCredito.Enabled = false;
            TxbNombreClienteCargoCredito.Location = new Point(353, 125);
            TxbNombreClienteCargoCredito.Name = "TxbNombreClienteCargoCredito";
            TxbNombreClienteCargoCredito.ReadOnly = true;
            TxbNombreClienteCargoCredito.Size = new Size(117, 23);
            TxbNombreClienteCargoCredito.TabIndex = 39;
            // 
            // label18
            // 
            label18.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(476, 94);
            label18.Name = "label18";
            label18.Size = new Size(117, 24);
            label18.TabIndex = 42;
            label18.Text = "Apellido";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitleMantenimientoFacturaMembresia
            // 
            lblTitleMantenimientoFacturaMembresia.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMantenimientoFacturaMembresia.ForeColor = Color.Gold;
            lblTitleMantenimientoFacturaMembresia.Location = new Point(71, 6);
            lblTitleMantenimientoFacturaMembresia.Name = "lblTitleMantenimientoFacturaMembresia";
            lblTitleMantenimientoFacturaMembresia.Size = new Size(200, 53);
            lblTitleMantenimientoFacturaMembresia.TabIndex = 6;
            lblTitleMantenimientoFacturaMembresia.Text = "Cargo Crédito";
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
            // nuevoCargoCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 485);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "nuevoCargoCredito";
            StartPosition = FormStartPosition.CenterScreen;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox btnClose;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox TxbIDClienteCargoCredito;
        private Guna.UI2.WinForms.Guna2Button btnBuscarClienteCargoCredito;
        private Label label16;
        private Label label9;
        private Label label17;
        private TextBox TxbApellidoClienteCargoCredito;
        private TextBox TxbDocClienteCargoCredito;
        private Label label18;
        private TextBox TxbNombreClienteCargoCredito;
        private Label label12;
        private TextBox TxbMontoCargoCredito;
        private TextBox TxbCargoCredito;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Button btnGuardarCargoCredito;
        private Label lblTitleMantenimientoFacturaMembresia;
        private PictureBox pictureBox1;
    }
}