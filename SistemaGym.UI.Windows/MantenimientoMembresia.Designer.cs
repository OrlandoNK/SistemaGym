namespace SistemaGym.UI.Windows
{
    partial class frmMembresia
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvMembresia = new DataGridView();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMembresia
            // 
            dgvMembresia.AllowUserToAddRows = false;
            dgvMembresia.AllowUserToDeleteRows = false;
            dgvMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembresia.BackgroundColor = Color.WhiteSmoke;
            dgvMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, Descripcion, Duracion, Valor, FechaCreacion, Estatus });
            dgvMembresia.Location = new Point(-1, -1);
            dgvMembresia.Name = "dgvMembresia";
            dgvMembresia.ReadOnly = true;
            dgvMembresia.RowHeadersVisible = false;
            dgvMembresia.RowTemplate.Height = 25;
            dgvMembresia.Size = new Size(650, 441);
            dgvMembresia.TabIndex = 14;
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "ID Membresia";
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            Valor.DefaultCellStyle = dataGridViewCellStyle5;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            dataGridViewCellStyle6.Format = "g";
            dataGridViewCellStyle6.NullValue = null;
            FechaCreacion.DefaultCellStyle = dataGridViewCellStyle6;
            FechaCreacion.HeaderText = "Fecha Creacion";
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 64);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 36);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 441);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvMembresia);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(221, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(650, 441);
            panel4.TabIndex = 18;
            // 
            // frmMembresia
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(871, 541);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmMembresia";
            Load += frmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Estatus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}