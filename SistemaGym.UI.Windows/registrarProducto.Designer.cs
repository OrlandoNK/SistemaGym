namespace SistemaGym.UI.Windows
{
    partial class registrarProducto
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            btnRefreshProviders = new Guna.UI2.WinForms.Guna2Button();
            btnRefreshCategories = new Guna.UI2.WinForms.Guna2Button();
            btnNewProvider = new Guna.UI2.WinForms.Guna2Button();
            btnNewCategory = new Guna.UI2.WinForms.Guna2Button();
            cbProveedor = new ComboBox();
            label1 = new Label();
            cbCategoria = new ComboBox();
            txtStock = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtNombre = new TextBox();
            txtIDProducto = new TextBox();
            label = new Label();
            lblPrecioUnitario = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblIDProducto = new Label();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 66);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(471, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(69, 20);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 4;
            label2.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box_1942650;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 39);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnNuevo);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 457);
            panel3.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderColor = Color.Goldenrod;
            btnGuardar.BorderThickness = 1;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = customizableEdges1;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.Transparent;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Goldenrod;
            btnGuardar.HoverState.FillColor = Color.FromArgb(35, 32, 39);
            btnGuardar.HoverState.ForeColor = Color.Goldenrod;
            btnGuardar.Location = new Point(-1, 108);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedColor = Color.Transparent;
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGuardar.Size = new Size(198, 49);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BorderColor = Color.Goldenrod;
            btnNuevo.BorderThickness = 1;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.CustomizableEdges = customizableEdges3;
            btnNuevo.DisabledState.BorderColor = Color.DarkGray;
            btnNuevo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNuevo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNuevo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNuevo.FillColor = Color.Transparent;
            btnNuevo.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.Goldenrod;
            btnNuevo.HoverState.FillColor = Color.FromArgb(35, 32, 39);
            btnNuevo.HoverState.ForeColor = Color.Goldenrod;
            btnNuevo.Location = new Point(-1, 53);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.PressedColor = Color.Transparent;
            btnNuevo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNuevo.Size = new Size(198, 49);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnRefreshProviders);
            panel4.Controls.Add(btnRefreshCategories);
            panel4.Controls.Add(btnNewProvider);
            panel4.Controls.Add(btnNewCategory);
            panel4.Controls.Add(cbProveedor);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cbCategoria);
            panel4.Controls.Add(txtStock);
            panel4.Controls.Add(txtPrecioUnitario);
            panel4.Controls.Add(txtNombre);
            panel4.Controls.Add(txtIDProducto);
            panel4.Controls.Add(label);
            panel4.Controls.Add(lblPrecioUnitario);
            panel4.Controls.Add(lblCategoria);
            panel4.Controls.Add(lblNombre);
            panel4.Controls.Add(lblIDProducto);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(198, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 457);
            panel4.TabIndex = 3;
            // 
            // btnRefreshProviders
            // 
            btnRefreshProviders.Anchor = AnchorStyles.None;
            btnRefreshProviders.BorderColor = Color.Goldenrod;
            btnRefreshProviders.BorderThickness = 1;
            btnRefreshProviders.Cursor = Cursors.Hand;
            btnRefreshProviders.CustomizableEdges = customizableEdges5;
            btnRefreshProviders.DisabledState.BorderColor = Color.DarkGray;
            btnRefreshProviders.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefreshProviders.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefreshProviders.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefreshProviders.FillColor = Color.Transparent;
            btnRefreshProviders.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefreshProviders.ForeColor = Color.White;
            btnRefreshProviders.HoverState.FillColor = Color.Black;
            btnRefreshProviders.Image = Properties.Resources.refresh_8677771;
            btnRefreshProviders.ImageSize = new Size(25, 25);
            btnRefreshProviders.Location = new Point(238, 226);
            btnRefreshProviders.Name = "btnRefreshProviders";
            btnRefreshProviders.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnRefreshProviders.Size = new Size(55, 48);
            btnRefreshProviders.TabIndex = 32;
            btnRefreshProviders.Click += btnRefreshProviders_Click;
            // 
            // btnRefreshCategories
            // 
            btnRefreshCategories.Anchor = AnchorStyles.None;
            btnRefreshCategories.BorderColor = Color.Goldenrod;
            btnRefreshCategories.BorderThickness = 1;
            btnRefreshCategories.Cursor = Cursors.Hand;
            btnRefreshCategories.CustomizableEdges = customizableEdges7;
            btnRefreshCategories.DisabledState.BorderColor = Color.DarkGray;
            btnRefreshCategories.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefreshCategories.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefreshCategories.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefreshCategories.FillColor = Color.Transparent;
            btnRefreshCategories.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefreshCategories.ForeColor = Color.White;
            btnRefreshCategories.HoverState.FillColor = Color.Black;
            btnRefreshCategories.Image = Properties.Resources.refresh_8677771;
            btnRefreshCategories.ImageSize = new Size(25, 25);
            btnRefreshCategories.Location = new Point(238, 161);
            btnRefreshCategories.Name = "btnRefreshCategories";
            btnRefreshCategories.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRefreshCategories.Size = new Size(55, 48);
            btnRefreshCategories.TabIndex = 31;
            btnRefreshCategories.Click += btnRefreshCategories_Click;
            // 
            // btnNewProvider
            // 
            btnNewProvider.Anchor = AnchorStyles.None;
            btnNewProvider.BorderColor = Color.Goldenrod;
            btnNewProvider.BorderThickness = 1;
            btnNewProvider.Cursor = Cursors.Hand;
            btnNewProvider.CustomizableEdges = customizableEdges9;
            btnNewProvider.DisabledState.BorderColor = Color.DarkGray;
            btnNewProvider.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNewProvider.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNewProvider.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNewProvider.FillColor = Color.Transparent;
            btnNewProvider.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewProvider.ForeColor = Color.White;
            btnNewProvider.HoverState.FillColor = Color.Black;
            btnNewProvider.Image = Properties.Resources._NewFacturaProduct;
            btnNewProvider.ImageSize = new Size(25, 25);
            btnNewProvider.Location = new Point(177, 226);
            btnNewProvider.Name = "btnNewProvider";
            btnNewProvider.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnNewProvider.Size = new Size(55, 48);
            btnNewProvider.TabIndex = 30;
            btnNewProvider.Click += btnNewProvider_Click;
            // 
            // btnNewCategory
            // 
            btnNewCategory.Anchor = AnchorStyles.None;
            btnNewCategory.BorderColor = Color.Goldenrod;
            btnNewCategory.BorderThickness = 1;
            btnNewCategory.Cursor = Cursors.Hand;
            btnNewCategory.CustomizableEdges = customizableEdges11;
            btnNewCategory.DisabledState.BorderColor = Color.DarkGray;
            btnNewCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNewCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNewCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNewCategory.FillColor = Color.Transparent;
            btnNewCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewCategory.ForeColor = Color.White;
            btnNewCategory.HoverState.FillColor = Color.Black;
            btnNewCategory.Image = Properties.Resources._NewFacturaProduct;
            btnNewCategory.ImageSize = new Size(25, 25);
            btnNewCategory.Location = new Point(177, 161);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnNewCategory.Size = new Size(55, 48);
            btnNewCategory.TabIndex = 29;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // cbProveedor
            // 
            cbProveedor.Anchor = AnchorStyles.None;
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(24, 251);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(147, 23);
            cbProveedor.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 226);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 27;
            label1.Text = "Proveedor";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.None;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(24, 186);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(147, 23);
            cbCategoria.TabIndex = 26;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.None;
            txtStock.Location = new Point(24, 359);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(147, 23);
            txtStock.TabIndex = 25;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Anchor = AnchorStyles.None;
            txtPrecioUnitario.Location = new Point(24, 308);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(147, 23);
            txtPrecioUnitario.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(24, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 23;
            // 
            // txtIDProducto
            // 
            txtIDProducto.Anchor = AnchorStyles.None;
            txtIDProducto.Location = new Point(24, 78);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(70, 23);
            txtIDProducto.TabIndex = 22;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.ForeColor = Color.White;
            label.Location = new Point(24, 334);
            label.Name = "label";
            label.Size = new Size(147, 22);
            label.TabIndex = 21;
            label.Text = "Stock";
            label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.Anchor = AnchorStyles.None;
            lblPrecioUnitario.ForeColor = Color.White;
            lblPrecioUnitario.Location = new Point(24, 283);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(147, 22);
            lblPrecioUnitario.TabIndex = 20;
            lblPrecioUnitario.Text = "Precio Unitario";
            lblPrecioUnitario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.None;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(24, 161);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(147, 22);
            lblCategoria.TabIndex = 19;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(24, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(147, 22);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIDProducto
            // 
            lblIDProducto.Anchor = AnchorStyles.None;
            lblIDProducto.ForeColor = Color.White;
            lblIDProducto.Location = new Point(24, 53);
            lblIDProducto.Name = "lblIDProducto";
            lblIDProducto.Size = new Size(70, 22);
            lblIDProducto.TabIndex = 17;
            lblIDProducto.Text = "ID Producto";
            lblIDProducto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // registrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 562);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarProducto";
            Load += registrarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private ComboBox cbProveedor;
        private Label label1;
        private ComboBox cbCategoria;
        private TextBox txtStock;
        private TextBox txtPrecioUnitario;
        private TextBox txtNombre;
        private TextBox txtIDProducto;
        private Label label;
        private Label lblPrecioUnitario;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblIDProducto;
        private Guna.UI2.WinForms.Guna2Button btnNewProvider;
        private Guna.UI2.WinForms.Guna2Button btnNewCategory;
        private Guna.UI2.WinForms.Guna2Button btnRefreshProviders;
        private Guna.UI2.WinForms.Guna2Button btnRefreshCategories;
        private ErrorProvider errorProvider;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
    }
}