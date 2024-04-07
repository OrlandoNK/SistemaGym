namespace SistemaGym.UI.Windows
{
    partial class mantenimientoFacturacionMembresia
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
            panel1 = new Panel();
            lblTitleMantenimientoFacturaMembresia = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel5 = new Panel();
            dgvFacturacionMembresia = new DataGridView();
            IDFactura = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            IDCliente = new DataGridViewComboBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            CargoCredito = new DataGridViewComboBoxColumn();
            CargoDebito = new DataGridViewComboBoxColumn();
            NCF = new DataGridViewTextBoxColumn();
            ValorFactura = new DataGridViewTextBoxColumn();
            FechaEmision = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturacionMembresia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTitleMantenimientoFacturaMembresia);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 64);
            panel1.TabIndex = 0;
            // 
            // lblTitleMantenimientoFacturaMembresia
            // 
            lblTitleMantenimientoFacturaMembresia.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMantenimientoFacturaMembresia.ForeColor = Color.Gold;
            lblTitleMantenimientoFacturaMembresia.Location = new Point(71, 4);
            lblTitleMantenimientoFacturaMembresia.Name = "lblTitleMantenimientoFacturaMembresia";
            lblTitleMantenimientoFacturaMembresia.Size = new Size(199, 53);
            lblTitleMantenimientoFacturaMembresia.TabIndex = 2;
            lblTitleMantenimientoFacturaMembresia.Text = "Facturación Membresia";
            lblTitleMantenimientoFacturaMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_facturacion_membresia__x32_;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._CloseWindowX;
            btnClose.Location = new Point(1024, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 45);
            btnClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 28);
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
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 593);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
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
            btnDelete.HoverState.FillColor = Color.Goldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 290);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(210, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
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
            btnEdit.HoverState.FillColor = Color.Goldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 233);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEdit.Size = new Size(210, 45);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Modificar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BorderColor = Color.DarkGoldenrod;
            btnRefresh.BorderThickness = 1;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.CustomizableEdges = customizableEdges15;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.Transparent;
            btnRefresh.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverState.FillColor = Color.Goldenrod;
            btnRefresh.HoverState.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.refresh_8677771;
            btnRefresh.ImageSize = new Size(25, 25);
            btnRefresh.Location = new Point(-1, 176);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRefresh.Size = new Size(210, 45);
            btnRefresh.TabIndex = 2;
            btnRefresh.TextAlign = HorizontalAlignment.Right;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Transparent;
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.Cursor = Cursors.Hand;
            btnNew.CustomizableEdges = customizableEdges17;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.Goldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources._NuevaFacturaMembresia;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 119);
            btnNew.Name = "btnNew";
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnNew.Size = new Size(210, 45);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.Controls.Add(TxbBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(210, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 60);
            panel4.TabIndex = 3;
            // 
            // TxbBuscar
            // 
            TxbBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbBuscar.BorderRadius = 20;
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
            TxbBuscar.Location = new Point(8, 9);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            TxbBuscar.Size = new Size(859, 43);
            TxbBuscar.TabIndex = 0;
            TxbBuscar.TextChanged += TxbBuscar_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dgvFacturacionMembresia);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(210, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(875, 533);
            panel5.TabIndex = 4;
            // 
            // dgvFacturacionMembresia
            // 
            dgvFacturacionMembresia.AllowUserToAddRows = false;
            dgvFacturacionMembresia.AllowUserToDeleteRows = false;
            dgvFacturacionMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturacionMembresia.BackgroundColor = Color.WhiteSmoke;
            dgvFacturacionMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturacionMembresia.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, ValorFactura, FechaEmision, FechaVencimiento, Estatus });
            dgvFacturacionMembresia.Dock = DockStyle.Fill;
            dgvFacturacionMembresia.Location = new Point(0, 0);
            dgvFacturacionMembresia.Name = "dgvFacturacionMembresia";
            dgvFacturacionMembresia.RowHeadersVisible = false;
            dgvFacturacionMembresia.RowTemplate.Height = 25;
            dgvFacturacionMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturacionMembresia.Size = new Size(875, 533);
            dgvFacturacionMembresia.TabIndex = 0;
            // 
            // IDFactura
            // 
            IDFactura.DataPropertyName = "IDFactura";
            IDFactura.HeaderText = "IDFactura";
            IDFactura.Name = "IDFactura";
            IDFactura.ReadOnly = true;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "Cliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CargoCredito
            // 
            CargoCredito.DataPropertyName = "CargoCredito";
            CargoCredito.HeaderText = "CargoCredito";
            CargoCredito.Name = "CargoCredito";
            CargoCredito.ReadOnly = true;
            CargoCredito.Resizable = DataGridViewTriState.True;
            CargoCredito.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CargoDebito
            // 
            CargoDebito.DataPropertyName = "CargoDebito";
            CargoDebito.HeaderText = "CargoDebito";
            CargoDebito.Name = "CargoDebito";
            CargoDebito.ReadOnly = true;
            CargoDebito.Resizable = DataGridViewTriState.True;
            CargoDebito.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // NCF
            // 
            NCF.DataPropertyName = "NCF";
            NCF.HeaderText = "NCF";
            NCF.Name = "NCF";
            // 
            // ValorFactura
            // 
            ValorFactura.DataPropertyName = "ValorFactura";
            ValorFactura.HeaderText = "ValorFactura";
            ValorFactura.Name = "ValorFactura";
            // 
            // FechaEmision
            // 
            FechaEmision.DataPropertyName = "FechaEmision";
            FechaEmision.HeaderText = "FechaEmision";
            FechaEmision.Name = "FechaEmision";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.DataPropertyName = "FechaVencimiento";
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // mantenimientoFacturacionMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoFacturacionMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoFacturacionMembresia_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturacionMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Label lblTitleMantenimientoFacturaMembresia;
        private PictureBox pictureBox1;
        private DataGridView dgvFacturacionMembresia;
        private DataGridViewTextBoxColumn IDFactura;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewComboBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewComboBoxColumn CargoCredito;
        private DataGridViewComboBoxColumn CargoDebito;
        private DataGridViewTextBoxColumn NCF;
        private DataGridViewTextBoxColumn ValorFactura;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn Estatus;
    }
}