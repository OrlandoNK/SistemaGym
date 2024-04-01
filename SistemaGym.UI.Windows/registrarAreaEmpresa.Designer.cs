namespace SistemaGym.UI.Windows
{
    partial class registrarAreaEmpresa
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
            topPanel = new Panel();
            btnCerrar = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox1 = new PictureBox();
            subtopPanel = new Panel();
            panel1 = new Panel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txbNombreArea = new TextBox();
            txbDescripcion = new RichTextBox();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBox1 = new GroupBox();
            txbEncargado = new TextBox();
            btnBuscarEncargado = new Guna.UI2.WinForms.Guna2Button();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ErrorProvider = new ErrorProvider(components);
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(btnCerrar);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(567, 64);
            topPanel.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources._BotonXcerrarVentana;
            btnCerrar.Location = new Point(522, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.DarkGoldenrod;
            guna2HtmlLabel1.Location = new Point(72, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(129, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Área Empresa";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.area_GYM_empresa;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // subtopPanel
            // 
            subtopPanel.BackColor = Color.DarkGoldenrod;
            subtopPanel.BorderStyle = BorderStyle.FixedSingle;
            subtopPanel.Dock = DockStyle.Top;
            subtopPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            subtopPanel.Location = new Point(0, 64);
            subtopPanel.Name = "subtopPanel";
            subtopPanel.Size = new Size(567, 35);
            subtopPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 32, 39);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 417);
            panel1.TabIndex = 3;
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
            btnSave.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.HoverState.FillColor = Color.DarkGoldenrod;
            btnSave.HoverState.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources._SaveFacturaProduct;
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.ImageSize = new Size(25, 25);
            btnSave.Location = new Point(-1, 91);
            btnSave.Name = "btnSave";
            btnSave.PressedColor = Color.Transparent;
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(202, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.Cursor = Cursors.Hand;
            btnNew.CustomizableEdges = customizableEdges3;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.DarkGoldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources._NewFacturaProduct;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 40);
            btnNew.Name = "btnNew";
            btnNew.PressedColor = Color.Transparent;
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNew.Size = new Size(202, 45);
            btnNew.TabIndex = 5;
            btnNew.Text = "Nuevo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 417);
            panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(guna2HtmlLabel2);
            groupBox2.Controls.Add(txbNombreArea);
            groupBox2.Controls.Add(txbDescripcion);
            groupBox2.Controls.Add(guna2HtmlLabel6);
            groupBox2.Location = new Point(4, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 206);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Área de la Empresa";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(8, 35);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(155, 19);
            guna2HtmlLabel2.TabIndex = 11;
            guna2HtmlLabel2.Text = "Nombre del Área";
            // 
            // txbNombreArea
            // 
            txbNombreArea.Location = new Point(8, 56);
            txbNombreArea.Name = "txbNombreArea";
            txbNombreArea.Size = new Size(155, 23);
            txbNombreArea.TabIndex = 10;
            // 
            // txbDescripcion
            // 
            txbDescripcion.Location = new Point(7, 110);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(342, 72);
            txbDescripcion.TabIndex = 4;
            txbDescripcion.Text = "";
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.AutoSize = false;
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Location = new Point(7, 85);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(342, 19);
            guna2HtmlLabel6.TabIndex = 9;
            guna2HtmlLabel6.Text = "Descripcion del Área";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbEncargado);
            groupBox1.Controls.Add(btnBuscarEncargado);
            groupBox1.Controls.Add(txbNombre);
            groupBox1.Controls.Add(txbApellido);
            groupBox1.Controls.Add(guna2HtmlLabel5);
            groupBox1.Controls.Add(guna2HtmlLabel3);
            groupBox1.Controls.Add(guna2HtmlLabel4);
            groupBox1.Location = new Point(4, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encargado del Area";
            // 
            // txbEncargado
            // 
            txbEncargado.Enabled = false;
            txbEncargado.Location = new Point(7, 59);
            txbEncargado.Name = "txbEncargado";
            txbEncargado.ReadOnly = true;
            txbEncargado.Size = new Size(74, 23);
            txbEncargado.TabIndex = 1;
            // 
            // btnBuscarEncargado
            // 
            btnBuscarEncargado.BorderThickness = 1;
            btnBuscarEncargado.Cursor = Cursors.Hand;
            btnBuscarEncargado.CustomizableEdges = customizableEdges5;
            btnBuscarEncargado.DisabledState.BorderColor = Color.DarkGray;
            btnBuscarEncargado.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscarEncargado.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscarEncargado.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscarEncargado.FillColor = Color.Transparent;
            btnBuscarEncargado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarEncargado.ForeColor = Color.White;
            btnBuscarEncargado.HoverState.FillColor = Color.DarkGoldenrod;
            btnBuscarEncargado.Image = Properties.Resources._BuscarEnFacturacionMembresiaDatos;
            btnBuscarEncargado.ImageSize = new Size(28, 28);
            btnBuscarEncargado.Location = new Point(87, 34);
            btnBuscarEncargado.Name = "btnBuscarEncargado";
            btnBuscarEncargado.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnBuscarEncargado.Size = new Size(50, 48);
            btnBuscarEncargado.TabIndex = 10;
            // 
            // txbNombre
            // 
            txbNombre.Enabled = false;
            txbNombre.Location = new Point(143, 59);
            txbNombre.Name = "txbNombre";
            txbNombre.ReadOnly = true;
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 2;
            // 
            // txbApellido
            // 
            txbApellido.Enabled = false;
            txbApellido.Location = new Point(249, 59);
            txbApellido.Name = "txbApellido";
            txbApellido.ReadOnly = true;
            txbApellido.Size = new Size(100, 23);
            txbApellido.TabIndex = 3;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.AutoSize = false;
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Location = new Point(249, 34);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(100, 19);
            guna2HtmlLabel5.TabIndex = 8;
            guna2HtmlLabel5.Text = "Apellido";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Location = new Point(7, 34);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(74, 19);
            guna2HtmlLabel3.TabIndex = 6;
            guna2HtmlLabel3.Text = "Encargado";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.AutoSize = false;
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Location = new Point(143, 34);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(100, 19);
            guna2HtmlLabel4.TabIndex = 7;
            guna2HtmlLabel4.Text = "Nombre";
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // registrarAreaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 516);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(subtopPanel);
            Controls.Add(topPanel);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registrarAreaEmpresa";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
        private Panel subtopPanel;
        private PictureBox btnCerrar;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox txbDescripcion;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private TextBox txbEncargado;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnBuscarEncargado;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TextBox txbNombreArea;
        private ErrorProvider ErrorProvider;
    }
}