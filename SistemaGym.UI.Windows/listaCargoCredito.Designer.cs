namespace SistemaGym.UI.Windows
{
    partial class listaCargoCredito
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
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvListaCargoCredito = new DataGridView();
            IDCargoCredito = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaCargo = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCargoCredito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 55);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._CloseWindowX;
            btnClose.Location = new Point(713, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 45);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 34);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(dgvListaCargoCredito);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 382);
            panel3.TabIndex = 2;
            // 
            // dgvListaCargoCredito
            // 
            dgvListaCargoCredito.AllowUserToAddRows = false;
            dgvListaCargoCredito.AllowUserToDeleteRows = false;
            dgvListaCargoCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCargoCredito.BackgroundColor = Color.WhiteSmoke;
            dgvListaCargoCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCargoCredito.Columns.AddRange(new DataGridViewColumn[] { IDCargoCredito, IDCliente, Cargo, Monto, FechaCargo, Estatus });
            dgvListaCargoCredito.Location = new Point(0, 0);
            dgvListaCargoCredito.Name = "dgvListaCargoCredito";
            dgvListaCargoCredito.ReadOnly = true;
            dgvListaCargoCredito.RowHeadersVisible = false;
            dgvListaCargoCredito.RowTemplate.Height = 25;
            dgvListaCargoCredito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCargoCredito.Size = new Size(774, 382);
            dgvListaCargoCredito.TabIndex = 0;
            dgvListaCargoCredito.CellDoubleClick += dgvListaCargoCredito_CellDoubleClick;
            // 
            // IDCargoCredito
            // 
            IDCargoCredito.DataPropertyName = "IDCargoCredito";
            IDCargoCredito.HeaderText = "IDCargoCredito";
            IDCargoCredito.Name = "IDCargoCredito";
            IDCargoCredito.ReadOnly = true;
            // 
            // IDCliente
            // 
            IDCliente.DataPropertyName = "IDCliente";
            IDCliente.HeaderText = "IDCliente";
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "Cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            Monto.DefaultCellStyle = dataGridViewCellStyle1;
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // FechaCargo
            // 
            FechaCargo.DataPropertyName = "FechaCargo";
            FechaCargo.HeaderText = "FechaCargo";
            FechaCargo.Name = "FechaCargo";
            FechaCargo.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // listaCargoCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 471);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaCargoCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Load += listaCargoCredito_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaCargoCredito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvListaCargoCredito;
        private PictureBox btnClose;
        private DataGridViewTextBoxColumn IDCargoCredito;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaCargo;
        private DataGridViewTextBoxColumn Estatus;
    }
}