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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtBuscarProducto = new TextBox();
            dgvBuscarProductos = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            IDCategoria = new DataGridViewComboBoxColumn();
            IDProveedor = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(359, 100);
            txtBuscarProducto.Multiline = true;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(354, 20);
            txtBuscarProducto.TabIndex = 8;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // dgvBuscarProductos
            // 
            dgvBuscarProductos.AllowUserToAddRows = false;
            dgvBuscarProductos.AllowUserToDeleteRows = false;
            dgvBuscarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarProductos.Columns.AddRange(new DataGridViewColumn[] { IDProducto, IDCategoria, IDProveedor, Nombre, PrecioUnitario, Stock });
            dgvBuscarProductos.Location = new Point(137, 153);
            dgvBuscarProductos.Name = "dgvBuscarProductos";
            dgvBuscarProductos.ReadOnly = true;
            dgvBuscarProductos.RowTemplate.Height = 25;
            dgvBuscarProductos.Size = new Size(656, 362);
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 103);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 6;
            label1.Text = "Introduzca los datos a buscar";
            // 
            // frmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 615);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvBuscarProductos);
            Controls.Add(label1);
            Name = "frmBuscarProductos";
            Text = "frmBuscarProductos";
            Load += frmBuscarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProducto;
        private DataGridView dgvBuscarProductos;
        private Label label1;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewComboBoxColumn IDCategoria;
        private DataGridViewComboBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
    }
}