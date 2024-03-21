namespace SistemaGym.UI.Windows
{
    partial class frmBuscarProductos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvBuscarProductos = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            IDCategoria = new DataGridViewComboBoxColumn();
            IDProveedor = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            TxbBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscarProductos
            // 
            dgvBuscarProductos.AllowUserToAddRows = false;
            dgvBuscarProductos.AllowUserToDeleteRows = false;
            dgvBuscarProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarProductos.BackgroundColor = Color.White;
            dgvBuscarProductos.Columns.AddRange(new DataGridViewColumn[] { IDProducto, IDCategoria, IDProveedor, Nombre, PrecioUnitario, Stock });
            dgvBuscarProductos.Location = new Point(-1, -3);
            dgvBuscarProductos.Name = "dgvBuscarProductos";
            dgvBuscarProductos.ReadOnly = true;
            dgvBuscarProductos.RowHeadersVisible = false;
            dgvBuscarProductos.RowTemplate.Height = 25;
            dgvBuscarProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarProductos.Size = new Size(771, 395);
            dgvBuscarProductos.TabIndex = 7;
            dgvBuscarProductos.CellDoubleClick += dgvBuscarProductos_CellDoubleClick;
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "ID";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            // 
            // IDCategoria
            // 
            IDCategoria.HeaderText = "Categoria";
            IDCategoria.Name = "IDCategoria";
            IDCategoria.ReadOnly = true;
            IDCategoria.Resizable = DataGridViewTriState.True;
            IDCategoria.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDProveedor
            // 
            IDProveedor.HeaderText = "Proveedor";
            IDProveedor.Name = "IDProveedor";
            IDProveedor.ReadOnly = true;
            IDProveedor.Resizable = DataGridViewTriState.True;
            IDProveedor.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre Producto";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
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
            panel1.Size = new Size(771, 64);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 35);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 32, 39);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TxbBusqueda);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 60);
            panel3.TabIndex = 10;
            // 
            // TxbBusqueda
            // 
            TxbBusqueda.BorderRadius = 20;
            TxbBusqueda.CustomizableEdges = customizableEdges5;
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
            TxbBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxbBusqueda.Size = new Size(747, 43);
            TxbBusqueda.TabIndex = 0;
            TxbBusqueda.TextChanged += TxbBusqueda_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvBuscarProductos);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 393);
            panel4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 4;
            label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box_1942650;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(726, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 552);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscarProductos";
            Text = "frmBuscarProductos";
            Load += frmBuscarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBuscarProductos;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewComboBoxColumn IDCategoria;
        private DataGridViewComboBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox TxbBusqueda;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
    }
}