namespace SistemaGym.UI.Windows
{
    partial class mantenimientoAsistenciaClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topPanel = new Panel();
            btnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            subtopPanel = new Panel();
            sidePanel = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            searchbarPanel = new Panel();
            TxbSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            dgvAsistenciaClientes = new DataGridView();
            IDAsistenciaCliente = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewComboBoxColumn();
            Asistencia = new DataGridViewTextBoxColumn();
            FechaAsistencia = new DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidePanel.SuspendLayout();
            searchbarPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistenciaClientes).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(btnCerrar);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1085, 64);
            topPanel.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources._BotonXcerrarVentana;
            btnCerrar.Location = new Point(1040, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_asistencia_clientes_gym__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.DarkGoldenrod;
            guna2HtmlLabel1.Location = new Point(72, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(174, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Asistencia Clientes";
            // 
            // subtopPanel
            // 
            subtopPanel.BackColor = Color.DarkGoldenrod;
            subtopPanel.BorderStyle = BorderStyle.FixedSingle;
            subtopPanel.Dock = DockStyle.Top;
            subtopPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            subtopPanel.Location = new Point(0, 64);
            subtopPanel.Name = "subtopPanel";
            subtopPanel.Size = new Size(1085, 35);
            subtopPanel.TabIndex = 2;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Black;
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(btnDelete);
            sidePanel.Controls.Add(btnEdit);
            sidePanel.Controls.Add(btnRefresh);
            sidePanel.Controls.Add(btnNew);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sidePanel.Location = new Point(0, 99);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(198, 586);
            sidePanel.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.Transparent;
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(198, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 217);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.Transparent;
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(198, 45);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderColor = Color.DarkGoldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.CustomizableEdges = customizableEdges5;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.DarkGoldenrod;
            btnRefresh.HoverState.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 160);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PressedColor = Color.Transparent;
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnRefresh.Size = new Size(198, 45);
            btnRefresh.TabIndex = 5;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.Cursor = Cursors.Hand;
            btnNew.CustomizableEdges = customizableEdges7;
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
            btnNew.Location = new Point(-1, 103);
            btnNew.Name = "btnNew";
            btnNew.PressedColor = Color.Transparent;
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNew.Size = new Size(198, 45);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // searchbarPanel
            // 
            searchbarPanel.BackColor = Color.FromArgb(35, 32, 39);
            searchbarPanel.BorderStyle = BorderStyle.FixedSingle;
            searchbarPanel.Controls.Add(TxbSearchBar);
            searchbarPanel.Dock = DockStyle.Top;
            searchbarPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchbarPanel.Location = new Point(198, 99);
            searchbarPanel.Name = "searchbarPanel";
            searchbarPanel.Size = new Size(887, 63);
            searchbarPanel.TabIndex = 4;
            // 
            // TxbSearchBar
            // 
            TxbSearchBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbSearchBar.BorderRadius = 20;
            TxbSearchBar.CustomizableEdges = customizableEdges9;
            TxbSearchBar.DefaultText = "";
            TxbSearchBar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbSearchBar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbSearchBar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbSearchBar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbSearchBar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbSearchBar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbSearchBar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbSearchBar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbSearchBar.Location = new Point(7, 10);
            TxbSearchBar.Name = "TxbSearchBar";
            TxbSearchBar.PasswordChar = '\0';
            TxbSearchBar.PlaceholderForeColor = Color.Silver;
            TxbSearchBar.PlaceholderText = "Buscar";
            TxbSearchBar.SelectedText = "";
            TxbSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TxbSearchBar.Size = new Size(871, 40);
            TxbSearchBar.TabIndex = 0;
            TxbSearchBar.TextChanged += TxbSearchBar_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvAsistenciaClientes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(198, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 523);
            panel1.TabIndex = 5;
            // 
            // dgvAsistenciaClientes
            // 
            dgvAsistenciaClientes.AllowUserToAddRows = false;
            dgvAsistenciaClientes.AllowUserToDeleteRows = false;
            dgvAsistenciaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistenciaClientes.BackgroundColor = Color.White;
            dgvAsistenciaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistenciaClientes.Columns.AddRange(new DataGridViewColumn[] { IDAsistenciaCliente, IDCliente, Asistencia, FechaAsistencia });
            dgvAsistenciaClientes.Dock = DockStyle.Fill;
            dgvAsistenciaClientes.Location = new Point(0, 0);
            dgvAsistenciaClientes.Name = "dgvAsistenciaClientes";
            dgvAsistenciaClientes.RowHeadersVisible = false;
            dgvAsistenciaClientes.RowTemplate.Height = 25;
            dgvAsistenciaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistenciaClientes.Size = new Size(887, 523);
            dgvAsistenciaClientes.TabIndex = 0;
            // 
            // IDAsistenciaCliente
            // 
            IDAsistenciaCliente.DataPropertyName = "IDAsistenciaCliente";
            IDAsistenciaCliente.HeaderText = "IDAsistenciaCliente";
            IDAsistenciaCliente.Name = "IDAsistenciaCliente";
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            // 
            // Asistencia
            // 
            Asistencia.DataPropertyName = "Asistencia";
            Asistencia.HeaderText = "Asistencia";
            Asistencia.Name = "Asistencia";
            // 
            // FechaAsistencia
            // 
            FechaAsistencia.DataPropertyName = "FechaAsistencia";
            FechaAsistencia.HeaderText = "FechaAsistencia";
            FechaAsistencia.Name = "FechaAsistencia";
            // 
            // mantenimientoAsistenciaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(panel1);
            Controls.Add(searchbarPanel);
            Controls.Add(sidePanel);
            Controls.Add(subtopPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoAsistenciaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoAsistenciaClientes_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidePanel.ResumeLayout(false);
            searchbarPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsistenciaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel subtopPanel;
        private Panel sidePanel;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Panel searchbarPanel;
        private Guna.UI2.WinForms.Guna2TextBox TxbSearchBar;
        private PictureBox btnCerrar;
        private Panel panel1;
        private DataGridView dgvAsistenciaClientes;
        private DataGridViewTextBoxColumn IDAsistenciaCliente;
        private DataGridViewComboBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Asistencia;
        private DataGridViewTextBoxColumn FechaAsistencia;
    }
}