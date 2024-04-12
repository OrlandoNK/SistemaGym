namespace SistemaGym.UI.Windows
{
    partial class frmFactura
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBuscarFactura = new DataGridView();
            IDFactura = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewComboBoxColumn();
            IDUsuario = new DataGridViewComboBoxColumn();
            NCF = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            TotalDescuento = new DataGridViewTextBoxColumn();
            TotalItbis = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            FechaEmision = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblTitleMantenimientoFacturaMembresia = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            TxbBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarFactura).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBuscarFactura
            // 
            dgvBuscarFactura.AllowUserToAddRows = false;
            dgvBuscarFactura.AllowUserToDeleteRows = false;
            dgvBuscarFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvBuscarFactura.BackgroundColor = Color.White;
            dgvBuscarFactura.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDCliente, IDUsuario, NCF, SubTotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus });
            dgvBuscarFactura.Location = new Point(-1, -1);
            dgvBuscarFactura.Name = "dgvBuscarFactura";
            dgvBuscarFactura.ReadOnly = true;
            dgvBuscarFactura.RowHeadersVisible = false;
            dgvBuscarFactura.RowTemplate.Height = 25;
            dgvBuscarFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarFactura.Size = new Size(817, 368);
            dgvBuscarFactura.TabIndex = 0;
            // 
            // IDFactura
            // 
            IDFactura.DataPropertyName = "IDFactura";
            IDFactura.HeaderText = "ID";
            IDFactura.Name = "IDFactura";
            IDFactura.ReadOnly = true;
            IDFactura.Width = 43;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            IDCliente.Width = 80;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            IDUsuario.Width = 83;
            // 
            // NCF
            // 
            NCF.DataPropertyName = "NCF";
            NCF.HeaderText = "NCF";
            NCF.Name = "NCF";
            NCF.ReadOnly = true;
            NCF.Width = 55;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle1;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 77;
            // 
            // TotalDescuento
            // 
            TotalDescuento.DataPropertyName = "TotalDescuento";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            TotalDescuento.DefaultCellStyle = dataGridViewCellStyle2;
            TotalDescuento.HeaderText = "TotalDescuento";
            TotalDescuento.Name = "TotalDescuento";
            TotalDescuento.ReadOnly = true;
            TotalDescuento.Width = 113;
            // 
            // TotalItbis
            // 
            TotalItbis.DataPropertyName = "TotalItbis";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            TotalItbis.DefaultCellStyle = dataGridViewCellStyle3;
            TotalItbis.HeaderText = "Total Itbis";
            TotalItbis.Name = "TotalItbis";
            TotalItbis.ReadOnly = true;
            TotalItbis.Width = 82;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle4;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 57;
            // 
            // FechaEmision
            // 
            FechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle5.Format = "F";
            dataGridViewCellStyle5.NullValue = null;
            FechaEmision.DefaultCellStyle = dataGridViewCellStyle5;
            FechaEmision.HeaderText = "FechaEmision";
            FechaEmision.Name = "FechaEmision";
            FechaEmision.ReadOnly = true;
            FechaEmision.Width = 105;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.DataPropertyName = "FechaVencimiento";
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            FechaVencimiento.Width = 129;
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
            panel1.Controls.Add(lblTitleMantenimientoFacturaMembresia);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 64);
            panel1.TabIndex = 1;
            // 
            // lblTitleMantenimientoFacturaMembresia
            // 
            lblTitleMantenimientoFacturaMembresia.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMantenimientoFacturaMembresia.ForeColor = Color.Gold;
            lblTitleMantenimientoFacturaMembresia.Location = new Point(71, 5);
            lblTitleMantenimientoFacturaMembresia.Name = "lblTitleMantenimientoFacturaMembresia";
            lblTitleMantenimientoFacturaMembresia.Size = new Size(128, 53);
            lblTitleMantenimientoFacturaMembresia.TabIndex = 8;
            lblTitleMantenimientoFacturaMembresia.Text = "Factura";
            lblTitleMantenimientoFacturaMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._PaymentMembresiaFactura;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(772, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 6;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 37);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 32, 39);
            panel3.Controls.Add(TxbBusqueda);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 62);
            panel3.TabIndex = 3;
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
            TxbBusqueda.Location = new Point(12, 9);
            TxbBusqueda.Name = "TxbBusqueda";
            TxbBusqueda.PasswordChar = '\0';
            TxbBusqueda.PlaceholderForeColor = Color.Silver;
            TxbBusqueda.PlaceholderText = "Buscar";
            TxbBusqueda.SelectedText = "";
            TxbBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxbBusqueda.Size = new Size(793, 44);
            TxbBusqueda.TabIndex = 1;
            TxbBusqueda.TextChanged += TxbBusqueda_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvBuscarFactura);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 380);
            panel4.TabIndex = 4;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 543);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFactura";
            Load += frmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarFactura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuscarFactura;
        private DataGridViewTextBoxColumn IDFactura;
        private DataGridViewComboBoxColumn IDCliente;
        private DataGridViewComboBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn NCF;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn TotalDescuento;
        private DataGridViewTextBoxColumn TotalItbis;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn FechaEmision;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn Estatus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox TxbBusqueda;
        private Panel panel4;
        private PictureBox btnClose;
        private Label lblTitleMantenimientoFacturaMembresia;
        private PictureBox pictureBox1;
    }
}