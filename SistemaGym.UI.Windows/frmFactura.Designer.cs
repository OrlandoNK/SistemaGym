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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDCliente, IDUsuario, NCF, SubTotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus });
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1004, 442);
            dataGridView1.TabIndex = 0;
            // 
            // IDFactura
            // 
            IDFactura.DataPropertyName = "IDFactura";
            IDFactura.HeaderText = "ID";
            IDFactura.Name = "IDFactura";
            IDFactura.ReadOnly = true;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.Name = "IDUsuario";
            IDUsuario.ReadOnly = true;
            IDUsuario.Resizable = DataGridViewTriState.True;
            IDUsuario.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // NCF
            // 
            NCF.DataPropertyName = "NCF";
            NCF.HeaderText = "NCF";
            NCF.Name = "NCF";
            NCF.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle6;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // TotalDescuento
            // 
            TotalDescuento.DataPropertyName = "TotalDescuento";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            TotalDescuento.DefaultCellStyle = dataGridViewCellStyle7;
            TotalDescuento.HeaderText = "TotalDescuento";
            TotalDescuento.Name = "TotalDescuento";
            TotalDescuento.ReadOnly = true;
            // 
            // TotalItbis
            // 
            TotalItbis.DataPropertyName = "TotalItbis";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            TotalItbis.DefaultCellStyle = dataGridViewCellStyle8;
            TotalItbis.HeaderText = "Total Itbis";
            TotalItbis.Name = "TotalItbis";
            TotalItbis.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle9;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // FechaEmision
            // 
            FechaEmision.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle10.Format = "F";
            dataGridViewCellStyle10.NullValue = null;
            FechaEmision.DefaultCellStyle = dataGridViewCellStyle10;
            FechaEmision.HeaderText = "FechaEmision";
            FechaEmision.Name = "FechaEmision";
            FechaEmision.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 640);
            Controls.Add(dataGridView1);
            Name = "frmFactura";
            Text = "frmFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
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
    }
}