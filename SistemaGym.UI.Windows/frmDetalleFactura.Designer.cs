namespace SistemaGym.UI.Windows
{
    partial class frmDetalleFactura
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            IDDetalleFacturaProductos = new DataGridViewTextBoxColumn();
            IDFacturaProductos = new DataGridViewComboBoxColumn();
            Producto = new DataGridViewComboBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Itbis = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDDetalleFacturaProductos, IDFacturaProductos, Producto, Precio, Cantidad, SubTotal, Descuento, Itbis, Total });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(968, 593);
            dataGridView1.TabIndex = 0;
            // 
            // IDDetalleFacturaProductos
            // 
            IDDetalleFacturaProductos.HeaderText = "ID";
            IDDetalleFacturaProductos.Name = "IDDetalleFacturaProductos";
            // 
            // IDFacturaProductos
            // 
            IDFacturaProductos.HeaderText = "Factura";
            IDFacturaProductos.Name = "IDFacturaProductos";
            IDFacturaProductos.Resizable = DataGridViewTriState.True;
            IDFacturaProductos.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Resizable = DataGridViewTriState.True;
            Producto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Precio
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle6;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle7;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // Descuento
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle8;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            // 
            // Itbis
            // 
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            Itbis.DefaultCellStyle = dataGridViewCellStyle9;
            Itbis.HeaderText = "Itbis";
            Itbis.Name = "Itbis";
            Itbis.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle10;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // frmDetalleFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 593);
            Controls.Add(dataGridView1);
            Name = "frmDetalleFactura";
            Text = "frmDetalleFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDDetalleFacturaProductos;
        private DataGridViewComboBoxColumn IDFacturaProductos;
        private DataGridViewComboBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Itbis;
        private DataGridViewTextBoxColumn Total;
    }
}