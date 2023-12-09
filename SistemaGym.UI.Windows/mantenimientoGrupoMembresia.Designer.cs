namespace SistemaGym.UI.Windows
{
    partial class mantenimientoGrupoMembresia
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnagregarMembresia = new Button();
            btnBuscar = new Button();
            TxbIDMembresia = new TextBox();
            btnQuitar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            cmbxEstatus = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TxbNombre = new TextBox();
            dtpFechaRegistro = new DateTimePicker();
            panel4 = new Panel();
            btnTraerGrupoMembresia = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dgvGrupoMembresia = new DataGridView();
            IDMembresia = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 75);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close_button__x64_;
            btnClose.Location = new Point(875, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 31);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Beige;
            panel3.Controls.Add(btnagregarMembresia);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(TxbIDMembresia);
            panel3.Controls.Add(btnQuitar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmbxEstatus);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxbNombre);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 478);
            panel3.TabIndex = 2;
            // 
            // btnagregarMembresia
            // 
            btnagregarMembresia.BackColor = Color.Black;
            btnagregarMembresia.Cursor = Cursors.Hand;
            btnagregarMembresia.FlatAppearance.BorderColor = Color.Gold;
            btnagregarMembresia.FlatAppearance.BorderSize = 2;
            btnagregarMembresia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnagregarMembresia.FlatStyle = FlatStyle.Flat;
            btnagregarMembresia.Image = Properties.Resources.nuevaMembresia;
            btnagregarMembresia.Location = new Point(137, 73);
            btnagregarMembresia.Name = "btnagregarMembresia";
            btnagregarMembresia.Size = new Size(46, 38);
            btnagregarMembresia.TabIndex = 11;
            btnagregarMembresia.UseVisualStyleBackColor = false;
            btnagregarMembresia.Click += btnagregarMembresia_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Gold;
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = Properties.Resources.buscar__1_;
            btnBuscar.Location = new Point(189, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(55, 50);
            btnBuscar.TabIndex = 9;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TxbIDMembresia
            // 
            TxbIDMembresia.Anchor = AnchorStyles.None;
            TxbIDMembresia.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TxbIDMembresia.Location = new Point(25, 87);
            TxbIDMembresia.Name = "TxbIDMembresia";
            TxbIDMembresia.ReadOnly = true;
            TxbIDMembresia.Size = new Size(106, 24);
            TxbIDMembresia.TabIndex = 10;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.None;
            btnQuitar.Cursor = Cursors.Hand;
            btnQuitar.Location = new Point(138, 324);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(106, 29);
            btnQuitar.TabIndex = 7;
            btnQuitar.Text = "&Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(25, 324);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(25, 224);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 5;
            label3.Text = "Estatus";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbxEstatus
            // 
            cmbxEstatus.Anchor = AnchorStyles.None;
            cmbxEstatus.Cursor = Cursors.Hand;
            cmbxEstatus.FormattingEnabled = true;
            cmbxEstatus.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido", "Cancelado", "Vencido", "En Espera de Aprobacion", "Prueba Gratuita" });
            cmbxEstatus.Location = new Point(25, 250);
            cmbxEstatus.Name = "cmbxEstatus";
            cmbxEstatus.Size = new Size(219, 23);
            cmbxEstatus.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(25, 149);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 2;
            label1.Text = "idMembresia";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxbNombre
            // 
            TxbNombre.Anchor = AnchorStyles.None;
            TxbNombre.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TxbNombre.Location = new Point(25, 175);
            TxbNombre.Name = "TxbNombre";
            TxbNombre.ReadOnly = true;
            TxbNombre.Size = new Size(219, 24);
            TxbNombre.TabIndex = 1;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Cursor = Cursors.No;
            dtpFechaRegistro.Enabled = false;
            dtpFechaRegistro.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaRegistro.Location = new Point(11, 449);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(651, 24);
            dtpFechaRegistro.TabIndex = 11;
            dtpFechaRegistro.Value = new DateTime(2023, 12, 8, 19, 26, 49, 0);
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnTraerGrupoMembresia);
            panel4.Controls.Add(dtpFechaRegistro);
            panel4.Controls.Add(btnEliminar);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(dgvGrupoMembresia);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(268, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(672, 478);
            panel4.TabIndex = 3;
            // 
            // btnTraerGrupoMembresia
            // 
            btnTraerGrupoMembresia.BackColor = Color.Black;
            btnTraerGrupoMembresia.Cursor = Cursors.Hand;
            btnTraerGrupoMembresia.FlatAppearance.BorderColor = Color.Gold;
            btnTraerGrupoMembresia.FlatAppearance.BorderSize = 2;
            btnTraerGrupoMembresia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnTraerGrupoMembresia.FlatStyle = FlatStyle.Flat;
            btnTraerGrupoMembresia.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraerGrupoMembresia.ForeColor = Color.Gold;
            btnTraerGrupoMembresia.Image = Properties.Resources.traerMemberGrupo;
            btnTraerGrupoMembresia.ImageAlign = ContentAlignment.MiddleLeft;
            btnTraerGrupoMembresia.Location = new Point(430, 16);
            btnTraerGrupoMembresia.Name = "btnTraerGrupoMembresia";
            btnTraerGrupoMembresia.Size = new Size(232, 46);
            btnTraerGrupoMembresia.TabIndex = 12;
            btnTraerGrupoMembresia.Text = "&Traer Grupos de Membresia";
            btnTraerGrupoMembresia.TextAlign = ContentAlignment.MiddleRight;
            btnTraerGrupoMembresia.UseVisualStyleBackColor = false;
            btnTraerGrupoMembresia.Click += btnTraerGrupoMembresia_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Image = Properties.Resources.eliminar_grupoMembresia;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(548, 388);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(5, 0, 0, 0);
            btnEliminar.Size = new Size(112, 55);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Gold;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft YaHei UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Gold;
            btnGuardar.Image = Properties.Resources.guardar_grupoMembresia;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(430, 388);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(5, 0, 0, 0);
            btnGuardar.Size = new Size(112, 55);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvGrupoMembresia
            // 
            dgvGrupoMembresia.AllowUserToAddRows = false;
            dgvGrupoMembresia.AllowUserToDeleteRows = false;
            dgvGrupoMembresia.AllowUserToOrderColumns = true;
            dgvGrupoMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupoMembresia.BackgroundColor = Color.White;
            dgvGrupoMembresia.BorderStyle = BorderStyle.None;
            dgvGrupoMembresia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Gold;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvGrupoMembresia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvGrupoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, FechaRegistro, Estatus });
            dgvGrupoMembresia.Location = new Point(0, 73);
            dgvGrupoMembresia.Name = "dgvGrupoMembresia";
            dgvGrupoMembresia.ReadOnly = true;
            dgvGrupoMembresia.RowHeadersVisible = false;
            dgvGrupoMembresia.RowTemplate.Height = 25;
            dgvGrupoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoMembresia.Size = new Size(672, 309);
            dgvGrupoMembresia.TabIndex = 0;
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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // mantenimientoGrupoMembresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 584);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mantenimientoGrupoMembresia";
            StartPosition = FormStartPosition.CenterScreen;
            Load += mantenimientoGrupoMembresia_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupoMembresia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btnClose;
        private Panel panel3;
        private Panel panel4;
        private TextBox TxbNombre;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmbxEstatus;
        private DataGridView dgvGrupoMembresia;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnQuitar;
        private ErrorProvider errorProvider;
        private TextBox TxbIDMembresia;
        private Button btnBuscar;
        private DateTimePicker dtpFechaRegistro;
        private Button btnTraerGrupoMembresia;
        private Button btnagregarMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
    }
}