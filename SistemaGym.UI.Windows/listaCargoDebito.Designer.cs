namespace SistemaGym.UI.Windows
{
    partial class listaCargoDebito
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
            panel3 = new Panel();
            dgvListaCargoDebito = new DataGridView();
            IDCargoDebito = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            FechaCargo = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCargoDebito).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(dgvListaCargoDebito);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 382);
            panel3.TabIndex = 5;
            // 
            // dgvListaCargoDebito
            // 
            dgvListaCargoDebito.AllowUserToAddRows = false;
            dgvListaCargoDebito.AllowUserToDeleteRows = false;
            dgvListaCargoDebito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaCargoDebito.BackgroundColor = Color.WhiteSmoke;
            dgvListaCargoDebito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCargoDebito.Columns.AddRange(new DataGridViewColumn[] { IDCargoDebito, IDCliente, Cargo, Monto, FechaCargo, Estatus });
            dgvListaCargoDebito.Location = new Point(0, 0);
            dgvListaCargoDebito.Name = "dgvListaCargoDebito";
            dgvListaCargoDebito.ReadOnly = true;
            dgvListaCargoDebito.RowHeadersVisible = false;
            dgvListaCargoDebito.RowTemplate.Height = 25;
            dgvListaCargoDebito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaCargoDebito.Size = new Size(774, 382);
            dgvListaCargoDebito.TabIndex = 1;
            dgvListaCargoDebito.CellDoubleClick += dgvListaCargoDebito_CellDoubleClick;
            // 
            // IDCargoDebito
            // 
            IDCargoDebito.DataPropertyName = "IDCargoDebito";
            IDCargoDebito.HeaderText = "IDCargoDebito";
            IDCargoDebito.Name = "IDCargoDebito";
            IDCargoDebito.ReadOnly = true;
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
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 34);
            panel2.TabIndex = 4;
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
            panel1.TabIndex = 3;
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
            // listaCargoDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 471);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaCargoDebito";
            StartPosition = FormStartPosition.CenterScreen;
            Load += listaCargoDebito_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaCargoDebito).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dgvListaCargoDebito;
        private DataGridViewTextBoxColumn IDCargoDebito;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn FechaCargo;
        private DataGridViewTextBoxColumn Estatus;
        private PictureBox btnClose;
    }
}