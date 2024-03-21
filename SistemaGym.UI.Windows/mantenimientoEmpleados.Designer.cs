namespace SistemaGym.UI.Windows
{
    partial class mantenimientoEmpleados
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            btnBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel5 = new Panel();
            dgvEmpleados = new DataGridView();
            IDEmpleado = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TellCell = new DataGridViewTextBoxColumn();
            TellRes = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(889, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(77, 20);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 2;
            label1.Text = "Empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_empleados_x32;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(844, 16);
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
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 36);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 456);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(205, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 227);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(205, 49);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Modificar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderColor = Color.DarkGoldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.CustomizableEdges = customizableEdges5;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 172);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnRefresh.Size = new Size(205, 49);
            btnRefresh.TabIndex = 1;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.CustomizableEdges = customizableEdges7;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Image = Properties.Resources._NuevaFacturaMembresia;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 117);
            btnNew.Name = "btnNew";
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNew.Size = new Size(205, 49);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.Controls.Add(btnBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(205, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(684, 66);
            panel4.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BorderRadius = 20;
            btnBuscar.CustomizableEdges = customizableEdges9;
            btnBuscar.DefaultText = "";
            btnBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            btnBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            btnBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            btnBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            btnBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            btnBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            btnBuscar.Location = new Point(9, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.PasswordChar = '\0';
            btnBuscar.PlaceholderForeColor = Color.Silver;
            btnBuscar.PlaceholderText = "Buscar";
            btnBuscar.SelectedText = "";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBuscar.Size = new Size(666, 42);
            btnBuscar.TabIndex = 0;
            btnBuscar.TextChanged += btnBuscar_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dgvEmpleados);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(205, 169);
            panel5.Name = "panel5";
            panel5.Size = new Size(684, 390);
            panel5.TabIndex = 4;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvEmpleados.BackgroundColor = Color.WhiteSmoke;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { IDEmpleado, Nombre, Apellido, TipoDocumento, Documento, Direccion, TellCell, TellRes, FechaRegistro, Estatus });
            dgvEmpleados.Location = new Point(-1, -1);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(684, 390);
            dgvEmpleados.TabIndex = 0;
            // 
            // IDEmpleado
            // 
            IDEmpleado.DataPropertyName = "IDEmpleado";
            IDEmpleado.HeaderText = "IDEmpleado";
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Width = 96;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 76;
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 118;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.Width = 95;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.Width = 82;
            // 
            // TellCell
            // 
            TellCell.DataPropertyName = "TellCell";
            TellCell.HeaderText = "TellCell";
            TellCell.Name = "TellCell";
            TellCell.Width = 69;
            // 
            // TellRes
            // 
            TellRes.DataPropertyName = "TellRes";
            TellRes.HeaderText = "TellRes";
            TellRes.Name = "TellRes";
            TellRes.Width = 67;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 106;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.Width = 69;
            // 
            // mantenimientoEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 559);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox btnBuscar;
        private Panel panel5;
        private DataGridView dgvEmpleados;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private PictureBox btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn IDEmpleado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TellCell;
        private DataGridViewTextBoxColumn TellRes;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}