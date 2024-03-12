﻿namespace SistemaGym.UI.Windows
{
    partial class frmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCliente = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            IDTipoListaCliente = new DataGridViewComboBoxColumn();
            IDTipoCliente = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TelCell = new DataGridViewTextBoxColumn();
            TelRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnUpdateDGV = new Guna.UI2.WinForms.Guna2Button();
            btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.BackgroundColor = Color.White;
            dgvCliente.ColumnHeadersHeight = 22;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, IDTipoListaCliente, IDTipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus });
            dgvCliente.Location = new Point(-1, -1);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(705, 389);
            dgvCliente.TabIndex = 72;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDMembresia
            // 
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoListaCliente
            // 
            IDTipoListaCliente.HeaderText = "Tipo Lista Cliente";
            IDTipoListaCliente.Name = "IDTipoListaCliente";
            IDTipoListaCliente.Resizable = DataGridViewTriState.True;
            IDTipoListaCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.HeaderText = "Tipo Cliente";
            IDTipoCliente.Name = "IDTipoCliente";
            IDTipoCliente.Resizable = DataGridViewTriState.True;
            IDTipoCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // TelCell
            // 
            TelCell.DataPropertyName = "TelCell";
            TelCell.HeaderText = "TelCell";
            TelCell.Name = "TelCell";
            // 
            // TelRes
            // 
            TelRes.DataPropertyName = "TelRes";
            TelRes.HeaderText = "TelRes";
            TelRes.Name = "TelRes";
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 61);
            panel1.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(71, 17);
            label1.Name = "label1";
            label1.Size = new Size(216, 24);
            label1.TabIndex = 2;
            label1.Text = "Mantenimiento Clientes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._Clientes_mainScreen_;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(860, 13);
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
            panel2.Size = new Size(905, 34);
            panel2.TabIndex = 74;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnUpdateDGV);
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 459);
            panel3.TabIndex = 75;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.Transparent;
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(200, 47);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Eliminar";
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges13;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 152);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.Transparent;
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEdit.Size = new Size(200, 47);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "&Editar";
            // 
            // btnUpdateDGV
            // 
            btnUpdateDGV.BorderColor = Color.DarkGoldenrod;
            btnUpdateDGV.BorderThickness = 1;
            btnUpdateDGV.Cursor = Cursors.Hand;
            btnUpdateDGV.CustomizableEdges = customizableEdges15;
            btnUpdateDGV.DisabledState.BorderColor = Color.DarkGray;
            btnUpdateDGV.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdateDGV.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdateDGV.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdateDGV.FillColor = Color.Transparent;
            btnUpdateDGV.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateDGV.ForeColor = Color.White;
            btnUpdateDGV.HoverState.FillColor = Color.DarkGoldenrod;
            btnUpdateDGV.HoverState.ForeColor = Color.Black;
            btnUpdateDGV.Image = Properties.Resources._RefrescarFacturaMembresia___;
            btnUpdateDGV.ImageSize = new Size(25, 25);
            btnUpdateDGV.Location = new Point(-1, 99);
            btnUpdateDGV.Name = "btnUpdateDGV";
            btnUpdateDGV.PressedColor = Color.Transparent;
            btnUpdateDGV.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnUpdateDGV.Size = new Size(200, 47);
            btnUpdateDGV.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderColor = Color.DarkGoldenrod;
            btnGuardar.BorderThickness = 1;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = customizableEdges17;
            btnGuardar.DisabledState.BorderColor = Color.DarkGray;
            btnGuardar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGuardar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGuardar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGuardar.FillColor = Color.Transparent;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.DarkGoldenrod;
            btnGuardar.HoverState.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources._NewFacturaProduct;
            btnGuardar.ImageAlign = HorizontalAlignment.Left;
            btnGuardar.ImageSize = new Size(25, 25);
            btnGuardar.Location = new Point(-1, 46);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedColor = Color.Transparent;
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnGuardar.Size = new Size(200, 47);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "&Nuevo";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TxbBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(705, 70);
            panel4.TabIndex = 76;
            // 
            // TxbBuscar
            // 
            TxbBuscar.BorderRadius = 25;
            TxbBuscar.CustomizableEdges = customizableEdges19;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(3, 9);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            TxbBuscar.Size = new Size(735, 51);
            TxbBuscar.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dgvCliente);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(200, 165);
            panel5.Name = "panel5";
            panel5.Size = new Size(705, 389);
            panel5.TabIndex = 77;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 554);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCliente;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewComboBoxColumn IDTipoListaCliente;
        private DataGridViewComboBoxColumn IDTipoCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TelCell;
        private DataGridViewTextBoxColumn TelRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDGV;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Label label1;
    }
}