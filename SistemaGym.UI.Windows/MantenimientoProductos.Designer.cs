namespace SistemaGym.UI.Windows
{
    partial class MantenimientoProductos
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            IDProducto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            IDCategoria = new DataGridViewComboBoxColumn();
            IDProveedor = new DataGridViewComboBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { IDProducto, Nombre, IDCategoria, IDProveedor, PrecioUnitario, Stock });
            dgvProductos.Location = new Point(311, 14);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(641, 233);
            dgvProductos.TabIndex = 10;
            // 
            // IDProducto
            // 
            IDProducto.DataPropertyName = "IDProducto";
            IDProducto.HeaderText = "ID";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // IDCategoria
            // 
            IDCategoria.DataPropertyName = "IDCategoria";
            IDCategoria.HeaderText = "Categoria";
            IDCategoria.Name = "IDCategoria";
            IDCategoria.ReadOnly = true;
            IDCategoria.Resizable = DataGridViewTriState.True;
            IDCategoria.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDProveedor
            // 
            IDProveedor.DataPropertyName = "IDProveedor";
            IDProveedor.HeaderText = "Proveedor";
            IDProveedor.Name = "IDProveedor";
            IDProveedor.ReadOnly = true;
            IDProveedor.Resizable = DataGridViewTriState.True;
            IDProveedor.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "$";
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
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 39);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 531);
            Controls.Add(btnEliminar);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoProductos";
            Text = "MantenimientoProductos";
            Load += MantenimientoProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProductos;
        private Button btnEliminar;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewComboBoxColumn IDCategoria;
        private DataGridViewComboBoxColumn IDProveedor;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
    }
}