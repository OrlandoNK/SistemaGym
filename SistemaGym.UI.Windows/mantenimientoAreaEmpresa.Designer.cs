﻿namespace SistemaGym.UI.Windows
{
    partial class mantenimientoAreaEmpresa
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
            pictureBox1 = new PictureBox();
            btnCerrar = new PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            subtopPanel = new Panel();
            sidePanel = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            searchbarPanel = new Panel();
            TxbSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            fillPanel = new Panel();
            dgvAreaEmpresa = new DataGridView();
            IDArea = new DataGridViewTextBoxColumn();
            Encargado = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            sidePanel.SuspendLayout();
            searchbarPanel.SuspendLayout();
            fillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAreaEmpresa).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(btnCerrar);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1085, 64);
            topPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_area_empresa_gym_logo__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            btnCerrar.TabIndex = 2;
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
            guna2HtmlLabel1.Size = new Size(104, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Áreas GYM";
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
            subtopPanel.TabIndex = 1;
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
            sidePanel.TabIndex = 2;
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
            searchbarPanel.TabIndex = 3;
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
            TxbSearchBar.Location = new Point(9, 10);
            TxbSearchBar.Name = "TxbSearchBar";
            TxbSearchBar.PasswordChar = '\0';
            TxbSearchBar.PlaceholderForeColor = Color.Silver;
            TxbSearchBar.PlaceholderText = "Buscar";
            TxbSearchBar.SelectedText = "";
            TxbSearchBar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TxbSearchBar.Size = new Size(867, 40);
            TxbSearchBar.TabIndex = 0;
            TxbSearchBar.TextChanged += TxbSearchBar_TextChanged;
            // 
            // fillPanel
            // 
            fillPanel.BackColor = Color.WhiteSmoke;
            fillPanel.BorderStyle = BorderStyle.FixedSingle;
            fillPanel.Controls.Add(dgvAreaEmpresa);
            fillPanel.Dock = DockStyle.Fill;
            fillPanel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fillPanel.Location = new Point(198, 162);
            fillPanel.Name = "fillPanel";
            fillPanel.Size = new Size(887, 523);
            fillPanel.TabIndex = 4;
            // 
            // dgvAreaEmpresa
            // 
            dgvAreaEmpresa.AllowUserToAddRows = false;
            dgvAreaEmpresa.AllowUserToDeleteRows = false;
            dgvAreaEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAreaEmpresa.BackgroundColor = Color.WhiteSmoke;
            dgvAreaEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAreaEmpresa.Columns.AddRange(new DataGridViewColumn[] { IDArea, Encargado, Nombre, Descripcion, FechaRegistro });
            dgvAreaEmpresa.Dock = DockStyle.Fill;
            dgvAreaEmpresa.Location = new Point(0, 0);
            dgvAreaEmpresa.Name = "dgvAreaEmpresa";
            dgvAreaEmpresa.RowHeadersVisible = false;
            dgvAreaEmpresa.RowTemplate.Height = 25;
            dgvAreaEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAreaEmpresa.Size = new Size(885, 521);
            dgvAreaEmpresa.TabIndex = 0;
            // 
            // IDArea
            // 
            IDArea.DataPropertyName = "IDArea";
            IDArea.HeaderText = "IDArea";
            IDArea.Name = "IDArea";
            // 
            // Encargado
            // 
            Encargado.DataPropertyName = "Encargado";
            Encargado.HeaderText = "Encargado";
            Encargado.Name = "Encargado";
            Encargado.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // mantenimientoAreaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(fillPanel);
            Controls.Add(searchbarPanel);
            Controls.Add(sidePanel);
            Controls.Add(subtopPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoAreaEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoAreaEmpresa_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            sidePanel.ResumeLayout(false);
            searchbarPanel.ResumeLayout(false);
            fillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAreaEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel subtopPanel;
        private Panel sidePanel;
        private Panel searchbarPanel;
        private Panel fillPanel;
        private Guna.UI2.WinForms.Guna2TextBox TxbSearchBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private PictureBox btnCerrar;
        private PictureBox pictureBox1;
        private DataGridView dgvAreaEmpresa;
        private DataGridViewTextBoxColumn IDArea;
        private DataGridViewComboBoxColumn Encargado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaRegistro;
    }
}