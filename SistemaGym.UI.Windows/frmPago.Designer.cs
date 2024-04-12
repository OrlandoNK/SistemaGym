namespace SistemaGym.UI.Windows
{
    partial class frmPago
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            lblTitleMantenimientoFacturaMembresia = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            TxbBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            dgvPago = new DataGridView();
            IDPago = new DataGridViewTextBoxColumn();
            IDFacturaProducto = new DataGridViewComboBoxColumn();
            IDFacturaMembresia = new DataGridViewComboBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Pagado = new DataGridViewTextBoxColumn();
            Devuelta = new DataGridViewTextBoxColumn();
            Itbis = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblTitleMantenimientoFacturaMembresia);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 64);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._CloseWindowX;
            pictureBox2.Location = new Point(882, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(1765, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            // 
            // lblTitleMantenimientoFacturaMembresia
            // 
            lblTitleMantenimientoFacturaMembresia.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMantenimientoFacturaMembresia.ForeColor = Color.Gold;
            lblTitleMantenimientoFacturaMembresia.Location = new Point(71, 5);
            lblTitleMantenimientoFacturaMembresia.Name = "lblTitleMantenimientoFacturaMembresia";
            lblTitleMantenimientoFacturaMembresia.Size = new Size(199, 53);
            lblTitleMantenimientoFacturaMembresia.TabIndex = 6;
            lblTitleMantenimientoFacturaMembresia.Text = "Pagos";
            lblTitleMantenimientoFacturaMembresia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VerDetalleFacturaProductos__x32_;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 38);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 485);
            panel3.TabIndex = 4;
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
            btnDelete.Location = new Point(-1, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.Goldenrod;
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(200, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
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
            btnEdit.Location = new Point(-1, 111);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedColor = Color.Goldenrod;
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(200, 51);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 32, 39);
            panel4.Controls.Add(TxbBuscar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 87);
            panel4.TabIndex = 5;
            // 
            // TxbBuscar
            // 
            TxbBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TxbBuscar.BorderRadius = 20;
            TxbBuscar.CustomizableEdges = customizableEdges5;
            TxbBuscar.DefaultText = "";
            TxbBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxbBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxbBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxbBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxbBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxbBuscar.IconLeft = Properties.Resources._BusquedaBar__;
            TxbBuscar.Location = new Point(7, 21);
            TxbBuscar.Name = "TxbBuscar";
            TxbBuscar.PasswordChar = '\0';
            TxbBuscar.PlaceholderForeColor = Color.Silver;
            TxbBuscar.PlaceholderText = "Buscar";
            TxbBuscar.SelectedText = "";
            TxbBuscar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbBuscar.Size = new Size(712, 44);
            TxbBuscar.TabIndex = 0;
            // 
            // dgvPago
            // 
            dgvPago.AllowUserToAddRows = false;
            dgvPago.AllowUserToDeleteRows = false;
            dgvPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPago.BackgroundColor = Color.WhiteSmoke;
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Columns.AddRange(new DataGridViewColumn[] { IDPago, IDFacturaProducto, IDFacturaMembresia, MetodoPago, Monto, Pagado, Devuelta, Itbis, Estatus });
            dgvPago.Dock = DockStyle.Fill;
            dgvPago.Location = new Point(200, 189);
            dgvPago.Name = "dgvPago";
            dgvPago.ReadOnly = true;
            dgvPago.RowHeadersVisible = false;
            dgvPago.RowTemplate.Height = 25;
            dgvPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPago.Size = new Size(727, 398);
            dgvPago.TabIndex = 6;
            // 
            // IDPago
            // 
            IDPago.DataPropertyName = "IDPago";
            IDPago.HeaderText = "IDPago";
            IDPago.Name = "IDPago";
            IDPago.ReadOnly = true;
            // 
            // IDFacturaProducto
            // 
            IDFacturaProducto.DataPropertyName = "IDFacturaProducto";
            IDFacturaProducto.HeaderText = "FacturaProducto";
            IDFacturaProducto.Name = "IDFacturaProducto";
            IDFacturaProducto.ReadOnly = true;
            IDFacturaProducto.Resizable = DataGridViewTriState.True;
            // 
            // IDFacturaMembresia
            // 
            IDFacturaMembresia.DataPropertyName = "IDFacturaMembresia";
            IDFacturaMembresia.HeaderText = "IDFacturaMembresia";
            IDFacturaMembresia.Name = "IDFacturaMembresia";
            IDFacturaMembresia.ReadOnly = true;
            // 
            // MetodoPago
            // 
            MetodoPago.DataPropertyName = "MetodoPago";
            dataGridViewCellStyle1.NullValue = null;
            MetodoPago.DefaultCellStyle = dataGridViewCellStyle1;
            MetodoPago.HeaderText = "MetodoPago";
            MetodoPago.Name = "MetodoPago";
            MetodoPago.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            Monto.DefaultCellStyle = dataGridViewCellStyle2;
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Pagado
            // 
            Pagado.DataPropertyName = "Pagado";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            Pagado.DefaultCellStyle = dataGridViewCellStyle3;
            Pagado.HeaderText = "Pagado";
            Pagado.Name = "Pagado";
            Pagado.ReadOnly = true;
            // 
            // Devuelta
            // 
            Devuelta.DataPropertyName = "Devuelta";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            Devuelta.DefaultCellStyle = dataGridViewCellStyle4;
            Devuelta.HeaderText = "Devuelta";
            Devuelta.Name = "Devuelta";
            Devuelta.ReadOnly = true;
            // 
            // Itbis
            // 
            Itbis.DataPropertyName = "FechaPago";
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            Itbis.DefaultCellStyle = dataGridViewCellStyle5;
            Itbis.HeaderText = "FechaPago";
            Itbis.Name = "Itbis";
            Itbis.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            dataGridViewCellStyle6.NullValue = null;
            Estatus.DefaultCellStyle = dataGridViewCellStyle6;
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 587);
            Controls.Add(dgvPago);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            Load += frmPago_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Label lblTitleMantenimientoFacturaMembresia;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox TxbBuscar;
        private DataGridView dgvPago;
        private DataGridViewTextBoxColumn IDPago;
        private DataGridViewComboBoxColumn IDFacturaProducto;
        private DataGridViewComboBoxColumn IDFacturaMembresia;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Pagado;
        private DataGridViewTextBoxColumn Devuelta;
        private DataGridViewTextBoxColumn Itbis;
        private DataGridViewTextBoxColumn Estatus;
        private PictureBox pictureBox2;
    }
}