﻿namespace SistemaGym.UI.Windows
{
    partial class frmRol
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
            dgvRol = new DataGridView();
            IDRol = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRol).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRol
            // 
            dgvRol.AllowUserToAddRows = false;
            dgvRol.AllowUserToDeleteRows = false;
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRol.BackgroundColor = Color.WhiteSmoke;
            dgvRol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRol.Columns.AddRange(new DataGridViewColumn[] { IDRol, Nombre, Descripcion });
            dgvRol.Dock = DockStyle.Fill;
            dgvRol.Location = new Point(0, 0);
            dgvRol.Name = "dgvRol";
            dgvRol.RowHeadersVisible = false;
            dgvRol.RowTemplate.Height = 25;
            dgvRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRol.Size = new Size(883, 526);
            dgvRol.TabIndex = 3;
            // 
            // IDRol
            // 
            IDRol.DataPropertyName = "IDRol";
            IDRol.HeaderText = "IDRol";
            IDRol.Name = "IDRol";
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
            panel1.Size = new Size(1085, 61);
            panel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(62, 17);
            label8.Name = "label8";
            label8.Size = new Size(56, 24);
            label8.TabIndex = 6;
            label8.Text = "Roles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_role__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(1040, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 26);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 598);
            panel3.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderColor = Color.DarkGoldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.DarkGoldenrod;
            btnRefresh.HoverState.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(200, 45);
            btnRefresh.TabIndex = 3;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.CustomizableEdges = customizableEdges3;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.DarkGoldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources._NuevaFacturaMembresia;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 69);
            btnNew.Name = "btnNew";
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNew.Size = new Size(200, 45);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.CustomizableEdges = customizableEdges5;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDelete.Size = new Size(200, 45);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges7;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 171);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEdit.Size = new Size(200, 45);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Modificar";
            btnEdit.Click += btnEdit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 32, 39);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(200, 87);
            panel5.Name = "panel5";
            panel5.Size = new Size(885, 70);
            panel5.TabIndex = 14;
            // 
            // TxbBuscar
            // 
            TxbBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges9;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(5, 14);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TxbBuscar.Size = new Size(870, 41);
            TxbBuscar.TabIndex = 0;
            TxbBuscar.TextChanged += TxbBuscar_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvRol);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(200, 157);
            panel6.Name = "panel6";
            panel6.Size = new Size(885, 528);
            panel6.TabIndex = 15;
            // 
            // frmRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRol";
            Load += frmRol_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRol).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvRol;
        private DataGridViewTextBoxColumn IDRol;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Label label8;
        private PictureBox pictureBox1;
    }
}