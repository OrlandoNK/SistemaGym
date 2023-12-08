namespace SistemaGym.UI.Windows
{
    partial class listaMembresias
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvListaMembresia = new DataGridView();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaMembresia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 73);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 28);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvListaMembresia);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(681, 456);
            panel3.TabIndex = 2;
            // 
            // dgvListaMembresia
            // 
            dgvListaMembresia.AllowUserToAddRows = false;
            dgvListaMembresia.AllowUserToDeleteRows = false;
            dgvListaMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, Descripcion, Duracion, Valor, FechaCreacion, Estatus });
            dgvListaMembresia.Location = new Point(12, 52);
            dgvListaMembresia.Name = "dgvListaMembresia";
            dgvListaMembresia.ReadOnly = true;
            dgvListaMembresia.RowHeadersVisible = false;
            dgvListaMembresia.RowTemplate.Height = 25;
            dgvListaMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaMembresia.Size = new Size(657, 364);
            dgvListaMembresia.TabIndex = 0;
            dgvListaMembresia.CellDoubleClick += dgvListaMembresia_CellDoubleClick;
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
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Duracion
            // 
            Duracion.DataPropertyName = "Duracion";
            Duracion.HeaderText = "Duracion";
            Duracion.Name = "Duracion";
            Duracion.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            // 
            // listaMembresias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 557);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaMembresias";
            StartPosition = FormStartPosition.CenterScreen;
            Load += listaMembresias_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvListaMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Estatus;
    }
}