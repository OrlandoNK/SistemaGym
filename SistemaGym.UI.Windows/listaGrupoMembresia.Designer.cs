namespace SistemaGym.UI.Windows
{
    partial class listaGrupoMembresia
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
            panel2 = new Panel();
            btnClose = new PictureBox();
            panel1 = new Panel();
            TxbBusqueda = new TextBox();
            panel4 = new Panel();
            dgvGrupoMembresia = new DataGridView();
            IDGrupoMembresia = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(743, 33);
            panel3.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 79);
            panel2.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_button__x64_;
            btnClose.Location = new Point(665, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 61);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TxbBusqueda);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 77);
            panel1.TabIndex = 13;
            // 
            // TxbBusqueda
            // 
            TxbBusqueda.Location = new Point(12, 18);
            TxbBusqueda.Multiline = true;
            TxbBusqueda.Name = "TxbBusqueda";
            TxbBusqueda.Size = new Size(719, 41);
            TxbBusqueda.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(dgvGrupoMembresia);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 189);
            panel4.Name = "panel4";
            panel4.Size = new Size(743, 352);
            panel4.TabIndex = 14;
            // 
            // dgvGrupoMembresia
            // 
            dgvGrupoMembresia.AllowUserToAddRows = false;
            dgvGrupoMembresia.AllowUserToDeleteRows = false;
            dgvGrupoMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupoMembresia.BackgroundColor = Color.White;
            dgvGrupoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoMembresia.Columns.AddRange(new DataGridViewColumn[] { IDGrupoMembresia, IDMembresia, Nombre, FechaRegistro, Estatus });
            dgvGrupoMembresia.Location = new Point(0, 0);
            dgvGrupoMembresia.Name = "dgvGrupoMembresia";
            dgvGrupoMembresia.ReadOnly = true;
            dgvGrupoMembresia.RowHeadersVisible = false;
            dgvGrupoMembresia.RowTemplate.Height = 25;
            dgvGrupoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoMembresia.Size = new Size(743, 352);
            dgvGrupoMembresia.TabIndex = 0;
            dgvGrupoMembresia.CellDoubleClick += dgvGrupoMembresia_CellDoubleClick;
            // 
            // IDGrupoMembresia
            // 
            IDGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
            IDGrupoMembresia.HeaderText = "IDGrupoMembresia";
            IDGrupoMembresia.Name = "IDGrupoMembresia";
            IDGrupoMembresia.ReadOnly = true;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            IDMembresia.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // listaGrupoMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 541);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaGrupoMembresia";
            Load += listaGrupoMembresia_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private PictureBox btnClose;
        private Panel panel1;
        private TextBox TxbBusqueda;
        private Panel panel4;
        private DataGridView dgvGrupoMembresia;
        private DataGridViewTextBoxColumn IDGrupoMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}