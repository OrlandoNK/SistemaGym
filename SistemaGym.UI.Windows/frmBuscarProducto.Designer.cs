namespace SistemaGym.UI.Windows
{
    partial class frmBuscarProducto
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
            txtBuscarProducto = new TextBox();
            dgvBuscarProductos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(337, 28);
            txtBuscarProducto.Multiline = true;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(354, 20);
            txtBuscarProducto.TabIndex = 5;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // dgvBuscarProductos
            // 
            dgvBuscarProductos.AllowUserToAddRows = false;
            dgvBuscarProductos.AllowUserToDeleteRows = false;
            dgvBuscarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarProductos.Location = new Point(115, 81);
            dgvBuscarProductos.Name = "dgvBuscarProductos";
            dgvBuscarProductos.ReadOnly = true;
            dgvBuscarProductos.RowTemplate.Height = 25;
            dgvBuscarProductos.Size = new Size(656, 362);
            dgvBuscarProductos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 31);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 3;
            label1.Text = "Introduzca los datos a buscar";
            // 
            // frmBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 556);
            Controls.Add(txtBuscarProducto);
            Controls.Add(dgvBuscarProductos);
            Controls.Add(label1);
            Name = "frmBuscarProducto";
            Text = "frmBuscarProducto";
            Load += frmBuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscarProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProducto;
        private DataGridView dgvBuscarProductos;
        private Label label1;
    }
}