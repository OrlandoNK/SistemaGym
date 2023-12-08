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
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dtpFechaRegistro = new DateTimePicker();
            btnBuscar = new Button();
            TxbIDMembresia = new TextBox();
            button5 = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            cmbxEstatus = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TxbNombre = new TextBox();
            panel4 = new Panel();
            button4 = new Button();
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
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 31);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightYellow;
            panel3.Controls.Add(dtpFechaRegistro);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(TxbIDMembresia);
            panel3.Controls.Add(button5);
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
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Enabled = false;
            dtpFechaRegistro.Location = new Point(5, 410);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(259, 23);
            dtpFechaRegistro.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = Properties.Resources.buscar;
            btnBuscar.Location = new Point(179, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(65, 50);
            btnBuscar.TabIndex = 9;
            btnBuscar.UseVisualStyleBackColor = true;
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
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(138, 324);
            button5.Name = "button5";
            button5.Size = new Size(106, 29);
            button5.TabIndex = 7;
            button5.Text = "&Quitar";
            button5.UseVisualStyleBackColor = true;
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
            // panel4
            // 
            panel4.BackColor = Color.Ivory;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(dgvGrupoMembresia);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(268, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(672, 478);
            panel4.TabIndex = 3;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(535, 388);
            button4.Name = "button4";
            button4.Size = new Size(127, 38);
            button4.TabIndex = 8;
            button4.Text = "&Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(402, 388);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvGrupoMembresia
            // 
            dgvGrupoMembresia.AllowUserToAddRows = false;
            dgvGrupoMembresia.AllowUserToDeleteRows = false;
            dgvGrupoMembresia.AllowUserToOrderColumns = true;
            dgvGrupoMembresia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupoMembresia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupoMembresia.Columns.AddRange(new DataGridViewColumn[] { IDMembresia, Nombre, FechaRegistro, Estatus });
            dgvGrupoMembresia.Location = new Point(11, 73);
            dgvGrupoMembresia.Name = "dgvGrupoMembresia";
            dgvGrupoMembresia.ReadOnly = true;
            dgvGrupoMembresia.RowHeadersVisible = false;
            dgvGrupoMembresia.RowTemplate.Height = 25;
            dgvGrupoMembresia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupoMembresia.Size = new Size(651, 309);
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
        private Button button4;
        private Button btnGuardar;
        private Button button5;
        private ErrorProvider errorProvider;
        private TextBox TxbIDMembresia;
        private DataGridViewTextBoxColumn IDMembresia;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn Estatus;
        private Button btnBuscar;
        private DateTimePicker dtpFechaRegistro;
    }
}