namespace SistemaGym.UI.Windows
{
    partial class frmBuscarCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBuscarClientes = new DataGridView();
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
            btnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            TxbBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBuscarClientes
            // 
            dgvBuscarClientes.AllowUserToAddRows = false;
            dgvBuscarClientes.AllowUserToDeleteRows = false;
            dgvBuscarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvBuscarClientes.BackgroundColor = Color.White;
            dgvBuscarClientes.Columns.AddRange(new DataGridViewColumn[] { IDCliente, IDUsuario, IDMembresia, IDTipoListaCliente, IDTipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus });
            dgvBuscarClientes.Location = new Point(-1, -1);
            dgvBuscarClientes.Name = "dgvBuscarClientes";
            dgvBuscarClientes.ReadOnly = true;
            dgvBuscarClientes.RowHeadersVisible = false;
            dgvBuscarClientes.RowTemplate.Height = 25;
            dgvBuscarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarClientes.Size = new Size(810, 411);
            dgvBuscarClientes.TabIndex = 1;
            dgvBuscarClientes.CellDoubleClick += dgvBuscarClientes_CellDoubleClick;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.DataPropertyName = "IDUsuario";
            IDUsuario.HeaderText = "Usuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            IDUsuario.Width = 72;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "Membresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            IDMembresia.Resizable = DataGridViewTriState.True;
            IDMembresia.SortMode = DataGridViewColumnSortMode.Automatic;
            IDMembresia.Width = 91;
            // 
            // IDTipoListaCliente
            // 
            IDTipoListaCliente.DataPropertyName = "IDTipoListaCliente";
            IDTipoListaCliente.HeaderText = "Tipo Lista";
            IDTipoListaCliente.Name = "IDTipoListaCliente";
            IDTipoListaCliente.ReadOnly = true;
            IDTipoListaCliente.Resizable = DataGridViewTriState.True;
            IDTipoListaCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            IDTipoListaCliente.Width = 82;
            // 
            // IDTipoCliente
            // 
            IDTipoCliente.DataPropertyName = "IDTipoCliente";
            IDTipoCliente.HeaderText = "TipoCliente";
            IDTipoCliente.Name = "IDTipoCliente";
            IDTipoCliente.ReadOnly = true;
            IDTipoCliente.Resizable = DataGridViewTriState.True;
            IDTipoCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            IDTipoCliente.Width = 92;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 76;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 76;
            // 
            // TipoDocumento
            // 
            TipoDocumento.DataPropertyName = "TipoDocumento";
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Width = 121;
            // 
            // Documento
            // 
            Documento.DataPropertyName = "Documento";
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 95;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 82;
            // 
            // TelCell
            // 
            TelCell.DataPropertyName = "TelCell";
            TelCell.HeaderText = "TelCell";
            TelCell.Name = "TelCell";
            TelCell.ReadOnly = true;
            TelCell.Width = 66;
            // 
            // TelRes
            // 
            TelRes.DataPropertyName = "TelRes";
            TelRes.HeaderText = "TelRes";
            TelRes.Name = "TelRes";
            TelRes.ReadOnly = true;
            TelRes.Width = 64;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            FechaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 106;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 69;
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
            panel1.Size = new Size(810, 63);
            panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(765, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 4;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._Clientes_mainScreen_;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 26);
            panel2.TabIndex = 4;
            // 
            // TxbBusqueda
            // 
            TxbBusqueda.BorderRadius = 20;
            TxbBusqueda.CustomizableEdges = customizableEdges1;
            TxbBusqueda.DefaultText = "";
            TxbBusqueda.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBusqueda.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBusqueda.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBusqueda.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBusqueda.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBusqueda.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBusqueda.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBusqueda.Location = new Point(11, 8);
            TxbBusqueda.Name = "TxbBusqueda";
            TxbBusqueda.PasswordChar = '\0';
            TxbBusqueda.PlaceholderForeColor = Color.Silver;
            TxbBusqueda.PlaceholderText = "Buscar";
            TxbBusqueda.SelectedText = "";
            TxbBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxbBusqueda.Size = new Size(786, 41);
            TxbBusqueda.TabIndex = 5;
            TxbBusqueda.TextChanged += TxbBusqueda_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 32, 39);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TxbBusqueda);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 59);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvBuscarClientes);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 411);
            panel4.TabIndex = 7;
            // 
            // frmBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 559);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscarCliente";
            Load += frmBuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBuscarClientes;
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
        private Guna.UI2.WinForms.Guna2TextBox TxbBusqueda;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
    }
}