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
            ((System.ComponentModel.ISupportInitialize)dgvBuscarFactura).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscarFactura
            // 
            dgvBuscarFactura.AllowUserToAddRows = false;
            dgvBuscarFactura.AllowUserToDeleteRows = false;
            dgvBuscarFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarFactura.Columns.AddRange(new DataGridViewColumn[] { IDFactura, IDCliente, IDUsuario, NCF, SubTotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus });
            dgvBuscarFactura.Location = new Point(12, 73);
            dgvBuscarFactura.Name = "dgvBuscarFactura";
            dgvBuscarFactura.ReadOnly = true;
            dgvBuscarFactura.RowTemplate.Height = 25;
            dgvBuscarFactura.Size = new Size(1004, 442);
            dgvBuscarFactura.TabIndex = 0;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            SubTotal.DefaultCellStyle = dataGridViewCellStyle1;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
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
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.DataPropertyName = "FechaVencimiento";
            FechaVencimiento.HeaderText = "FechaVencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 640);
            Controls.Add(dgvBuscarFactura);
            Name = "frmFactura";
            Text = "frmFactura";
            Load += frmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarFactura).EndInit();
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
    }
}