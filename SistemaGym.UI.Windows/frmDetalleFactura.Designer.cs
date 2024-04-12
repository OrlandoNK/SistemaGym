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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvDetalle = new DataGridView();
            IDDetalleFacturaProductos = new DataGridViewTextBoxColumn();
            IDFacturaProducto = new DataGridViewComboBoxColumn();
            IDProducto = new DataGridViewComboBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Itbis = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { IDDetalleFacturaProductos, IDFacturaProducto, IDProducto, Precio, Cantidad, SubTotal, Descuento, Itbis, Total });
            dgvDetalle.Location = new Point(-3, 28);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(959, 581);
            dgvDetalle.TabIndex = 0;
            // 
            // IDDetalleFacturaProductos
            // 
            IDDetalleFacturaProductos.DataPropertyName = "IDDetalleFacturaProductos";
            IDDetalleFacturaProductos.HeaderText = "ID";
            IDDetalleFacturaProductos.Name = "IDDetalleFacturaProductos";
            IDDetalleFacturaProductos.ReadOnly = true;
            // 
            // IDFacturaProducto
            // 
            IDFacturaProducto.HeaderText = "Factura";
            IDFacturaProducto.Name = "IDFacturaProducto";
            IDFacturaProducto.ReadOnly = true;
            IDFacturaProducto.Resizable = DataGridViewTriState.True;
            IDFacturaProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDProducto
            // 
            IDProducto.HeaderText = "Producto";
            IDProducto.Name = "IDProducto";
            IDProducto.ReadOnly = true;
            IDProducto.Resizable = DataGridViewTriState.True;
            IDProducto.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle1;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle2;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Descuento.DefaultCellStyle = dataGridViewCellStyle3;
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            // 
            // Itbis
            // 
            Itbis.DataPropertyName = "Itbis";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            Itbis.DefaultCellStyle = dataGridViewCellStyle4;
            Itbis.HeaderText = "Itbis";
            Itbis.Name = "Itbis";
            Itbis.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // frmDetalleFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 593);
            Controls.Add(dgvDetalle);
            Name = "frmDetalleFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalleFactura";
            Load += frmDetalleFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn IDDetalleFacturaProductos;
        private DataGridViewComboBoxColumn IDFacturaProducto;
        private DataGridViewComboBoxColumn IDProducto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Itbis;
        private DataGridViewTextBoxColumn Total;
    }
}