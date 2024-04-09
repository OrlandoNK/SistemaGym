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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvGrupoMembresia = new DataGridView();
            IDGrupoMembresia = new DataGridViewTextBoxColumn();
            IDMembresia = new DataGridViewComboBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 67);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(79, 3);
            label1.Name = "label1";
            label1.Size = new Size(168, 59);
            label1.TabIndex = 3;
            label1.Text = "Grupo Membresia";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_Membership_Group__x32_;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources._BotonXcerrarVentana;
            btnClose.Location = new Point(726, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 33);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvGrupoMembresia);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(771, 422);
            panel3.TabIndex = 3;
            // 
            // dgvGrupoMembresia
            // 
            dgvGrupoMembresia.AllowUserToAddRows = false;
            dgvGrupoMembresia.AllowUserToDeleteRows = false;
            dgvGrupoMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupoMembresia.BackgroundColor = Color.White;
            dgvGrupoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoMembresia.Columns.AddRange(new DataGridViewColumn[] { IDGrupoMembresia, IDMembresia, Nombre, MontoTotal, FechaRegistro, Estatus });
            dgvGrupoMembresia.Dock = DockStyle.Fill;
            dgvGrupoMembresia.Location = new Point(0, 0);
            dgvGrupoMembresia.Name = "dgvGrupoMembresia";
            dgvGrupoMembresia.RowHeadersVisible = false;
            dgvGrupoMembresia.RowTemplate.Height = 25;
            dgvGrupoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoMembresia.Size = new Size(769, 420);
            dgvGrupoMembresia.TabIndex = 1;
            dgvGrupoMembresia.CellDoubleClick += dgvGrupoMembresia_CellDoubleClick;
            // 
            // IDGrupoMembresia
            // 
            IDGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
            IDGrupoMembresia.HeaderText = "IDGrupoMembresia";
            IDGrupoMembresia.Name = "IDGrupoMembresia";
            // 
            // IDMembresia
            // 
            IDMembresia.DataPropertyName = "IDMembresia";
            IDMembresia.HeaderText = "IDMembresia";
            IDMembresia.Name = "IDMembresia";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // MontoTotal
            // 
            MontoTotal.DataPropertyName = "MontoTotal";
            MontoTotal.HeaderText = "MontoTotal";
            MontoTotal.Name = "MontoTotal";
            // 
            // FechaRegistro
            // 
            FechaRegistro.DataPropertyName = "FechaRegistro";
            FechaRegistro.HeaderText = "FechaRegistro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // Estatus
            // 
            Estatus.DataPropertyName = "Estatus";
            Estatus.HeaderText = "Estatus";
            Estatus.Name = "Estatus";
            // 
            // listaGrupoMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 522);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listaGrupoMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listaGrupoMembresia";
            Load += listaGrupoMembresia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvGrupoMembresia;
        private DataGridViewTextBoxColumn IDGrupoMembresia;
        private DataGridViewComboBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}