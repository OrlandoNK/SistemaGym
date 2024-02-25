﻿namespace SistemaGym.UI.Windows
{
    partial class MantenimientoProveedores
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            dgvProveedores = new DataGridView();
            IDProveedor = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.BorderColor = Color.Goldenrod;
            btnNuevo.BorderThickness = 1;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.CustomizableEdges = customizableEdges9;
            btnNuevo.DisabledState.BorderColor = Color.DarkGray;
            btnNuevo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNuevo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNuevo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNuevo.FillColor = Color.Transparent;
            btnNuevo.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.HoverState.FillColor = Color.FromArgb(39, 57, 80);
            btnNuevo.HoverState.ForeColor = Color.Azure;
            btnNuevo.Image = Properties.Resources.New_Icon_x32;
            btnNuevo.ImageAlign = HorizontalAlignment.Left;
            btnNuevo.ImageSize = new Size(25, 25);
            btnNuevo.Location = new Point(-1, 25);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnNuevo.Size = new Size(208, 40);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = HorizontalAlignment.Right;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BorderColor = Color.Goldenrod;
            btnEliminar.BorderThickness = 1;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.CustomizableEdges = customizableEdges11;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.Transparent;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.HoverState.FillColor = Color.FromArgb(39, 57, 80);
            btnEliminar.HoverState.ForeColor = Color.Azure;
            btnEliminar.Image = Properties.Resources.Delete_Icon_x32_;
            btnEliminar.ImageAlign = HorizontalAlignment.Left;
            btnEliminar.ImageSize = new Size(25, 25);
            btnEliminar.Location = new Point(-1, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEliminar.Size = new Size(208, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = HorizontalAlignment.Right;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BorderColor = Color.Goldenrod;
            btnEditar.BorderThickness = 1;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.CustomizableEdges = customizableEdges13;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.Transparent;
            btnEditar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.HoverState.FillColor = Color.FromArgb(39, 57, 80);
            btnEditar.HoverState.ForeColor = Color.Azure;
            btnEditar.Image = Properties.Resources.icon_for_editing_button_x32;
            btnEditar.ImageAlign = HorizontalAlignment.Left;
            btnEditar.ImageSize = new Size(25, 25);
            btnEditar.Location = new Point(-1, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEditar.Size = new Size(208, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Modificar";
            btnEditar.TextAlign = HorizontalAlignment.Right;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.LightBlue;
            dataGridViewCellStyle6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(39, 57, 80);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 100, 182);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProveedores.Anchor = AnchorStyles.None;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(39, 57, 80);
            dataGridViewCellStyle7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 100, 182);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { IDProveedor, Nombre, Telefono, Direccion, FechaRegistro, Estatus });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightBlue;
            dataGridViewCellStyle8.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(39, 57, 80);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 100, 182);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle8;
            dgvProveedores.Location = new Point(-1, -3);
            dgvProveedores.Name = "dgvProveedores";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(39, 57, 80);
            dataGridViewCellStyle9.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 100, 182);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.LightBlue;
            dataGridViewCellStyle10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(39, 57, 80);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 100, 182);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(637, 446);
            dgvProveedores.TabIndex = 0;
            // 
            // IDProveedor
            // 
            IDProveedor.DataPropertyName = "IDProveedor";
            IDProveedor.HeaderText = "IDProveedor";
            IDProveedor.Name = "IDProveedor";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
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
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 58);
            panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.btn_cerrar_ventana_x_x32;
            btnClose.Location = new Point(795, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 42);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(71, 16);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 1;
            label1.Text = "Proveedores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono_proveedor_x32_qsy_xd;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 35);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnNuevo);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 443);
            panel3.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.None;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderColor = Color.Goldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.CustomizableEdges = customizableEdges15;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.FromArgb(39, 57, 80);
            btnRefresh.HoverState.ForeColor = Color.Azure;
            btnRefresh.Image = Properties.Resources.btn_actualizar_lista_proveedores_x32;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 71);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRefresh.Size = new Size(208, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.TextAlign = HorizontalAlignment.Right;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvProveedores);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(208, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(637, 443);
            panel4.TabIndex = 9;
            // 
            // MantenimientoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(845, 536);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenimientoProveedores";
            Load += MantenimientoProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TxbNombre;
        private Guna.UI2.WinForms.Guna2TextBox TxbTelefono;
        private Guna.UI2.WinForms.Guna2TextBox TxbDireccion;
        private Guna.UI2.WinForms.Guna2TextBox TxbEstatus;
        private DataGridView dgvProveedores;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private DataGridViewTextBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}