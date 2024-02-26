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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvMembresia = new DataGridView();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            btnNew = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
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
            dgvMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            Valor.DefaultCellStyle = dataGridViewCellStyle1;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            FechaCreacion.DefaultCellStyle = dataGridViewCellStyle2;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 64);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(69, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 2;
            label1.Text = "Membresias";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_membresia_mantenimiento_x32;
            pictureBox1.Location = new Point(11, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btn_close_cerrar_x32;
            btnClose.Location = new Point(805, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 50);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
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
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnrefresh);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 441);
            panel3.TabIndex = 17;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkGoldenrod;
            panel8.Location = new Point(-1, 203);
            panel8.Name = "panel8";
            panel8.Size = new Size(13, 48);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGoldenrod;
            panel7.Location = new Point(-1, 149);
            panel7.Name = "panel7";
            panel7.Size = new Size(13, 48);
            panel7.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGoldenrod;
            panel6.Location = new Point(-1, 95);
            panel6.Name = "panel6";
            panel6.Size = new Size(13, 48);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGoldenrod;
            panel5.Location = new Point(-1, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 48);
            panel5.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.DarkGoldenrod;
            btnDelete.BorderThickness = 1;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.FillColor = Color.DarkGoldenrod;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = Properties.Resources.btn_btn_delete_membresia;
            btnDelete.ImageAlign = HorizontalAlignment.Left;
            btnDelete.ImageSize = new Size(25, 25);
            btnDelete.Location = new Point(11, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(209, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.TextAlign = HorizontalAlignment.Right;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.DarkGoldenrod;
            btnEdit.BorderThickness = 1;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CustomizableEdges = customizableEdges3;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.HoverState.FillColor = Color.DarkGoldenrod;
            btnEdit.HoverState.ForeColor = Color.Black;
            btnEdit.Image = Properties.Resources.btn_btn_edit_membresia_x32;
            btnEdit.ImageAlign = HorizontalAlignment.Left;
            btnEdit.ImageSize = new Size(25, 25);
            btnEdit.Location = new Point(11, 149);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEdit.Size = new Size(209, 48);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Modificar";
            btnEdit.TextAlign = HorizontalAlignment.Right;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BorderColor = Color.DarkGoldenrod;
            btnrefresh.BorderThickness = 1;
            btnrefresh.Cursor = Cursors.Hand;
            btnrefresh.CustomizableEdges = customizableEdges5;
            btnrefresh.DisabledState.BorderColor = Color.DarkGray;
            btnrefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnrefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnrefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnrefresh.FillColor = Color.Transparent;
            btnrefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.HoverState.FillColor = Color.DarkGoldenrod;
            btnrefresh.HoverState.ForeColor = Color.Black;
            btnrefresh.Image = Properties.Resources.btn_btn_actualizar_membresias_x32;
            btnrefresh.ImageSize = new Size(32, 32);
            btnrefresh.Location = new Point(11, 95);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnrefresh.Size = new Size(209, 48);
            btnrefresh.TabIndex = 1;
            btnrefresh.TextAlign = HorizontalAlignment.Right;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnNew
            // 
            btnNew.BorderColor = Color.DarkGoldenrod;
            btnNew.BorderThickness = 1;
            btnNew.Cursor = Cursors.Hand;
            btnNew.CustomizableEdges = customizableEdges7;
            btnNew.DisabledState.BorderColor = Color.DarkGray;
            btnNew.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNew.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNew.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNew.FillColor = Color.Transparent;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.HoverState.FillColor = Color.DarkGoldenrod;
            btnNew.HoverState.ForeColor = Color.Black;
            btnNew.Image = Properties.Resources.btn_Nueva_Membresia_x32;
            btnNew.ImageAlign = HorizontalAlignment.Left;
            btnNew.ImageSize = new Size(25, 25);
            btnNew.Location = new Point(11, 41);
            btnNew.Name = "btnNew";
            btnNew.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNew.Size = new Size(209, 48);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.TextAlign = HorizontalAlignment.Right;
            btnNew.Click += btnNew_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMembresia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembresia).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private PictureBox btnClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}