namespace SistemaGym.UI.Windows
{
    partial class mantenimientoGrupoClientes
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
            btnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel5 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            dgvGrupoClientes = new DataGridView();
            IDGrupoCliente = new DataGridViewTextBoxColumn();
            IDGrupoMembresia = new DataGridViewComboBoxColumn();
            IDCliente = new DataGridViewComboBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupoClientes).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1085, 64);
            panel1.TabIndex = 18;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(1040, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(69, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 2;
            label1.Text = "Grupo Clientes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Membership_Group__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 36);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnrefresh);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 585);
            panel3.TabIndex = 20;
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
            btnDelete.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources._EliminarFacturaMembresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(-1, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(221, 45);
            btnDelete.TabIndex = 3;
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
            btnEdit.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources._EditarFacturaMembresia;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(-1, 239);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(221, 45);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Modificar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BorderColor = Color.DarkGoldenrod;
            btnrefresh.BorderThickness = 1;
            btnrefresh.Cursor = Cursors.Hand;
            btnrefresh.CustomizableEdges = customizableEdges5;
            btnrefresh.DisabledState.BorderColor = Color.DarkGray;
            btnrefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnrefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnrefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnrefresh.FillColor = Color.Transparent;
            btnrefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.HoverState.FillColor = Color.DarkGoldenrod;
            btnrefresh.HoverState.ForeColor = Color.Black;
            btnrefresh.Image = Properties.Resources.refresh_8677771;
            btnrefresh.ImageSize = new Size(32, 32);
            btnrefresh.Location = new Point(-1, 182);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnrefresh.Size = new Size(221, 45);
            btnrefresh.TabIndex = 1;
            btnrefresh.TextAlign = HorizontalAlignment.Right;
            btnrefresh.Click += btnrefresh_Click;
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
            btnNew.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.DarkGoldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources._NewFacturaProduct;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(-1, 125);
            btnNew.Name = "btnNew";
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNew.Size = new Size(221, 45);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.Click += btnNew_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 32, 39);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TxbBuscar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(221, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(864, 59);
            panel5.TabIndex = 21;
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
            TxbBuscar.Location = new Point(8, 6);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TxbBuscar.Size = new Size(846, 44);
            TxbBuscar.TabIndex = 0;
            TxbBuscar.TextChanged += TxbBuscar_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvGrupoClientes);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(221, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(864, 526);
            panel4.TabIndex = 22;
            // 
            // dgvGrupoClientes
            // 
            dgvGrupoClientes.AllowUserToAddRows = false;
            dgvGrupoClientes.AllowUserToDeleteRows = false;
            dgvGrupoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupoClientes.BackgroundColor = Color.WhiteSmoke;
            dgvGrupoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoClientes.Columns.AddRange(new DataGridViewColumn[] { IDGrupoCliente, IDGrupoMembresia, IDCliente, Monto, FechaRegistro, Estatus });
            dgvGrupoClientes.Dock = DockStyle.Fill;
            dgvGrupoClientes.Location = new Point(0, 0);
            dgvGrupoClientes.Name = "dgvGrupoClientes";
            dgvGrupoClientes.RowHeadersVisible = false;
            dgvGrupoClientes.RowTemplate.Height = 25;
            dgvGrupoClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoClientes.Size = new Size(862, 524);
            dgvGrupoClientes.TabIndex = 0;
            // 
            // IDGrupoCliente
            // 
            IDGrupoCliente.DataPropertyName = "IDGrupoCliente";
            IDGrupoCliente.HeaderText = "IDGrupoCliente";
            IDGrupoCliente.Name = "IDGrupoCliente";
            // 
            // IDGrupoMembresia
            // 
            IDGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
            IDGrupoMembresia.HeaderText = "IDGrupoMembresia";
            IDGrupoMembresia.Name = "IDGrupoMembresia";
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
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
            // mantenimientoGrupoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 685);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoGrupoClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mantenimientoGrupoClientes";
            Load += mantenimientoGrupoClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupoClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private Panel panel4;
        private DataGridView dgvGrupoClientes;
        private DataGridViewTextBoxColumn IDGrupoCliente;
        private DataGridViewComboBoxColumn IDGrupoMembresia;
        private DataGridViewComboBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}